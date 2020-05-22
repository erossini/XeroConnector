using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Settings
{
    /// <summary>
    /// Class ExternalAccountingSettings.
    /// </summary>
    public class ExternalAccountingSettings
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        public string ClientId { get; set; }
        /// <summary>
        /// Gets or sets the client secret.
        /// </summary>
        /// <value>The client secret.</value>
        public string ClientSecret { get; set; }
        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>The refresh token.</value>
        public string RefreshToken { get; set; }
        /// <summary>
        /// Gets or sets the tenand identifier.
        /// </summary>
        /// <value>The tenand identifier.</value>
        public string TenandId { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the last token update.
        /// </summary>
        /// <value>The last token update.</value>
        public string LastTokenUpdate { get; set; }
    }
}