﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Contexts;
using Gov.Lclb.Cllb.Public.Contexts.Microsoft.Dynamics.CRM;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.OData.Client;
using Newtonsoft.Json;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly Contexts.Microsoft.Dynamics.CRM.System _system;
        private readonly IDistributedCache _distributedCache;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(Contexts.Microsoft.Dynamics.CRM.System context, IConfiguration configuration, IDistributedCache distributedCache, IHttpContextAccessor httpContextAccessor)
        {
            Configuration = configuration;
            this._system = context;
            this._distributedCache = distributedCache;
            this._httpContextAccessor = httpContextAccessor;
        }


        /// <summary>
        /// Get all Legal Entities
        /// </summary>
        /// <param name="shareholder"></param>
        /// <returns></returns>
        [HttpGet()]
        public async Task<JsonResult> GetDynamicsAccounts()
        {
            List<ViewModels.Account> result = new List<ViewModels.Account>();
            IEnumerable<Contexts.Microsoft.Dynamics.CRM.Account> accounts = null;
            accounts = await _system.Accounts.ExecuteAsync();            

            foreach (var legalEntity in accounts)
            {
                result.Add(legalEntity.ToViewModel());
            }

            return Json(result);
        }

        /// <summary>
        /// Get a specific legal entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccount(string id)
        {
            ViewModels.Account result = null;
            // query the Dynamics system to get the legal entity record.

            Guid? accountid = new Guid(id);
            Contexts.Microsoft.Dynamics.CRM.Account account = null;
            if (accountid != null)
            {
                try
                {
                    account = await _system.Accounts.ByKey(accountid).GetValueAsync();
                    result = account.ToViewModel();
                }
                catch (Microsoft.OData.Client.DataServiceQueryException dsqe)
                {
                    return new NotFoundResult();
                }
            }

            return Json(result);
        }


        [HttpPost()]
        public async Task<JsonResult> CreateDynamicsAccount([FromBody] ViewModels.Account item)
        {
            // create a new account
            Contexts.Microsoft.Dynamics.CRM.Account account = new Contexts.Microsoft.Dynamics.CRM.Account();

            DataServiceCollection<Contexts.Microsoft.Dynamics.CRM.Account> AccountCollection = new DataServiceCollection<Contexts.Microsoft.Dynamics.CRM.Account>(_system);
            DataServiceCollection<Contexts.Microsoft.Dynamics.CRM.Contact> ContactCollection = new DataServiceCollection<Contexts.Microsoft.Dynamics.CRM.Contact>(_system);

            AccountCollection.Add(account);
            account.CopyValues(item);

            if (item.primarycontact != null)
            {
                // get the contact.
                Contexts.Microsoft.Dynamics.CRM.Contact contact = new Contexts.Microsoft.Dynamics.CRM.Contact();
                contact.Fullname = item.primarycontact.name;
                contact.Contactid = new Guid(item.primarycontact.id);
                account.Primarycontactid = contact;
            }

            await _system.SaveChangesAsync(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            // if we have not yet authenticated, then this is the new record for the user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);
            if (userSettings.IsNewUserRegistration)
            {

                // we can now authenticate.
                if (userSettings.AuthenticatedUser == null)
                {
                    Models.User user = new Models.User();
                    user.Active = true;
                    user.Guid = userSettings.ContactId;
                    user.SmUserId = userSettings.UserId;
                    userSettings.AuthenticatedUser = user;
                }

                userSettings.IsNewUserRegistration = false;

                string userSettingsString = JsonConvert.SerializeObject(userSettings);
                // add the user to the session.
                _httpContextAccessor.HttpContext.Session.SetString("UserSettings", userSettingsString);

            }

            return Json(account.ToViewModel());
        }

        /// <summary>
        /// Update a legal entity
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDynamicsAccount([FromBody] ViewModels.Account item, string id)
        {
            if (id != item.id)
            {
                return BadRequest();
            }

            // get the legal entity.
            Guid accountid = new Guid(id);
            Contexts.Microsoft.Dynamics.CRM.Account account = await _system.Accounts.ByKey(accountid).GetValueAsync();

            // copy values over from the data provided
            account.CopyValues(item);

            _system.UpdateObject(account);

            // PostOnlySetProperties is used so that settings such as owner will get set properly by the dynamics server.

            DataServiceResponse dsr = await _system.SaveChangesAsync(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset); 

            return Json(account.ToViewModel());
        }

        /// <summary>
        /// Delete a legal entity.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteDynamicsAccount(string id)
        {
            // get the legal entity.
            Guid adoxio_legalentityid = new Guid(id);
            try
            {
                Contexts.Microsoft.Dynamics.CRM.Account account = await _system.Accounts.ByKey(adoxio_legalentityid).GetValueAsync();
                _system.DeleteObject(account);
                DataServiceResponse dsr = await _system.SaveChangesAsync();
            }
            catch (Microsoft.OData.Client.DataServiceQueryException dsqe)
            {
                return new NotFoundResult();
            }

            return NoContent(); // 204
        }

        /// <summary>
        /// Get Directors and Officers for a given Account (Business)
        /// </summary>
        /// <returns>JSON list of directors and officers (Legal entities)</returns>
        [HttpGet("{id}/directorsandofficers")]
        public async Task<IActionResult> GetAccountDirectorsAndOfficers(string id)
        {
            List<ViewModels.AdoxioLegalEntity> result = new List<ViewModels.AdoxioLegalEntity>();
            var legalEntities = await _system.Adoxio_legalentities
                 // select all records for which there is a matching account and the position is director or officer.
                 // 3 is Director, 4 is Officer
                 .AddQueryOption("$filter", "_adoxio_account_value eq " + id + " and (adoxio_position eq 3 or adoxio_position eq 4)")
                 .ExecuteAsync();

            foreach (var legalEntity in legalEntities)
            {
                result.Add(legalEntity.ToViewModel());
            }
            return Json(result);
        }

    }
}