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
    /// AttributeMapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMAttributeMapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeMapping class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeMapping class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeMapping(string attributeMappingId = default(string), string mappingName = default(string), string attributeCrmName = default(string), string attributeExchangeName = default(string), int? syncDirection = default(int?), int? defaultSyncDirection = default(int?), int? allowedSyncDirection = default(int?), bool? isComputed = default(bool?), int? entityTypeCode = default(int?), IList<string> computedProperties = default(IList<string>), string attributeCrmDisplayName = default(string), string attributeExchangeDisplayName = default(string))
        {
            AttributeMappingId = attributeMappingId;
            MappingName = mappingName;
            AttributeCrmName = attributeCrmName;
            AttributeExchangeName = attributeExchangeName;
            SyncDirection = syncDirection;
            DefaultSyncDirection = defaultSyncDirection;
            AllowedSyncDirection = allowedSyncDirection;
            IsComputed = isComputed;
            EntityTypeCode = entityTypeCode;
            ComputedProperties = computedProperties;
            AttributeCrmDisplayName = attributeCrmDisplayName;
            AttributeExchangeDisplayName = attributeExchangeDisplayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeMappingId")]
        public string AttributeMappingId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MappingName")]
        public string MappingName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeCrmName")]
        public string AttributeCrmName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeExchangeName")]
        public string AttributeExchangeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SyncDirection")]
        public int? SyncDirection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultSyncDirection")]
        public int? DefaultSyncDirection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowedSyncDirection")]
        public int? AllowedSyncDirection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsComputed")]
        public bool? IsComputed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityTypeCode")]
        public int? EntityTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ComputedProperties")]
        public IList<string> ComputedProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeCrmDisplayName")]
        public string AttributeCrmDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeExchangeDisplayName")]
        public string AttributeExchangeDisplayName { get; set; }

    }
}
