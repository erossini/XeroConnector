using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class ContactResponse.
    /// </summary>
    public class ContactResponse
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the name of the provider.
        /// </summary>
        /// <value>The name of the provider.</value>
        [JsonProperty("ProviderName")]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets the date time UTC.
        /// </summary>
        /// <value>The date time UTC.</value>
        [JsonProperty("DateTimeUTC")]
        public DateTime DateTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>The contacts.</value>
        [JsonProperty("Contacts")]
        public IList<Contact> Contacts { get; set; }
    }
}
