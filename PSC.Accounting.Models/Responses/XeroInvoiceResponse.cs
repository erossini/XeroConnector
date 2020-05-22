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
    /// Implements the <see cref="PSC.Accounting.Models.Responses.XeroBaseResponse" />
    /// </summary>
    /// <seealso cref="PSC.Accounting.Models.Responses.XeroBaseResponse" />
    public class XeroInvoiceResponse : XeroBaseResponse
    {
        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        /// <value>The invoices.</value>
        [JsonProperty("Invoices")]
        public IList<Invoice> Invoices { get; set; }
    }
}
