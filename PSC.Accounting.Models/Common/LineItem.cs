using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class LineItem.
    /// </summary>
    public class LineItem
    {
        /// <summary>
        /// Gets or sets the item code.
        /// </summary>
        /// <value>The item code.</value>
        [JsonProperty("ItemCode")]
        public string ItemCode { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("Quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit amount.
        /// </summary>
        /// <value>The unit amount.</value>
        [JsonProperty("UnitAmount")]
        public string UnitAmount { get; set; }

        /// <summary>
        /// Gets or sets the type of the tax.
        /// </summary>
        /// <value>The type of the tax.</value>
        [JsonProperty("TaxType")]
        public string TaxType { get; set; }

        /// <summary>
        /// Gets or sets the tax amount.
        /// </summary>
        /// <value>The tax amount.</value>
        [JsonProperty("TaxAmount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the line amount.
        /// </summary>
        /// <value>The line amount.</value>
        [JsonProperty("LineAmount")]
        public string LineAmount { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>The account code.</value>
        [JsonProperty("AccountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the tracking.
        /// </summary>
        /// <value>The tracking.</value>
        [JsonProperty("Tracking")]
        public IList<Tracking> Tracking { get; set; }

        /// <summary>
        /// Gets or sets the line item identifier.
        /// </summary>
        /// <value>The line item identifier.</value>
        [JsonProperty("LineItemID")]
        public string LineItemID { get; set; }

        /// <summary>
        /// Gets or sets the validation errors.
        /// </summary>
        /// <value>The validation errors.</value>
        [JsonProperty("ValidationErrors")]
        public IList<ValidationError> ValidationErrors { get; set; }
    }
}
