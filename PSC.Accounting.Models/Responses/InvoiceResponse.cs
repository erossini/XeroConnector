using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using PSC.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class InvoiceResponse.
    /// </summary>
    public class InvoiceResponse : BaseResponses
    {
        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        /// <value>The invoices.</value>
        [JsonProperty("Invoices")]
        public IList<Invoice> Invoices { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>The content.</value>
        [JsonProperty("Content")]
        public byte[] Content { get; set; }
    }
}
