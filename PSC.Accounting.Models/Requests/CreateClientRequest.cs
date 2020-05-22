using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Requests
{
    /// <summary>
    /// Class CreateClientRequest.
    /// </summary>
    public class CreateClientRequest
    {
        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>The contacts.</value>
        [JsonProperty("Contacts")]
        public IList<Contact> Contacts { get; set; }
    }
}
