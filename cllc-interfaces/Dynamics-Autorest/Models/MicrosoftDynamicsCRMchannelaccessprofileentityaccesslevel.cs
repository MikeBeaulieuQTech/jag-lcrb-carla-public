// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMchannelaccessprofileentityaccesslevel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMchannelaccessprofileentityaccesslevel class.
        /// </summary>
        public MicrosoftDynamicsCRMchannelaccessprofileentityaccesslevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMchannelaccessprofileentityaccesslevel class.
        /// </summary>
        public MicrosoftDynamicsCRMchannelaccessprofileentityaccesslevel(string channelaccessprofileentityaccesslevelid = default(string), string channelaccessprofileentityaccesslevelidunique = default(string), string channelaccessprofileid = default(string), int? componentstate = default(int?), int? entityaccessleveldepthmask = default(int?), string entityaccesslevelid = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string solutionid = default(string), object versionnumber = default(object))
        {
            Channelaccessprofileentityaccesslevelid = channelaccessprofileentityaccesslevelid;
            Channelaccessprofileentityaccesslevelidunique = channelaccessprofileentityaccesslevelidunique;
            Channelaccessprofileid = channelaccessprofileid;
            Componentstate = componentstate;
            Entityaccessleveldepthmask = entityaccessleveldepthmask;
            Entityaccesslevelid = entityaccesslevelid;
            Ismanaged = ismanaged;
            Overwritetime = overwritetime;
            Solutionid = solutionid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channelaccessprofileentityaccesslevelid")]
        public string Channelaccessprofileentityaccesslevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channelaccessprofileentityaccesslevelidunique")]
        public string Channelaccessprofileentityaccesslevelidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channelaccessprofileid")]
        public string Channelaccessprofileid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityaccessleveldepthmask")]
        public int? Entityaccessleveldepthmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityaccesslevelid")]
        public string Entityaccesslevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}