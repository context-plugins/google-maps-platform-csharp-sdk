<!-- Generated file — do not edit; regenerated with the SDK. -->

# DirectionsApi — operations

Accessor: `client.DirectionsApi` · Source: `Api/DirectionsApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Directions

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Directions(string destination, string origin, double? arrivalTime, double? departureTime, bool? alternatives, string? avoid, Units1? units, string? waypoints, Language1? language, Mode1? mode, Region1? region, TrafficModel1? trafficModel, string? transitMode, TransitRoutingPreference1? transitRoutingPreference, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 12 params (`arrivalTime` … `transitRoutingPreference`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `destination` ← `destination`, `origin` ← `origin`, `arrival_time` ← `arrivalTime`, `departure_time` ← `departureTime`, `alternatives` ← `alternatives`, `avoid` ← `avoid`, `units` ← `units`, `waypoints` ← `waypoints`, `language` ← `language`, `mode` ← `mode`, `region` ← `region`, `traffic_model` ← `trafficModel`, `transit_mode` ← `transitMode`, `transit_routing_preference` ← `transitRoutingPreference`
- **Returns**: `DirectionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Units1` | `Models/Enums/Units1.cs` |
| `Language1` | `Models/Enums/Language1.cs` |
| `Mode1` | `Models/Enums/Mode1.cs` |
| `Region1` | `Models/Enums/Region1.cs` |
| `TrafficModel1` | `Models/Enums/TrafficModel1.cs` |
| `TransitRoutingPreference1` | `Models/Enums/TransitRoutingPreference1.cs` |
| `DirectionsResponse` | `Models/DirectionsResponse.cs` |

