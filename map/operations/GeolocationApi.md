<!-- Generated file — do not edit; regenerated with the SDK. -->

# GeolocationApi — operations

Accessor: `client.GeolocationApi` · Source: `src/GoogleMapsPlatform/Api/GeolocationApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Geolocate

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Geolocate(GeolocateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GeolocationV1GeolocateResponse`
- **Error**: `ApiException<GeolocateError>` — **Case A (typed)**
- **Error accessors**: `TryGetGeolocationV1Geolocate400Error1(out GeolocationV1Geolocate400Error1)` [400] · `TryGetGeolocationV1Geolocate404Error1(out GeolocationV1Geolocate404Error1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GeolocateRequest` | `src/GoogleMapsPlatform/Requests/GeolocationApi/GeolocateRequest.cs` |
| `GeolocationV1GeolocateRequest` | `src/GoogleMapsPlatform/Models/GeolocationV1GeolocateRequest.cs` |
| `GeolocationV1GeolocateResponse` | `src/GoogleMapsPlatform/Models/GeolocationV1GeolocateResponse.cs` |
| `GeolocateError` | `src/GoogleMapsPlatform/Errors/GeolocateError.cs` |
| `GeolocationV1Geolocate400Error1` | `src/GoogleMapsPlatform/Models/GeolocationV1Geolocate400Error1.cs` |
| `GeolocationV1Geolocate404Error1` | `src/GoogleMapsPlatform/Models/GeolocationV1Geolocate404Error1.cs` |

