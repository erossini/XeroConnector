using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class Payment.
    /// </summary>
    public class Payment
    {

        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>The payment identifier.</value>
        [JsonProperty("PaymentID")]
        public string PaymentID { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>The reference.</value>
        [JsonProperty("Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has account.
        /// </summary>
        /// <value><c>true</c> if this instance has account; otherwise, <c>false</c>.</value>
        [JsonProperty("HasAccount")]
        public bool HasAccount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has validation errors.
        /// </summary>
        /// <value><c>true</c> if this instance has validation errors; otherwise, <c>false</c>.</value>
        [JsonProperty("HasValidationErrors")]
        public bool HasValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the batch payment identifier.
        /// </summary>
        /// <value>The batch payment identifier.</value>
        [JsonProperty("BatchPaymentID")]
        public string BatchPaymentID { get; set; }

        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        /// <value>The currency rate.</value>
        [JsonProperty("CurrencyRate")]
        public double? CurrencyRate { get; set; }
    }
}
