<!-- Generated file — do not edit; regenerated with the SDK. -->

# ElevationApi — operations

Accessor: `client.ElevationApi` · Source: `src/GoogleMapsPlatform/Api/ElevationApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Elevation

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Elevation(ElevationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `locations` ← `Locations`, `path` ← `Path`, `samples` ← `Samples`
- **Returns**: `MapsApiElevationJsonResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ElevationRequest` | `src/GoogleMapsPlatform/Requests/ElevationApi/ElevationRequest.cs` |
| `MapsApiElevationJsonResponse` | `src/GoogleMapsPlatform/Models/MapsApiElevationJsonResponse.cs` |

