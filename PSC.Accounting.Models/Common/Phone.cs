using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class Phone.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Gets or sets the type of the phone.
        /// </summary>
        /// <value>The type of the phone.</value>
        [JsonProperty("PhoneType")]
        public string PhoneType { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the phone area code.
        /// </summary>
        /// <value>The phone area code.</value>
        [JsonProperty("PhoneAreaCode")]
        public string PhoneAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the phone country code.
        /// </summary>
        /// <value>The phone country code.</value>
        [JsonProperty("PhoneCountryCode")]
        public string PhoneCountryCode { get; set; }
    }
}
