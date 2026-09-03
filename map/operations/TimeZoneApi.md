<!-- Generated file — do not edit; regenerated with the SDK. -->

# TimeZoneApi — operations

Accessor: `client.TimeZoneApi` · Source: `Api/TimeZoneApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Timezone

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Timezone(string location, double timestamp, Language1? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `language` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `location` ← `location`, `timestamp` ← `timestamp`, `language` ← `language`
- **Returns**: `TimeZoneResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Language1` | `Models/Enums/Language1.cs` |
| `TimeZoneResponse` | `Models/TimeZoneResponse.cs` |

