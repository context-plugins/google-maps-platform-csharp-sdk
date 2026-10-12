<!-- Generated file — do not edit; regenerated with the SDK. -->

# TimeZoneApi — operations

Accessor: `client.TimeZoneApi` · Source: `src/GoogleMapsPlatform/Api/TimeZoneApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Timezone

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Timezone(TimezoneRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Location`, `Timestamp`
- **Query params (wire ← C#)**: `location` ← `Location`, `timestamp` ← `Timestamp`, `language` ← `Language`
- **Returns**: `TimeZoneResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TimezoneRequest` | `src/GoogleMapsPlatform/Requests/TimeZoneApi/TimezoneRequest.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `TimeZoneResponse` | `src/GoogleMapsPlatform/Models/TimeZoneResponse.cs` |

