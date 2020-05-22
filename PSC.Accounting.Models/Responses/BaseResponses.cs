using PSC.Common.Enums;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PSC.Common.Models
{
    /// <summary>
    /// Class BaseResponses.
    /// </summary>
    public class BaseResponses
    {
        /// <summary>
        /// Status of response from payment provider
        /// </summary>
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// Response message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Http status code
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// Is response a success
        /// </summary>
        public bool IsSuccess => Status == ResponseStatus.Success;
    }
}
