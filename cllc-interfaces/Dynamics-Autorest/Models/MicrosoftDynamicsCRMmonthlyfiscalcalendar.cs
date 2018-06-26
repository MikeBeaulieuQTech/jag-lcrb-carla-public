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

    public partial class MicrosoftDynamicsCRMmonthlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMmonthlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMmonthlyfiscalcalendar(IList<MicrosoftDynamicsCRMasyncoperation> monthlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> monthlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), string _businessunitidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _salespersonidValue = default(string), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), double? exchangerate = default(double?), int? fiscalperiodtype = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), double? month1 = default(double?), double? month10 = default(double?), double? month10Base = default(double?), double? month11 = default(double?), double? month11Base = default(double?), double? month12 = default(double?), double? month12Base = default(double?), double? month1Base = default(double?), double? month2 = default(double?), double? month2Base = default(double?), double? month3 = default(double?), double? month3Base = default(double?), double? month4 = default(double?), double? month4Base = default(double?), double? month5 = default(double?), double? month5Base = default(double?), double? month6 = default(double?), double? month6Base = default(double?), double? month7 = default(double?), double? month7Base = default(double?), double? month8 = default(double?), double? month8Base = default(double?), double? month9 = default(double?), double? month9Base = default(double?), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), string userfiscalcalendarid = default(string), int? utcconversiontimezonecode = default(int?))
        {
            MonthlyFiscalCalendarAsyncOperations = monthlyFiscalCalendarAsyncOperations;
            MonthlyFiscalCalendarBulkDeleteFailures = monthlyFiscalCalendarBulkDeleteFailures;
            this._businessunitidValue = _businessunitidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._salespersonidValue = _salespersonidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Effectiveon = effectiveon;
            Exchangerate = exchangerate;
            Fiscalperiodtype = fiscalperiodtype;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Month1 = month1;
            Month10 = month10;
            Month10Base = month10Base;
            Month11 = month11;
            Month11Base = month11Base;
            Month12 = month12;
            Month12Base = month12Base;
            Month1Base = month1Base;
            Month2 = month2;
            Month2Base = month2Base;
            Month3 = month3;
            Month3Base = month3Base;
            Month4 = month4;
            Month4Base = month4Base;
            Month5 = month5;
            Month5Base = month5Base;
            Month6 = month6;
            Month6Base = month6Base;
            Month7 = month7;
            Month7Base = month7Base;
            Month8 = month8;
            Month8Base = month8Base;
            Month9 = month9;
            Month9Base = month9Base;
            Salespersonid = salespersonid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Transactioncurrencyid = transactioncurrencyid;
            Userfiscalcalendarid = userfiscalcalendarid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MonthlyFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MonthlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MonthlyFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MonthlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month1")]
        public double? Month1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month10")]
        public double? Month10 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month10_base")]
        public double? Month10Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month11")]
        public double? Month11 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month11_base")]
        public double? Month11Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month12")]
        public double? Month12 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month12_base")]
        public double? Month12Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month1_base")]
        public double? Month1Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month2")]
        public double? Month2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month2_base")]
        public double? Month2Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month3")]
        public double? Month3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month3_base")]
        public double? Month3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month4")]
        public double? Month4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month4_base")]
        public double? Month4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month5")]
        public double? Month5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month5_base")]
        public double? Month5Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month6")]
        public double? Month6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month6_base")]
        public double? Month6Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month7")]
        public double? Month7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month7_base")]
        public double? Month7Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month8")]
        public double? Month8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month8_base")]
        public double? Month8Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month9")]
        public double? Month9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month9_base")]
        public double? Month9Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

    }
}