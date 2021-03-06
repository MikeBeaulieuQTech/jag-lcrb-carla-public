// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_complaincemeeting
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioComplaincemeeting
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioComplaincemeeting class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioComplaincemeeting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioComplaincemeeting class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioComplaincemeeting(string _adoxioInspectionValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string adoxioComplaincemeetingid = default(string), long? versionnumber = default(long?), int? timezoneruleversionnumber = default(int?), string adoxioName = default(string), string _owneridValue = default(string), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string _createdbyValue = default(string), string _owninguserValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _adoxioLicenceValue = default(string), System.DateTimeOffset? adoxioMeetingdate = default(System.DateTimeOffset?), string _owningteamValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioTopic = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioComplaincemeetingSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioComplaincemeetingDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioComplaincemeetingDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioComplaincemeetingAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioComplaincemeetingBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMincident adoxioInspection = default(MicrosoftDynamicsCRMincident))
        {
            this._adoxioInspectionValue = _adoxioInspectionValue;
            Overriddencreatedon = overriddencreatedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            AdoxioComplaincemeetingid = adoxioComplaincemeetingid;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioName = adoxioName;
            this._owneridValue = _owneridValue;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            AdoxioMeetingdate = adoxioMeetingdate;
            this._owningteamValue = _owningteamValue;
            Createdon = createdon;
            AdoxioTopic = adoxioTopic;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioComplaincemeetingSyncErrors = adoxioComplaincemeetingSyncErrors;
            AdoxioComplaincemeetingDuplicateMatchingRecord = adoxioComplaincemeetingDuplicateMatchingRecord;
            AdoxioComplaincemeetingDuplicateBaseRecord = adoxioComplaincemeetingDuplicateBaseRecord;
            AdoxioComplaincemeetingAsyncOperations = adoxioComplaincemeetingAsyncOperations;
            AdoxioComplaincemeetingBulkDeleteFailures = adoxioComplaincemeetingBulkDeleteFailures;
            AdoxioLicence = adoxioLicence;
            AdoxioInspection = adoxioInspection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspection_value")]
        public string _adoxioInspectionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complaincemeetingid")]
        public string AdoxioComplaincemeetingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_meetingdate")]
        public System.DateTimeOffset? AdoxioMeetingdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_topic")]
        public string AdoxioTopic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complaincemeeting_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioComplaincemeetingSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complaincemeeting_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioComplaincemeetingDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complaincemeeting_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioComplaincemeetingDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complaincemeeting_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioComplaincemeetingAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complaincemeeting_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioComplaincemeetingBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Inspection")]
        public MicrosoftDynamicsCRMincident AdoxioInspection { get; set; }

    }
}
