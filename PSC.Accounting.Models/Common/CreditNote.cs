using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class CreditNote.
    /// </summary>
    public class CreditNote
    {

        /// <summary>
        /// Gets or sets the credit note identifier.
        /// </summary>
        /// <value>The credit note identifier.</value>
        [JsonProperty("CreditNoteID")]
        public string CreditNoteID { get; set; }

        /// <summary>
        /// Gets or sets the credit note number.
        /// </summary>
        /// <value>The credit note number.</value>
        [JsonProperty("CreditNoteNumber")]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("ID")]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has errors.
        /// </summary>
        /// <value><c>true</c> if this instance has errors; otherwise, <c>false</c>.</value>
        [JsonProperty("HasErrors")]
        public bool HasErrors { get; set; }

        /// <summary>
        /// Gets or sets the applied amount.
        /// </summary>
        /// <value>The applied amount.</value>
        [JsonProperty("AppliedAmount")]
        public double AppliedAmount { get; set; }

        /// <summary>
        /// Gets or sets the date string.
        /// </summary>
        /// <value>The date string.</value>
        [JsonProperty("DateString")]
        public DateTime DateString { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the line items.
        /// </summary>
        /// <value>The line items.</value>
        [JsonProperty("LineItems")]
        public IList<object> LineItems { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [JsonProperty("Total")]
        public double Total { get; set; }
    }
}
