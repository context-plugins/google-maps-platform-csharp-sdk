<!-- Generated file — do not edit; regenerated with the SDK. -->

# StreetViewApi — operations

Accessor: `client.StreetViewApi` · Source: `Api/StreetViewApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### StreetView

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `StreetView(string size, double? fov, double? heading, string? location, string? pano, double? pitch, double? radius, bool? returnErrorCode, string? signature, Source1? source, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`fov` … `source`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `size` ← `size`, `fov` ← `fov`, `heading` ← `heading`, `location` ← `location`, `pano` ← `pano`, `pitch` ← `pitch`, `radius` ← `radius`, `return_error_code` ← `returnErrorCode`, `signature` ← `signature`, `source` ← `source`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Source1` | `Models/Enums/Source1.cs` |

### StreetViewMetadata

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `StreetViewMetadata(double? heading, string? location, string? pano, double? pitch, double? radius, bool? returnErrorCode, string? signature, string? size, Source1? source, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`heading` … `source`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `heading` ← `heading`, `location` ← `location`, `pano` ← `pano`, `pitch` ← `pitch`, `radius` ← `radius`, `return_error_code` ← `returnErrorCode`, `signature` ← `signature`, `size` ← `size`, `source` ← `source`
- **Returns**: `StreetViewResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Source1` | `Models/Enums/Source1.cs` |
| `StreetViewResponse` | `Models/StreetViewResponse.cs` |

