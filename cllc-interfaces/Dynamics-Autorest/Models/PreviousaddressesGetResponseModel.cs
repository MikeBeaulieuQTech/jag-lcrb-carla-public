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
    /// Collection of adoxio_previousaddresses
    /// </summary>
    public partial class PreviousaddressesGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the PreviousaddressesGetResponseModel
        /// class.
        /// </summary>
        public PreviousaddressesGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PreviousaddressesGetResponseModel
        /// class.
        /// </summary>
        public PreviousaddressesGetResponseModel(IList<MicrosoftDynamicsCRMadoxioPreviousaddress> value = default(IList<MicrosoftDynamicsCRMadoxioPreviousaddress>))
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
        public IList<MicrosoftDynamicsCRMadoxioPreviousaddress> Value { get; set; }

    }
}
