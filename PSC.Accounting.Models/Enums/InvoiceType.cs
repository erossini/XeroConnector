using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PSC.Accounting.Models.Enums
{
    /// <summary>
    /// Enum InvoiceType
    /// </summary>
    public enum InvoiceType
    {
        /// <summary>
        /// A bill - commonly known as a Accounts Payable or supplier invoice
        /// </summary>
        [Description("ACCPAY")]
        AccountsPayable,

        /// <summary>
        /// A sales invoice - commonly known as an Accounts Receivable or customer invoice
        /// </summary>
        [Description("ACCREC")]
        AccountsReceivable
    }
}
