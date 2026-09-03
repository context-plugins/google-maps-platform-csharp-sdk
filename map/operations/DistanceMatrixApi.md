<!-- Generated file — do not edit; regenerated with the SDK. -->

# DistanceMatrixApi — operations

Accessor: `client.DistanceMatrixApi` · Source: `Api/DistanceMatrixApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DistanceMatrix

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `DistanceMatrix(IReadOnlyList<string> destinations, IReadOnlyList<string> origins, double? arrivalTime, double? departureTime, string? avoid, Units2? units, Language1? language, Mode1? mode, Region1? region, TrafficModel1? trafficModel, string? transitMode, TransitRoutingPreference1? transitRoutingPreference, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`arrivalTime` … `transitRoutingPreference`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `destinations` ← `destinations`, `origins` ← `origins`, `arrival_time` ← `arrivalTime`, `departure_time` ← `departureTime`, `avoid` ← `avoid`, `units` ← `units`, `language` ← `language`, `mode` ← `mode`, `region` ← `region`, `traffic_model` ← `trafficModel`, `transit_mode` ← `transitMode`, `transit_routing_preference` ← `transitRoutingPreference`
- **Returns**: `DistanceMatrixResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Units2` | `Models/Enums/Units2.cs` |
| `Language1` | `Models/Enums/Language1.cs` |
| `Mode1` | `Models/Enums/Mode1.cs` |
| `Region1` | `Models/Enums/Region1.cs` |
| `TrafficModel1` | `Models/Enums/TrafficModel1.cs` |
| `TransitRoutingPreference1` | `Models/Enums/TransitRoutingPreference1.cs` |
| `DistanceMatrixResponse` | `Models/DistanceMatrixResponse.cs` |

