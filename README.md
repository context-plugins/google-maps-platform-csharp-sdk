# Google Maps Platform

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Google Maps Platform SDK for .NET provides access to the Google Maps Platform REST APIs from .NET applications.

API Specification for Google Maps Platform

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/GoogleMapsPlatform.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [GoogleMapsPlatformClientOptions](GoogleMapsPlatformClientOptions.cs).

```csharp
services.AddGoogleMapsPlatformClient(options =>
    {
        options.ApiKeyAuth = "YOUR_API_KEY";
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [GoogleMapsPlatformClientOptions](GoogleMapsPlatformClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new GoogleMapsPlatformClientOptions
    {
        ApiKeyAuth = "YOUR_API_KEY",
        Environment = ServerEnvironment.Production,
    };
var client = new GoogleMapsPlatformClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `GoogleMapsPlatformClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
