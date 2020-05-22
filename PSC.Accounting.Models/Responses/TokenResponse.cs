using Newtonsoft.Json;
using PSC.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class TokenResponse.
    /// Implements the <see cref="PiP.Common.Models.BaseResponses" />
    /// </summary>
    /// <seealso cref="PiP.Common.Models.BaseResponses" />
    public class TokenResponse : BaseResponses
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>The refresh token.</value>
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the last token update.
        /// </summary>
        /// <value>The last token update.</value>
        [JsonProperty("lastTokenUpdate")]
        public string LastTokenUpdate { get; set; }
    }
}
