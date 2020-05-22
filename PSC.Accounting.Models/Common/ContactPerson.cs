using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class ContactPerson.
    /// </summary>
    public class ContactPerson
    {
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
        /// Gets or sets a value indicating whether [include in emails].
        /// </summary>
        /// <value><c>true</c> if [include in emails]; otherwise, <c>false</c>.</value>
        [JsonProperty("IncludeInEmails")]
        public bool IncludeInEmails { get; set; }
    }
}
