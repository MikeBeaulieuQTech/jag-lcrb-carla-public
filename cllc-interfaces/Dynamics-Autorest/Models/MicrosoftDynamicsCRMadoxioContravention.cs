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
    /// adoxio_contravention
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioContravention
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContravention class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContravention()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioContravention class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioContravention(int? adoxioMinperiod = default(int?), object exchangerate = default(object), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string _adoxioAreaidValue = default(string), string _adoxioLicenseeidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioDatetime = default(System.DateTimeOffset?), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? adoxioOutcomedecisiondate = default(System.DateTimeOffset?), string _createdbyValue = default(string), object adoxioMaxpenalty = default(object), string _owninguserValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioName = default(string), int? importsequencenumber = default(int?), int? adoxioMaxperiod = default(int?), string _adoxioLicenceidValue = default(string), string adoxioInspectorsummary = default(string), object adoxioRecommendedmonetarypenalty = default(object), int? adoxioCategory = default(int?), string _adoxioInspectionidValue = default(string), string _transactioncurrencyidValue = default(string), long? versionnumber = default(long?), int? adoxioRecommendedclosureperiod = default(int?), string _adoxioRegionalmanageridValue = default(string), System.DateTimeOffset? adoxioRmapprovaldecisiondate = default(System.DateTimeOffset?), int? adoxioNumberofoffence = default(int?), int? adoxioIswaivedbylicensee = default(int?), object adoxioMaxpenaltyBase = default(object), int? adoxioItemnumber = default(int?), int? adoxioOutcome = default(int?), int? adoxioRmapprovaldecision = default(int?), int? statecode = default(int?), string adoxioRmsummary = default(string), string _owningbusinessunitValue = default(string), object adoxioMinpenalty = default(object), object adoxioMinpenaltyBase = default(object), string adoxioContraventionid = default(string), int? adoxioIscontraventionconfirmed = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioReference = default(string), object adoxioRecommendedmonetarypenaltyBase = default(object), string adoxioInterpretation = default(string), string _owningteamValue = default(string), string _adoxioContraventiontitleidValue = default(string), string _adoxioEstablishmentidValue = default(string), string _owneridValue = default(string), string _adoxioCompliantidValue = default(string), int? adoxioRecommendedaction = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioContraventionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioContraventionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioContraventionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioContraventionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMadoxioContraventionadmin adoxioContraventionTitleID = default(MicrosoftDynamicsCRMadoxioContraventionadmin), MicrosoftDynamicsCRMadoxioComplaint adoxioCompliantId = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMincident adoxioInspectionId = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMadoxioEstablishment adoxioEstablishmentId = default(MicrosoftDynamicsCRMadoxioEstablishment), MicrosoftDynamicsCRMadoxioArea adoxioAreaId = default(MicrosoftDynamicsCRMadoxioArea), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceId = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMsystemuser adoxioRegionalManagerId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMaccount adoxioLicenseeId = default(MicrosoftDynamicsCRMaccount))
        {
            AdoxioMinperiod = adoxioMinperiod;
            Exchangerate = exchangerate;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._adoxioAreaidValue = _adoxioAreaidValue;
            this._adoxioLicenseeidValue = _adoxioLicenseeidValue;
            Createdon = createdon;
            AdoxioDatetime = adoxioDatetime;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioOutcomedecisiondate = adoxioOutcomedecisiondate;
            this._createdbyValue = _createdbyValue;
            AdoxioMaxpenalty = adoxioMaxpenalty;
            this._owninguserValue = _owninguserValue;
            Modifiedon = modifiedon;
            AdoxioName = adoxioName;
            Importsequencenumber = importsequencenumber;
            AdoxioMaxperiod = adoxioMaxperiod;
            this._adoxioLicenceidValue = _adoxioLicenceidValue;
            AdoxioInspectorsummary = adoxioInspectorsummary;
            AdoxioRecommendedmonetarypenalty = adoxioRecommendedmonetarypenalty;
            AdoxioCategory = adoxioCategory;
            this._adoxioInspectionidValue = _adoxioInspectionidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Versionnumber = versionnumber;
            AdoxioRecommendedclosureperiod = adoxioRecommendedclosureperiod;
            this._adoxioRegionalmanageridValue = _adoxioRegionalmanageridValue;
            AdoxioRmapprovaldecisiondate = adoxioRmapprovaldecisiondate;
            AdoxioNumberofoffence = adoxioNumberofoffence;
            AdoxioIswaivedbylicensee = adoxioIswaivedbylicensee;
            AdoxioMaxpenaltyBase = adoxioMaxpenaltyBase;
            AdoxioItemnumber = adoxioItemnumber;
            AdoxioOutcome = adoxioOutcome;
            AdoxioRmapprovaldecision = adoxioRmapprovaldecision;
            Statecode = statecode;
            AdoxioRmsummary = adoxioRmsummary;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioMinpenalty = adoxioMinpenalty;
            AdoxioMinpenaltyBase = adoxioMinpenaltyBase;
            AdoxioContraventionid = adoxioContraventionid;
            AdoxioIscontraventionconfirmed = adoxioIscontraventionconfirmed;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            AdoxioReference = adoxioReference;
            AdoxioRecommendedmonetarypenaltyBase = adoxioRecommendedmonetarypenaltyBase;
            AdoxioInterpretation = adoxioInterpretation;
            this._owningteamValue = _owningteamValue;
            this._adoxioContraventiontitleidValue = _adoxioContraventiontitleidValue;
            this._adoxioEstablishmentidValue = _adoxioEstablishmentidValue;
            this._owneridValue = _owneridValue;
            this._adoxioCompliantidValue = _adoxioCompliantidValue;
            AdoxioRecommendedaction = adoxioRecommendedaction;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioContraventionSyncErrors = adoxioContraventionSyncErrors;
            AdoxioContraventionDuplicateMatchingRecord = adoxioContraventionDuplicateMatchingRecord;
            AdoxioContraventionDuplicateBaseRecord = adoxioContraventionDuplicateBaseRecord;
            AdoxioContraventionAsyncOperations = adoxioContraventionAsyncOperations;
            AdoxioContraventionBulkDeleteFailures = adoxioContraventionBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioContraventionTitleID = adoxioContraventionTitleID;
            AdoxioCompliantId = adoxioCompliantId;
            AdoxioInspectionId = adoxioInspectionId;
            AdoxioEstablishmentId = adoxioEstablishmentId;
            AdoxioAreaId = adoxioAreaId;
            AdoxioLicenceId = adoxioLicenceId;
            AdoxioRegionalManagerId = adoxioRegionalManagerId;
            AdoxioLicenseeId = adoxioLicenseeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minperiod")]
        public int? AdoxioMinperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_areaid_value")]
        public string _adoxioAreaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenseeid_value")]
        public string _adoxioLicenseeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_datetime")]
        public System.DateTimeOffset? AdoxioDatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_outcomedecisiondate")]
        public System.DateTimeOffset? AdoxioOutcomedecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxpenalty")]
        public object AdoxioMaxpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxperiod")]
        public int? AdoxioMaxperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenceid_value")]
        public string _adoxioLicenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inspectorsummary")]
        public string AdoxioInspectorsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedmonetarypenalty")]
        public object AdoxioRecommendedmonetarypenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspectionid_value")]
        public string _adoxioInspectionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedclosureperiod")]
        public int? AdoxioRecommendedclosureperiod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionalmanagerid_value")]
        public string _adoxioRegionalmanageridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmapprovaldecisiondate")]
        public System.DateTimeOffset? AdoxioRmapprovaldecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_numberofoffence")]
        public int? AdoxioNumberofoffence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iswaivedbylicensee")]
        public int? AdoxioIswaivedbylicensee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_maxpenalty_base")]
        public object AdoxioMaxpenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_itemnumber")]
        public int? AdoxioItemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_outcome")]
        public int? AdoxioOutcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmapprovaldecision")]
        public int? AdoxioRmapprovaldecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmsummary")]
        public string AdoxioRmsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minpenalty")]
        public object AdoxioMinpenalty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_minpenalty_base")]
        public object AdoxioMinpenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contraventionid")]
        public string AdoxioContraventionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_iscontraventionconfirmed")]
        public int? AdoxioIscontraventionconfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reference")]
        public string AdoxioReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedmonetarypenalty_base")]
        public object AdoxioRecommendedmonetarypenaltyBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interpretation")]
        public string AdoxioInterpretation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contraventiontitleid_value")]
        public string _adoxioContraventiontitleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_establishmentid_value")]
        public string _adoxioEstablishmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_compliantid_value")]
        public string _adoxioCompliantidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedaction")]
        public int? AdoxioRecommendedaction { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_contravention_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioContraventionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioContraventionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioContraventionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioContraventionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContraventionTitleID")]
        public MicrosoftDynamicsCRMadoxioContraventionadmin AdoxioContraventionTitleID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_CompliantId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioCompliantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectionId")]
        public MicrosoftDynamicsCRMincident AdoxioInspectionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EstablishmentId")]
        public MicrosoftDynamicsCRMadoxioEstablishment AdoxioEstablishmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AreaId")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioAreaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceId")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalManagerId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenseeId")]
        public MicrosoftDynamicsCRMaccount AdoxioLicenseeId { get; set; }

    }
}
