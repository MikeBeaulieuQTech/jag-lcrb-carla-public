// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DeleteAuditDataResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMDeleteAuditDataResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDeleteAuditDataResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMDeleteAuditDataResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDeleteAuditDataResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMDeleteAuditDataResponse(int? partitionsDeleted = default(int?))
        {
            PartitionsDeleted = partitionsDeleted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PartitionsDeleted")]
        public int? PartitionsDeleted { get; set; }

    }
}