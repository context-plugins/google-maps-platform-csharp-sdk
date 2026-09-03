<!-- Generated file — do not edit; regenerated with the SDK. -->

# ElevationApi — operations

Accessor: `client.ElevationApi` · Source: `Api/ElevationApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Elevation

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Elevation(IReadOnlyList<string>? locations, IReadOnlyList<string>? path, double? samples, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `locations` — nullable, no default → **must pass explicitly**
  - `path` — nullable, no default → **must pass explicitly**
  - `samples` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `locations` ← `locations`, `path` ← `path`, `samples` ← `samples`
- **Returns**: `MapsApiElevationJsonResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MapsApiElevationJsonResponse` | `Models/MapsApiElevationJsonResponse.cs` |

