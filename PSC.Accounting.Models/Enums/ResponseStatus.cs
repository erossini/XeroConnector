using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PSC.Common.Enums
{
    /// <summary>
    /// Status
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// Success
        /// </summary>
        [Description("Success")]
        Success,

        /// <summary>
        /// Failed
        /// </summary>
        [Description("Failed")]
        Failed
    }
}