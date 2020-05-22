# Simple Xero Connector
Simple library for integrate a .NET Core application to Xero.

The Xero documentation is not really clear and the examples are quite old. With the recent introduction of `OAuth` 2.0, it is a bit difficult and complicated to integrate your .NET application with Xero.

My goal is to have a package for a Xero Connector with basic functionalities. So, I can use it and share it. The functionalities I want to have are:</p>

- Get invoices
- Search an invoice
- Get an invoice as PDF
- Create a client/customer
- Create an invoice
- Refresh the access token

## Initialize XeroClient
`ExternalAccountingSettings` is the settings for the connection to Xero. You have to collect from Xero the following data:

- Client Id
- Client Secret
- Tenant Id
- Access Token
- Refresh Token

`_log` could be `null` but if you want to know what it happens in the library, you can instance

```
private ILogger _log;
```

With those data

```
ExternalAccountingSettings _settings = new ExternalAccountingSettings();
XeroClient xeroClient = new XeroClient(_settings, _log);
```

## See also
- [Integrate Xero with C# applications](https://www.puresourcecode.com/dotnet/csharp/integrate-xero-with-csharp-applications/)
- [Getting invoices list with Xero in C#](https://www.puresourcecode.com/dotnet/net-core/getting-invoice-list-from-xero-in-csharp)
