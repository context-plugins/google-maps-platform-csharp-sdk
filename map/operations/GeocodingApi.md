<!-- Generated file — do not edit; regenerated with the SDK. -->

# GeocodingApi — operations

Accessor: `client.GeocodingApi` · Source: `Api/GeocodingApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Geocode

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Geocode(string? address, IReadOnlyList<string>? bounds, IReadOnlyList<string>? components, string? latlng, IReadOnlyList<LocationType>? locationType, string? placeId, IReadOnlyList<ResultType>? resultType, Language1? language, Region1? region, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`address` … `region`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `address` ← `address`, `bounds` ← `bounds`, `components` ← `components`, `latlng` ← `latlng`, `location_type` ← `locationType`, `place_id` ← `placeId`, `result_type` ← `resultType`, `language` ← `language`, `region` ← `region`
- **Returns**: `GeocodingResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LocationType` | `Models/Enums/LocationType.cs` |
| `ResultType` | `Models/Enums/ResultType.cs` |
| `Language1` | `Models/Enums/Language1.cs` |
| `Region1` | `Models/Enums/Region1.cs` |
| `GeocodingResponse` | `Models/GeocodingResponse.cs` |

