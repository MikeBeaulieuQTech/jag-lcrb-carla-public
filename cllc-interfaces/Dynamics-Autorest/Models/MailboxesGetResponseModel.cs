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
    /// Collection of mailboxes
    /// </summary>
    public partial class MailboxesGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the MailboxesGetResponseModel class.
        /// </summary>
        public MailboxesGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MailboxesGetResponseModel class.
        /// </summary>
        public MailboxesGetResponseModel(IList<MicrosoftDynamicsCRMmailbox> value = default(IList<MicrosoftDynamicsCRMmailbox>))
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
        public IList<MicrosoftDynamicsCRMmailbox> Value { get; set; }

    }
}
