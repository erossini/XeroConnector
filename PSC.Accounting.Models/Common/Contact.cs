using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class Contact.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        [JsonProperty("ContactID")]
        public string ContactID { get; set; }

        /// <summary>
        /// Gets or sets the contact status.
        /// </summary>
        /// <value>The contact status.</value>
        [JsonProperty("ContactStatus")]
        public string ContactStatus { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        [JsonProperty("EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the bank account details.
        /// </summary>
        /// <value>The bank account details.</value>
        [JsonProperty("BankAccountDetails")]
        public string BankAccountDetails { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        [JsonProperty("Addresses")]
        public IList<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the phones.
        /// </summary>
        /// <value>The phones.</value>
        [JsonProperty("Phones")]
        public IList<Phone> Phones { get; set; }

        /// <summary>
        /// Gets or sets the updated date UTC.
        /// </summary>
        /// <value>The updated date UTC.</value>
        [JsonProperty("UpdatedDateUTC")]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// Gets or sets the contact groups.
        /// </summary>
        /// <value>The contact groups.</value>
        [JsonProperty("ContactGroups")]
        public IList<object> ContactGroups { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is supplier.
        /// </summary>
        /// <value><c>true</c> if this instance is supplier; otherwise, <c>false</c>.</value>
        [JsonProperty("IsSupplier")]
        public bool IsSupplier { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is customer.
        /// </summary>
        /// <value><c>true</c> if this instance is customer; otherwise, <c>false</c>.</value>
        [JsonProperty("IsCustomer")]
        public bool IsCustomer { get; set; }

        /// <summary>
        /// Gets or sets the sales tracking categories.
        /// </summary>
        /// <value>The sales tracking categories.</value>
        [JsonProperty("SalesTrackingCategories")]
        public IList<object> SalesTrackingCategories { get; set; }

        /// <summary>
        /// Gets or sets the purchases tracking categories.
        /// </summary>
        /// <value>The purchases tracking categories.</value>
        [JsonProperty("PurchasesTrackingCategories")]
        public IList<object> PurchasesTrackingCategories { get; set; }

        /// <summary>
        /// Gets or sets the contact persons.
        /// </summary>
        /// <value>The contact persons.</value>
        [JsonProperty("ContactPersons")]
        public IList<ContactPerson> ContactPersons { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has validation errors.
        /// </summary>
        /// <value><c>true</c> if this instance has validation errors; otherwise, <c>false</c>.</value>
        [JsonProperty("HasValidationErrors")]
        public bool HasValidationErrors { get; set; }
    }
}
