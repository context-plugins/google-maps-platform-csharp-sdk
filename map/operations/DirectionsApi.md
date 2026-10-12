<!-- Generated file — do not edit; regenerated with the SDK. -->

# DirectionsApi — operations

Accessor: `client.DirectionsApi` · Source: `src/GoogleMapsPlatform/Api/DirectionsApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Directions

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Directions(DirectionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Destination`, `Origin`
- **Query params (wire ← C#)**: `destination` ← `Destination`, `origin` ← `Origin`, `arrival_time` ← `ArrivalTime`, `departure_time` ← `DepartureTime`, `alternatives` ← `Alternatives`, `avoid` ← `Avoid`, `units` ← `Units`, `waypoints` ← `Waypoints`, `language` ← `Language`, `mode` ← `Mode`, `region` ← `Region`, `traffic_model` ← `TrafficModel`, `transit_mode` ← `TransitMode`, `transit_routing_preference` ← `TransitRoutingPreference`
- **Returns**: `DirectionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DirectionsRequest` | `src/GoogleMapsPlatform/Requests/DirectionsApi/DirectionsRequest.cs` |
| `Units1` | `src/GoogleMapsPlatform/Models/Enums/Units1.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `Mode1` | `src/GoogleMapsPlatform/Models/Enums/Mode1.cs` |
| `Region1` | `src/GoogleMapsPlatform/Models/Enums/Region1.cs` |
| `TrafficModel1` | `src/GoogleMapsPlatform/Models/Enums/TrafficModel1.cs` |
| `TransitRoutingPreference1` | `src/GoogleMapsPlatform/Models/Enums/TransitRoutingPreference1.cs` |
| `DirectionsResponse` | `src/GoogleMapsPlatform/Models/DirectionsResponse.cs` |

