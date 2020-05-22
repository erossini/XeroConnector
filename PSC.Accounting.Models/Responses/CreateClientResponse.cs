using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using PSC.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class CreateClientResponse.
    /// </summary>
    public class CreateClientResponse : BaseResponses
    {
        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>The contacts.</value>
        [JsonProperty("Contacts")]
        public IList<Contact> Contacts { get; set; }
    }
}
