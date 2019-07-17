// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Spice.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Associate
    {
        /// <summary>
        /// Initializes a new instance of the Associate class.
        /// </summary>
        public Associate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Associate class.
        /// </summary>
        public Associate(string spdJobId = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string))
        {
            SpdJobId = spdJobId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spdJobId")]
        public string SpdJobId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

    }
}
