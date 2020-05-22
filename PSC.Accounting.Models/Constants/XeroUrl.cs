using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Constants
{
    /// <summary>
    /// Class XeroUrl.
    /// </summary>
    public static class XeroUrl
    {
        /// <summary>
        /// The connection to have the list of organizations
        /// </summary>
        public const string Connection = "/connections";
        /// <summary>
        /// Endpoint for contacts
        /// </summary>
        public const string Contacts = "/api.xro/2.0/Contacts";
        /// <summary>
        /// The endpoint for invoices
        /// </summary>
        public const string Invoices = "/api.xro/2.0/Invoices";

        /// <summary>
        /// The identity server authorize
        /// </summary>
        public const string IdentityServerAuthorize = "https://login.xero.com/identity/connect/authorize";
        /// <summary>
        /// The identity server refresh token
        /// </summary>
        public const string IdentityServerRefreshToken = "https://identity.xero.com/connect/token";
    }
}
