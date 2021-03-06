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
    /// Collection of phonecalls
    /// </summary>
    public partial class PhonecallsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the PhonecallsGetResponseModel class.
        /// </summary>
        public PhonecallsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhonecallsGetResponseModel class.
        /// </summary>
        public PhonecallsGetResponseModel(IList<MicrosoftDynamicsCRMphonecall> value = default(IList<MicrosoftDynamicsCRMphonecall>))
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
        public IList<MicrosoftDynamicsCRMphonecall> Value { get; set; }

    }
}
