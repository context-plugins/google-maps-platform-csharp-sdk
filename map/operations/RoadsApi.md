<!-- Generated file — do not edit; regenerated with the SDK. -->

# RoadsApi — operations

Accessor: `client.RoadsApi` · Source: `src/GoogleMapsPlatform/Api/RoadsApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### NearestRoads

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NearestRoads(NearestRoadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Points`
- **Query params (wire ← C#)**: `points` ← `Points`
- **Returns**: `NearestRoadsResponse`
- **Error**: `ApiException<NearestRoadsApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetNearestRoadsErrorResponse(out NearestRoadsErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NearestRoadsRequest` | `src/GoogleMapsPlatform/Requests/RoadsApi/NearestRoadsRequest.cs` |
| `NearestRoadsResponse` | `src/GoogleMapsPlatform/Models/NearestRoadsResponse.cs` |
| `NearestRoadsApiError` | `src/GoogleMapsPlatform/Errors/NearestRoadsApiError.cs` |
| `NearestRoadsErrorResponse` | `src/GoogleMapsPlatform/Models/NearestRoadsErrorResponse.cs` |

### SnapToRoads

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SnapToRoads(SnapToRoadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Path`
- **Query params (wire ← C#)**: `path` ← `Path`, `interpolate` ← `Interpolate`
- **Returns**: `SnapToRoadsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SnapToRoadsRequest` | `src/GoogleMapsPlatform/Requests/RoadsApi/SnapToRoadsRequest.cs` |
| `SnapToRoadsResponse` | `src/GoogleMapsPlatform/Models/SnapToRoadsResponse.cs` |

