<!-- Generated file — do not edit; regenerated with the SDK. -->

# GeolocationApi — operations

Accessor: `client.GeolocationApi` · Source: `Api/GeolocationApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Geolocate

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Geolocate(GeolocationV1GeolocateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `GeolocationV1GeolocateResponse`
- **Error**: `SdkException<GeolocateError>` — **Case A (typed)**
- **Error accessors**: `TryGetGeolocationV1Geolocate400Error1(out GeolocationV1Geolocate400Error1)` [400] · `TryGetGeolocationV1Geolocate404Error1(out GeolocationV1Geolocate404Error1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeolocationV1GeolocateRequest` | `Models/GeolocationV1GeolocateRequest.cs` |
| `GeolocationV1GeolocateResponse` | `Models/GeolocationV1GeolocateResponse.cs` |
| `GeolocateError` | `Errors/GeolocateError.cs` |
| `GeolocationV1Geolocate400Error1` | `Models/GeolocationV1Geolocate400Error1.cs` |
| `GeolocationV1Geolocate404Error1` | `Models/GeolocationV1Geolocate404Error1.cs` |

