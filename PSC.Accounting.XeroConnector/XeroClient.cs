using IdentityModel.Client;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PSC.Accounting.Models.Common;
using PSC.Accounting.Models.Constants;
using PSC.Accounting.Models.Requests;
using PSC.Accounting.Models.Responses;
using PSC.Accounting.Models.Settings;
using PSC.Common.Extensions;
using RestSharp;
using System;
using System.Collections.Generic;

namespace PSC.Accounting.XeroConnector
{
    /// <summary>
    /// Class XeroConnector.
    /// </summary>
    public class XeroClient : IAccountingClient
    {
        private ExternalAccountingSettings _settings;
        private RestClient _client;
        private ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="XeroClient"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public XeroClient(ExternalAccountingSettings settings)
        {
            _settings = settings;
        }

        public XeroClient(ExternalAccountingSettings settings, ILogger logger)
        {
            _settings = settings;
            _log = logger;
            _log?.LogInformation("XeroClient is initializated");
        }

        #region Contacts
        public CreateClientResponse CreateClient(CreateClientRequest clientRequest)
        {
            CreateClientResponse rtn = new CreateClientResponse();

            _client = new RestClient($"{_settings.Url}{XeroUrl.Contacts}");
            _client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("xero-tenant-id", _settings.TenandId);
            request.AddHeader("Authorization", "Bearer " + _settings.AccessToken);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,application/json", JsonConvert.SerializeObject(clientRequest), ParameterType.RequestBody);
            var response = _client.Execute<XeroCreateContactResponse>(request);

            rtn.HttpStatusCode = response.StatusCode;
            if (rtn.HttpStatusCode == System.Net.HttpStatusCode.OK)
                rtn.HttpStatusCode = System.Net.HttpStatusCode.Created;

            rtn.Status = response.StatusCode == System.Net.HttpStatusCode.Created ? PSC.Common.Enums.ResponseStatus.Success : PSC.Common.Enums.ResponseStatus.Failed;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rtn.Contacts = response.Data.Contacts;
            }
            else
            {
                rtn.Message = response.Content;
            }

            return rtn;
        }
        #endregion
        #region Organizations
        /// <summary>
        /// Gets the organizations.
        /// </summary>
        /// <returns>OrganizationResponse.</returns>
        public OrganizationResponse GetOrganizations()
        {
            OrganizationResponse rtn = new OrganizationResponse();

            _client = new RestClient($"{_settings.Url}{XeroUrl.Connection}");
            _client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + _settings.AccessToken);
            var response = _client.Execute<IList<Organization>>(request);

            rtn.HttpStatusCode = response.StatusCode;
            rtn.Status = (int)response.StatusCode == 200 ? PSC.Common.Enums.ResponseStatus.Success : PSC.Common.Enums.ResponseStatus.Failed;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rtn.Organizations = response.Data;
            }

            return rtn;
        }
        #endregion
        #region Invoices
        public CreateInvoiceResponse CreateInvoice(CreateInvoiceRequest invoiceRequest)
        {
            CreateInvoiceResponse rtn = new CreateInvoiceResponse();

            _client = new RestClient($"{_settings.Url}{XeroUrl.Invoices}");
            _client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("xero-tenant-id", _settings.TenandId);
            request.AddHeader("Authorization", "Bearer " + _settings.AccessToken);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,application/json", JsonConvert.SerializeObject(invoiceRequest), ParameterType.RequestBody);
            var response = _client.Execute<XeroCreateInvoiceResponse>(request);

            rtn.HttpStatusCode = response.StatusCode;
            if (rtn.HttpStatusCode == System.Net.HttpStatusCode.OK)
                rtn.HttpStatusCode = System.Net.HttpStatusCode.Created;

            rtn.Status = response.StatusCode == System.Net.HttpStatusCode.Created ? PSC.Common.Enums.ResponseStatus.Success : PSC.Common.Enums.ResponseStatus.Failed;

            var data = response.Data;
            rtn.ErrorNumber = data.ErrorNumber;
            rtn.Type = data?.Type;
            rtn.Message = data?.Message;
            rtn.Elements = data?.Elements;
            rtn.Invoices = data?.Invoices;

            return rtn;
        }

        /// <summary>
        /// Gets the invoices.
        /// </summary>
        /// <returns>InvoiceResponse.</returns>
        public InvoiceResponse GetInvoices(string invoiceId = "", bool asPDF = false)
        {
            InvoiceResponse rtn = new InvoiceResponse();

            _log?.LogInformation("XeroClient: GetInvoices");

            string query = "";
            if (!string.IsNullOrEmpty(invoiceId))
            {
                query = "/" + invoiceId;
            }

            _client = new RestClient($"{_settings.Url}{XeroUrl.Invoices}" + query);
            _client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + _settings.AccessToken);
            request.AddHeader("xero-tenant-id", _settings.TenandId);
            if (!string.IsNullOrEmpty(invoiceId) && asPDF)
                request.AddHeader("Accept", "application/pdf");

            _log?.LogInformation("XeroClient: GetInvoices: Send request");
            var response = _client.Execute<XeroInvoiceResponse>(request);
            _log?.LogInformation("XeroClient: GetInvoices: Response StatusCode " + response.StatusCode);

            rtn.HttpStatusCode = response.StatusCode;
            rtn.Status = (int)response.StatusCode == 200 ? PSC.Common.Enums.ResponseStatus.Success : PSC.Common.Enums.ResponseStatus.Failed;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rtn.Invoices = response.Data?.Invoices;

                if (response.Content.Length > 0 && asPDF)
                    rtn.Content = response.RawBytes;
            }

            return rtn;
        }
        #endregion
        #region Token
        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetToken()
        {
            var xeroAuthorizeUri = new RequestUrl(XeroUrl.IdentityServerAuthorize);
            var url = xeroAuthorizeUri.CreateAuthorizeUrl(
             clientId: _settings.ClientId,
             responseType: "code", //hardcoded authorisation code for now.
             redirectUri: "https://localhost:5001/oauth",
             state: "",
             scope: "openid profile email files accounting.transactions accounting.transactions.read accounting.reports.read accounting.journals.read accounting.settings accounting.settings.read accounting.contacts accounting.contacts.read accounting.attachments accounting.attachments.read offline_access"
            );

            return url;
        }

        /// <summary>
        /// Gets the refresh token.
        /// </summary>
        /// <returns>RefreshTokenResponse.</returns>
        public RefreshTokenResponse GetRefreshToken()
        {
            _log?.LogInformation("XeroClient: GetRefreshToken");
            RefreshTokenResponse rtn = new RefreshTokenResponse();

            var client = new RestClient(XeroUrl.IdentityServerRefreshToken);
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("grant_type", "refresh_token");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Basic " + (_settings.ClientId + ":" + _settings.ClientSecret).Base64Encode());

            request.AddParameter("grant_type", "refresh_token");
            request.AddParameter("refresh_token", _settings.RefreshToken);

            _log?.LogInformation("XeroClient: GetRefreshToken: call to refresh the access token");
            var response = client.Execute<RefreshTokenResponse>(request);

            _log?.LogInformation("XeroClient: GetRefreshToken: Response StatusCode " + response.StatusCode);

            rtn.HttpStatusCode = response.StatusCode;
            rtn.Status = (int)response.StatusCode == 200 ? PSC.Common.Enums.ResponseStatus.Success : PSC.Common.Enums.ResponseStatus.Failed;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = response.Data;

                rtn.IdToken = data?.IdToken;
                rtn.AccessToken = data?.AccessToken;
                rtn.ExpiresIn = data.ExpiresIn;
                rtn.LastUpdate = DateTime.Now;
                rtn.TokenType = data?.TokenType;
                rtn.RefreshToken = data?.RefreshToken;
                rtn.Scope = data?.Scope;
            }

            return rtn;
        }
        #endregion
    }
}