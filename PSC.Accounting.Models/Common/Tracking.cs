using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class Tracking.
    /// </summary>
    public class Tracking
    {
        /// <summary>
        /// Gets or sets the tracking category identifier.
        /// </summary>
        /// <value>The tracking category identifier.</value>
        [JsonProperty("TrackingCategoryID")]
        public string TrackingCategoryID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the option.
        /// </summary>
        /// <value>The option.</value>
        [JsonProperty("Option")]
        public string Option { get; set; }
    }
}
