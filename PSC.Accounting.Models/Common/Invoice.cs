using Newtonsoft.Json;
using PSC.Accounting.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class Invoice.
    /// </summary>
    public class Invoice
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonIgnore]
        public InvoiceType InvoiceType { 
            set
            {
                Type = (typeof(InvoiceType)).GetEnumName(value);
            }
        }

        /// <summary>
        /// Gets or sets the invoice identifier.
        /// </summary>
        /// <value>The invoice identifier.</value>
        [JsonProperty("InvoiceID")]
        public string InvoiceID { get; set; }

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>The invoice number.</value>
        [JsonProperty("InvoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>The reference.</value>
        [JsonProperty("Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the payments.
        /// </summary>
        /// <value>The payments.</value>
        [JsonProperty("Payments")]
        public IList<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or sets the credit notes.
        /// </summary>
        /// <value>The credit notes.</value>
        [JsonProperty("CreditNotes")]
        public IList<CreditNote> CreditNotes { get; set; }

        /// <summary>
        /// Gets or sets the prepayments.
        /// </summary>
        /// <value>The prepayments.</value>
        [JsonProperty("Prepayments")]
        public IList<object> Prepayments { get; set; }

        /// <summary>
        /// Gets or sets the overpayments.
        /// </summary>
        /// <value>The overpayments.</value>
        [JsonProperty("Overpayments")]
        public IList<object> Overpayments { get; set; }

        /// <summary>
        /// Gets or sets the amount due.
        /// </summary>
        /// <value>The amount due.</value>
        [JsonProperty("AmountDue")]
        public double AmountDue { get; set; }

        /// <summary>
        /// Gets or sets the amount paid.
        /// </summary>
        /// <value>The amount paid.</value>
        [JsonProperty("AmountPaid")]
        public double AmountPaid { get; set; }

        /// <summary>
        /// Gets or sets the amount credited.
        /// </summary>
        /// <value>The amount credited.</value>
        [JsonProperty("AmountCredited")]
        public double AmountCredited { get; set; }

        /// <summary>
        /// Gets or sets the currency rate.
        /// </summary>
        /// <value>The currency rate.</value>
        [JsonProperty("CurrencyRate")]
        public double CurrencyRate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is discounted.
        /// </summary>
        /// <value><c>true</c> if this instance is discounted; otherwise, <c>false</c>.</value>
        [JsonProperty("IsDiscounted")]
        public bool IsDiscounted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has attachments.
        /// </summary>
        /// <value><c>true</c> if this instance has attachments; otherwise, <c>false</c>.</value>
        [JsonProperty("HasAttachments")]
        public bool HasAttachments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has errors.
        /// </summary>
        /// <value><c>true</c> if this instance has errors; otherwise, <c>false</c>.</value>
        [JsonProperty("HasErrors")]
        public bool HasErrors { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>The contact.</value>
        [JsonProperty("Contact")]
        public Contact Contact { get; set; }

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
        /// Gets or sets the due date string.
        /// </summary>
        /// <value>The due date string.</value>
        [JsonProperty("DueDateString")]
        public DateTime DueDateString { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>The due date.</value>
        [JsonProperty("DueDate")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the branding theme identifier.
        /// </summary>
        /// <value>The branding theme identifier.</value>
        [JsonProperty("BrandingThemeID")]
        public string BrandingThemeID { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the line amount types.
        /// </summary>
        /// <value>The line amount types.</value>
        [JsonProperty("LineAmountTypes")]
        public string LineAmountTypes { get; set; }

        /// <summary>
        /// Gets or sets the line items.
        /// </summary>
        /// <value>The line items.</value>
        [JsonProperty("LineItems")]
        public IList<LineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets the sub total.
        /// </summary>
        /// <value>The sub total.</value>
        [JsonProperty("SubTotal")]
        public double SubTotal { get; set; }

        /// <summary>
        /// Gets or sets the total tax.
        /// </summary>
        /// <value>The total tax.</value>
        [JsonProperty("TotalTax")]
        public double TotalTax { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        [JsonProperty("Total")]
        public double Total { get; set; }

        /// <summary>
        /// Gets or sets the updated date UTC.
        /// </summary>
        /// <value>The updated date UTC.</value>
        [JsonProperty("UpdatedDateUTC")]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the fully paid on date.
        /// </summary>
        /// <value>The fully paid on date.</value>
        [JsonProperty("FullyPaidOnDate")]
        public DateTime? FullyPaidOnDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [sent to contact].
        /// </summary>
        /// <value><c>null</c> if [sent to contact] contains no value, <c>true</c> if [sent to contact]; otherwise, <c>false</c>.</value>
        [JsonProperty("SentToContact")]
        public bool? SentToContact { get; set; }
    }
}
