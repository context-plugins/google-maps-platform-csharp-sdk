<!-- Generated file — do not edit; regenerated with the SDK. -->

# RoadsApi — operations

Accessor: `client.RoadsApi` · Source: `Api/RoadsApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### NearestRoads

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NearestRoads(IReadOnlyList<string> points, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `points` ← `points`
- **Returns**: `NearestRoadsResponse`
- **Error**: `SdkException<NearestRoadsApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetNearestRoadsErrorResponse(out NearestRoadsErrorResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `NearestRoadsResponse` | `Models/NearestRoadsResponse.cs` |
| `NearestRoadsApiError` | `Errors/NearestRoadsApiError.cs` |
| `NearestRoadsErrorResponse` | `Models/NearestRoadsErrorResponse.cs` |

### SnapToRoads

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `SnapToRoads(IReadOnlyList<string> path, bool? interpolate, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `interpolate` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `path` ← `path`, `interpolate` ← `interpolate`
- **Returns**: `SnapToRoadsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SnapToRoadsResponse` | `Models/SnapToRoadsResponse.cs` |

