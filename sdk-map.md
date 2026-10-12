<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — Google Maps Platform (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | Google Maps Platform |
| Root namespace | `GoogleMapsPlatform` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `1.22.5` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file — never to the page that carries them; the project file is `src/GoogleMapsPlatform/GoogleMapsPlatform.csproj`. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options = new GoogleMapsPlatformClientOptions
{
    ApiKeyAuth = "YOUR_API_KEY",
    Environment = ServerEnvironment.Production,
};
var client = new GoogleMapsPlatformClient(httpClient, options);
```

DI alternative (`services.AddGoogleMapsPlatformClient`):

```csharp
services.AddGoogleMapsPlatformClient(options =>
{
    options.ApiKeyAuth = "YOUR_API_KEY";
    options.Environment = ServerEnvironment.Production;
    // TODO: configure more client options here
});
```

Every API group is a property on the client (e.g. `client.DirectionsApi`). Source: `src/GoogleMapsPlatform/GoogleMapsPlatformClient.cs`. The only constructor is `GoogleMapsPlatformClient(HttpClient httpClient, GoogleMapsPlatformClientOptions options)`.

All `GoogleMapsPlatformClientOptions` properties (source: `src/GoogleMapsPlatform/GoogleMapsPlatformClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `TimeProvider` | `TimeProvider` |
| `Server` | `ServerOptions` |
| `StreamReadTimeout` | `TimeSpan?` |
| `Hooks` | `IReadOnlyList<SdkHook>` |
| `ApiKeyAuth` | `string?` |

`ServerEnvironment` (source: `src/GoogleMapsPlatform/Servers/ServerEnvironment.cs`, namespace `GoogleMapsPlatform.Servers`)

`RetryOptions` members (namespace `GoogleMapsPlatform.Core.Configuration` — add `using GoogleMapsPlatform.Core.Configuration;`; source: `src/GoogleMapsPlatform/Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `ApiException<TError>` (`src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs`, namespace `GoogleMapsPlatform.Core.Exceptions`) exposing `.Error` of type `TError` beside the `StatusCode`, `Headers` and `ContentType` of the response. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class (namespace `GoogleMapsPlatform.Errors`) with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs`, namespace `GoogleMapsPlatform.Core.ErrorResponse`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

⚠ Each of the three lives in its own namespace. `src/GoogleMapsPlatform/Core/` holds several namespaces, so a catch block naming `ApiException<T>`, a typed `{Operation}Error` and `RawError` together needs a `using` for each.

`ApiException<TError>` is one leaf of the `SdkException` family (`src/GoogleMapsPlatform/Core/Exceptions/SdkException.cs`): a request that produced no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match its declared type as `ResponseDeserializationException`, and a credential that could not be applied as `AuthSchemeException`. Every one of them names the failed call. The full table is in [README → Error Handling](README.md#error-handling).

Core error types (`src/GoogleMapsPlatform/Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 2 typed error classes in `src/GoogleMapsPlatform/Errors/` | `TryGetRawError(out RawError error): bool` | `src/GoogleMapsPlatform/Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.GeolocationApi.Geolocate(new GeolocateRequest
    {
        Body = new GeolocationV1GeolocateRequest
        {
            ConsiderIp = "false",
            WifiAccessPoints = [
                new WiFiAccessPoint { MacAddress = "84:d4:7e:09:a5:f1", SignalStrength = -43, SignalToNoiseRatio = 0 },
                new WiFiAccessPoint { MacAddress = "44:48:c1:a6:f3:d0", SignalStrength = -55, SignalToNoiseRatio = 0 },
            ],
        },
    });
}
catch (ApiException<GeolocateError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetGeolocationV1Geolocate400Error1(out var error))
    {
        // Handle 400
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (ApiException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **17 operations**, **2 are Case A (typed)** and **15 are Case B (raw)**.

---

## Operations — by controller (9 groups, 17 operations)

Each links to a sub-page with one row per operation: signature, the request record's required members, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Inputs are one request record** — an operation that takes input takes a single request record as its first parameter; build it with an object initializer, using the property names in the record's source (its file is in the operation's **Type sources**). A member the row does not list as required is optional or already carries the spec's default | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `DirectionsApi` | 1 | [map/operations/DirectionsApi.md](map/operations/DirectionsApi.md) |
| `DistanceMatrixApi` | 1 | [map/operations/DistanceMatrixApi.md](map/operations/DistanceMatrixApi.md) |
| `ElevationApi` | 1 | [map/operations/ElevationApi.md](map/operations/ElevationApi.md) |
| `GeocodingApi` | 1 | [map/operations/GeocodingApi.md](map/operations/GeocodingApi.md) |
| `GeolocationApi` | 1 | [map/operations/GeolocationApi.md](map/operations/GeolocationApi.md) |
| `PlacesApi` | 7 | [map/operations/PlacesApi.md](map/operations/PlacesApi.md) |
| `RoadsApi` | 2 | [map/operations/RoadsApi.md](map/operations/RoadsApi.md) |
| `StreetViewApi` | 2 | [map/operations/StreetViewApi.md](map/operations/StreetViewApi.md) |
| `TimeZoneApi` | 1 | [map/operations/TimeZoneApi.md](map/operations/TimeZoneApi.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `src/GoogleMapsPlatform/Models/`, `src/GoogleMapsPlatform/Errors/` and `src/GoogleMapsPlatform/Requests/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 96 | `src/GoogleMapsPlatform/Models/` |
| Enums (`OpenStringEnum<T>` / `OpenIntEnum<T>`) — C# member names + wire values | 41 | `src/GoogleMapsPlatform/Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 2 | `src/GoogleMapsPlatform/Errors/` |
| Request records (one per operation that takes input; never serialized) | 17 | `src/GoogleMapsPlatform/Requests/` — a controller's records sit in a folder named after it (an operation with several tags is filed under the first tag it declares) |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — use the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`); there is no public factory, so resolve a raw value with `TryGetKnownValue` and branch with the generated `Match`, whose `otherwise` arm receives any value the SDK does not declare.

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `GoogleMapsPlatform` |
| Operation controllers (`src/GoogleMapsPlatform/Api/`) | `GoogleMapsPlatform.Api` |
| Records (`src/GoogleMapsPlatform/Models/`) | `GoogleMapsPlatform.Models` |
| Enums (`src/GoogleMapsPlatform/Models/Enums/`) | `GoogleMapsPlatform.Models.Enums` |
| Error classes (`src/GoogleMapsPlatform/Errors/`) | `GoogleMapsPlatform.Errors` |
| Request records (`src/GoogleMapsPlatform/Requests/`) | `GoogleMapsPlatform.Requests` — plus `.<Controller>` for a controller's records (an operation with several tags is filed under the first tag it declares) |

---

## Servers & auth

**API key (query `key`).** Set `options.ApiKeyAuth = "<api_key>"`; sent as the `key` query parameter.

Operation blocks name their credential in an **Auth** bullet; an operation whose spec declares no scheme carries no such bullet.

- `AND` — every credential listed must be set for the call to be fully authenticated.
- `OR` — the first credential you set that applies successfully is the one sent, in the order listed.

A credential you never set is skipped rather than throwing, and the request is sent anyway — so an authentication failure can mean no credential was sent rather than a bad one. Under `OR`, if every credential you did set fails to apply, `AuthSchemeException` is thrown.

**Environments.** `options.Environment` selects the target environment (`src/GoogleMapsPlatform/Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | — |
| `ServerEnvironment.Environment2` | `environment2` | — |
| `ServerEnvironment.Environment3` | `environment3` | — |

**1 server group.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | `Environment2` base URL | `Environment3` base URL | Override point |
| --- | --- | --- | --- | --- |
| `Default` | `https://www.googleapis.com` | `https://maps.googleapis.com` | `https://roads.googleapis.com` | `options.Server.Default.Production.BaseUrl` (and the other environments) |

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

