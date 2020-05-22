using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using PSC.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class CreateInvoiceResponse.
    /// Implements the <see cref="Pip.Common.Models.BaseResponses" />
    /// </summary>
    /// <seealso cref="Pip.Common.Models.BaseResponses" />
    public class CreateInvoiceResponse : BaseResponses
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
        /// Response message
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
