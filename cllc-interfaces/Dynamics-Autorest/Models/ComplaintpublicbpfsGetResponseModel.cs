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
    /// Collection of adoxio_complaintpublicbpfs
    /// </summary>
    public partial class ComplaintpublicbpfsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComplaintpublicbpfsGetResponseModel class.
        /// </summary>
        public ComplaintpublicbpfsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComplaintpublicbpfsGetResponseModel class.
        /// </summary>
        public ComplaintpublicbpfsGetResponseModel(IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf> value = default(IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioComplaintpublicbpf> Value { get; set; }

    }
}
