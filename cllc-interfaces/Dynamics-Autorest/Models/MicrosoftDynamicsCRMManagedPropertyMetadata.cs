// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMManagedPropertyMetadata : MicrosoftDynamicsCRMMetadataBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMManagedPropertyMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMManagedPropertyMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMManagedPropertyMetadata class.
        /// </summary>
        /// <param name="evaluationPriority">Possible values include: 'None',
        /// 'Low', 'Normal', 'High', 'Essential'</param>
        /// <param name="managedPropertyType">Possible values include:
        /// 'Operation', 'Attribute', 'CustomEvaluator', 'Custom'</param>
        /// <param name="operation">Possible values include: 'None', 'Create',
        /// 'Update', 'CreateUpdate', 'Delete', 'UpdateDelete', 'All'</param>
        public MicrosoftDynamicsCRMManagedPropertyMetadata(bool? hasChanged = default(bool?), string metadataId = default(string), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), string enablesAttributeName = default(string), string enablesEntityName = default(string), int? errorCode = default(int?), string evaluationPriority = default(string), string introducedVersion = default(string), bool? isGlobalForOperation = default(bool?), bool? isPrivate = default(bool?), string logicalName = default(string), string managedPropertyType = default(string), string operation = default(string))
            : base(hasChanged, metadataId)
        {
            Description = description;
            DisplayName = displayName;
            EnablesAttributeName = enablesAttributeName;
            EnablesEntityName = enablesEntityName;
            ErrorCode = errorCode;
            EvaluationPriority = evaluationPriority;
            IntroducedVersion = introducedVersion;
            IsGlobalForOperation = isGlobalForOperation;
            IsPrivate = isPrivate;
            LogicalName = logicalName;
            ManagedPropertyType = managedPropertyType;
            Operation = operation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public MicrosoftDynamicsCRMLabel Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public MicrosoftDynamicsCRMLabel DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnablesAttributeName")]
        public string EnablesAttributeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnablesEntityName")]
        public string EnablesEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Low', 'Normal',
        /// 'High', 'Essential'
        /// </summary>
        [JsonProperty(PropertyName = "EvaluationPriority")]
        public string EvaluationPriority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsGlobalForOperation")]
        public bool? IsGlobalForOperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrivate")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Operation', 'Attribute',
        /// 'CustomEvaluator', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "ManagedPropertyType")]
        public string ManagedPropertyType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Create', 'Update',
        /// 'CreateUpdate', 'Delete', 'UpdateDelete', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "Operation")]
        public string Operation { get; set; }

    }
}
