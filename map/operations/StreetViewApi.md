<!-- Generated file — do not edit; regenerated with the SDK. -->

# StreetViewApi — operations

Accessor: `client.StreetViewApi` · Source: `src/GoogleMapsPlatform/Api/StreetViewApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### StreetView

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `StreetView(StreetViewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Size`
- **Query params (wire ← C#)**: `size` ← `Size`, `fov` ← `Fov`, `heading` ← `Heading`, `location` ← `Location`, `pano` ← `Pano`, `pitch` ← `Pitch`, `radius` ← `Radius`, `return_error_code` ← `ReturnErrorCode`, `signature` ← `Signature`, `source` ← `Source`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StreetViewRequest` | `src/GoogleMapsPlatform/Requests/StreetViewApi/StreetViewRequest.cs` |
| `Source1` | `src/GoogleMapsPlatform/Models/Enums/Source1.cs` |

### StreetViewMetadata

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `StreetViewMetadata(StreetViewMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `heading` ← `Heading`, `location` ← `Location`, `pano` ← `Pano`, `pitch` ← `Pitch`, `radius` ← `Radius`, `return_error_code` ← `ReturnErrorCode`, `signature` ← `Signature`, `size` ← `Size`, `source` ← `Source`
- **Returns**: `StreetViewResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StreetViewMetadataRequest` | `src/GoogleMapsPlatform/Requests/StreetViewApi/StreetViewMetadataRequest.cs` |
| `Source1` | `src/GoogleMapsPlatform/Models/Enums/Source1.cs` |
| `StreetViewResponse` | `src/GoogleMapsPlatform/Models/StreetViewResponse.cs` |

