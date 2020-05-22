using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Common
{
    /// <summary>
    /// Class Organization.
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the type of the tenant.
        /// </summary>
        /// <value>The type of the tenant.</value>
        [JsonProperty("tenantType")]
        public string TenantType { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant.
        /// </summary>
        /// <value>The name of the tenant.</value>
        [JsonProperty("tenantName")]
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or sets the created date UTC.
        /// </summary>
        /// <value>The created date UTC.</value>
        [JsonProperty("createdDateUtc")]
        public DateTime CreatedDateUtc { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the updated date UTC.
        /// </summary>
        /// <value>The updated date UTC.</value>
        [JsonProperty("updatedDateUtc")]
        public DateTime? UpdatedDateUtc { get; set; }
    }
}
