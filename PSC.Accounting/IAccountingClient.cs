using PSC.Accounting.Models.Requests;
using PSC.Accounting.Models.Responses;

namespace PSC.Accounting
{
    /// <summary>
    /// Interface IAccountingClient
    /// </summary>
    public interface IAccountingClient
    {
        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <param name="clientRequest">The client request.</param>
        /// <returns>CreateClientResponse.</returns>
        CreateClientResponse CreateClient(CreateClientRequest clientRequest);
        /// <summary>
        /// Creates the invoice.
        /// </summary>
        /// <param name="invoiceRequest">The invoice request.</param>
        /// <returns>CreateInvoiceResponse.</returns>
        CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest invoiceRequest);
        /// <summary>
        /// Gets the invoices.
        /// </summary>
        /// <param name="invoiceId">The invoice identifier.</param>
        /// <param name="asPDF">if set to <c>true</c> [as PDF].</param>
        /// <returns>InvoiceResponse.</returns>
        InvoiceResponse GetInvoices(string invoiceId = "", bool asPDF = false);
        /// <summary>
        /// Gets the organizations.
        /// </summary>
        /// <returns>OrganizationResponse.</returns>
        OrganizationResponse GetOrganizations();
        /// <summary>
        /// Gets the refresh token.
        /// </summary>
        /// <returns>RefreshTokenResponse.</returns>
        RefreshTokenResponse GetRefreshToken();
        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <returns>System.String.</returns>
        string GetToken();
    }
}