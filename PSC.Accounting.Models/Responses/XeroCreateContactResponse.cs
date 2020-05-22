using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class XeroCreateContact.
    /// Implements the <see cref="PSC.Accounting.Models.Responses.XeroBaseResponse" />
    /// </summary>
    /// <seealso cref="PSC.Accounting.Models.Responses.XeroBaseResponse" />
    public class XeroCreateContactResponse : XeroBaseResponse
    {
        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>The contacts.</value>
        [JsonProperty("Contacts")]
        public IList<Contact> Contacts { get; set; }
    }
}
