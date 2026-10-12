<!-- Generated file — do not edit; regenerated with the SDK. -->

# DistanceMatrixApi — operations

Accessor: `client.DistanceMatrixApi` · Source: `src/GoogleMapsPlatform/Api/DistanceMatrixApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DistanceMatrix

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DistanceMatrix(DistanceMatrixRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Destinations`, `Origins`
- **Query params (wire ← C#)**: `destinations` ← `Destinations`, `origins` ← `Origins`, `arrival_time` ← `ArrivalTime`, `departure_time` ← `DepartureTime`, `avoid` ← `Avoid`, `units` ← `Units`, `language` ← `Language`, `mode` ← `Mode`, `region` ← `Region`, `traffic_model` ← `TrafficModel`, `transit_mode` ← `TransitMode`, `transit_routing_preference` ← `TransitRoutingPreference`
- **Returns**: `DistanceMatrixResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DistanceMatrixRequest` | `src/GoogleMapsPlatform/Requests/DistanceMatrixApi/DistanceMatrixRequest.cs` |
| `Units2` | `src/GoogleMapsPlatform/Models/Enums/Units2.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `Mode1` | `src/GoogleMapsPlatform/Models/Enums/Mode1.cs` |
| `Region1` | `src/GoogleMapsPlatform/Models/Enums/Region1.cs` |
| `TrafficModel1` | `src/GoogleMapsPlatform/Models/Enums/TrafficModel1.cs` |
| `TransitRoutingPreference1` | `src/GoogleMapsPlatform/Models/Enums/TransitRoutingPreference1.cs` |
| `DistanceMatrixResponse` | `src/GoogleMapsPlatform/Models/DistanceMatrixResponse.cs` |

