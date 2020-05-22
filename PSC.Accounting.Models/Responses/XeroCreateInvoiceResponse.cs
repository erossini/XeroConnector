using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class XeroCreateInvoiceResponse.
    /// Implements the <see cref="PSC.Accounting.Models.Responses.XeroBaseResponse" />
    /// </summary>
    /// <seealso cref="PSC.Accounting.Models.Responses.XeroBaseResponse" />
    public class XeroCreateInvoiceResponse : XeroBaseResponse
    {
        /// <summary>
        /// Gets or sets the error number.
        /// </summary>
        /// <value>The error number.</value>
        [JsonProperty("ErrorNumber")]
        public int ErrorNumber { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the elements.
        /// </summary>
        /// <value>The elements.</value>
        [JsonProperty("Elements")]
        public IList<Element> Elements { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        /// <value>The invoices.</value>
        [JsonProperty("Invoices")]
        public IList<Invoice> Invoices { get; set; }
    }
}
