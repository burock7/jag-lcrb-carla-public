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
    /// Collection of adoxio_tiedhouseconnection
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_tiedhouseconnectionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioTiedhouseconnectionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTiedhouseconnectionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTiedhouseconnectionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTiedhouseconnectionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTiedhouseconnectionCollection(IList<MicrosoftDynamicsCRMadoxioTiedhouseconnection> value = default(IList<MicrosoftDynamicsCRMadoxioTiedhouseconnection>))
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
        public IList<MicrosoftDynamicsCRMadoxioTiedhouseconnection> Value { get; set; }

    }
}
