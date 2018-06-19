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
    /// RetrievePrincipalAttributePrivilegesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrievePrincipalAttributePrivilegesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrievePrincipalAttributePrivilegesResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrievePrincipalAttributePrivilegesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrievePrincipalAttributePrivilegesResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrievePrincipalAttributePrivilegesResponse(IList<MicrosoftDynamicsCRMAttributePrivilege> attributePrivileges = default(IList<MicrosoftDynamicsCRMAttributePrivilege>))
        {
            AttributePrivileges = attributePrivileges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributePrivileges")]
        public IList<MicrosoftDynamicsCRMAttributePrivilege> AttributePrivileges { get; set; }

    }
}
