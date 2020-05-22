using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Requests
{
    public class ContactRequest
    {
        [JsonProperty("Contacts")]
        public IList<Contact> Contacts { get; set; }
    }
}
