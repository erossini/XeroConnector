using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class PdfResponse.
    /// </summary>
    public class PdfResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PdfResponse"/> is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        public bool Success { get; set; }
        /// <summary>
        /// Gets or sets the file URL.
        /// </summary>
        /// <value>The file URL.</value>
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or sets the shared access expiry time.
        /// </summary>
        /// <value>The shared access expiry time.</value>
        public string ExpiryTime { get; set; }
    }
}
