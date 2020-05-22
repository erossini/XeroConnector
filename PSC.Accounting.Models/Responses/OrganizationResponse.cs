using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using PSC.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSC.Accounting.Models.Responses
{
    /// <summary>
    /// Class OrganizationResponse.
    /// </summary>
    public class OrganizationResponse : BaseResponses
    {
        /// <summary>
        /// Gets or sets the organizations.
        /// </summary>
        /// <value>The organizations.</value>
        public IList<Organization> Organizations { get; set; }
    }
}
