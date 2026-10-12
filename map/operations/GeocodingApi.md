<!-- Generated file — do not edit; regenerated with the SDK. -->

# GeocodingApi — operations

Accessor: `client.GeocodingApi` · Source: `src/GoogleMapsPlatform/Api/GeocodingApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Geocode

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Geocode(GeocodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `address` ← `Address`, `bounds` ← `Bounds`, `components` ← `Components`, `latlng` ← `Latlng`, `location_type` ← `LocationType`, `place_id` ← `PlaceId`, `result_type` ← `ResultType`, `language` ← `Language`, `region` ← `Region`
- **Returns**: `GeocodingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GeocodeRequest` | `src/GoogleMapsPlatform/Requests/GeocodingApi/GeocodeRequest.cs` |
| `LocationType` | `src/GoogleMapsPlatform/Models/Enums/LocationType.cs` |
| `ResultType` | `src/GoogleMapsPlatform/Models/Enums/ResultType.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `Region1` | `src/GoogleMapsPlatform/Models/Enums/Region1.cs` |
| `GeocodingResponse` | `src/GoogleMapsPlatform/Models/GeocodingResponse.cs` |

