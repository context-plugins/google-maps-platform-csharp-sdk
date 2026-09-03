<!-- Generated file — do not edit; regenerated with the SDK. -->

# PlacesApi — operations

Accessor: `client.PlacesApi` · Source: `Api/PlacesApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Autocomplete

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Autocomplete(string input, double radius, string? sessiontoken, string? components, bool? strictbounds, double? offset, string? origin, string? location, string? locationbias, string? locationrestriction, string? types, Language1? language, Region1? region, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 11 params (`sessiontoken` … `region`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `input` ← `input`, `radius` ← `radius`, `sessiontoken` ← `sessiontoken`, `components` ← `components`, `strictbounds` ← `strictbounds`, `offset` ← `offset`, `origin` ← `origin`, `location` ← `location`, `locationbias` ← `locationbias`, `locationrestriction` ← `locationrestriction`, `types` ← `types`, `language` ← `language`, `region` ← `region`
- **Returns**: `PlacesAutocompleteResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Language1` | `Models/Enums/Language1.cs` |
| `Region1` | `Models/Enums/Region1.cs` |
| `PlacesAutocompleteResponse` | `Models/PlacesAutocompleteResponse.cs` |

### FindPlaceFromText

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FindPlaceFromText(string input, Inputtype1 inputtype, IReadOnlyList<string>? fields, string? locationbias, Language1? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `fields` — nullable, no default → **must pass explicitly**
  - `locationbias` — nullable, no default → **must pass explicitly**
  - `language` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `input` ← `input`, `inputtype` ← `inputtype`, `fields` ← `fields`, `locationbias` ← `locationbias`, `language` ← `language`
- **Returns**: `PlacesFindPlaceFromTextResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Inputtype1` | `Models/Enums/Inputtype1.cs` |
| `Language1` | `Models/Enums/Language1.cs` |
| `PlacesFindPlaceFromTextResponse` | `Models/PlacesFindPlaceFromTextResponse.cs` |

### NearbySearch

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NearbySearch(string location, double radius, string? keyword, Maxprice1? maxprice, Minprice1? minprice, string? name, bool? opennow, string? pagetoken, Rankby1? rankby, string? type, Language1? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`keyword` … `language`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `location` ← `location`, `radius` ← `radius`, `keyword` ← `keyword`, `maxprice` ← `maxprice`, `minprice` ← `minprice`, `name` ← `name`, `opennow` ← `opennow`, `pagetoken` ← `pagetoken`, `rankby` ← `rankby`, `type` ← `type`, `language` ← `language`
- **Returns**: `PlacesTextSearchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Maxprice1` | `Models/Enums/Maxprice1.cs` |
| `Minprice1` | `Models/Enums/Minprice1.cs` |
| `Rankby1` | `Models/Enums/Rankby1.cs` |
| `Language1` | `Models/Enums/Language1.cs` |
| `PlacesTextSearchResponse` | `Models/PlacesTextSearchResponse.cs` |

### PlaceDetails

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PlaceDetails(string placeId, IReadOnlyList<string>? fields, string? sessiontoken, Language1? language, Region1? region, string? reviewsSort, bool? reviewsNoTranslations, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`fields` … `reviewsNoTranslations`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `place_id` ← `placeId`, `fields` ← `fields`, `sessiontoken` ← `sessiontoken`, `language` ← `language`, `region` ← `region`, `reviews_sort` ← `reviewsSort`, `reviews_no_translations` ← `reviewsNoTranslations`
- **Returns**: `PlacesDetailsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Language1` | `Models/Enums/Language1.cs` |
| `Region1` | `Models/Enums/Region1.cs` |
| `PlacesDetailsResponse` | `Models/PlacesDetailsResponse.cs` |

### PlacePhoto

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PlacePhoto(string photoReference, double? maxheight, double? maxwidth, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `maxheight` — nullable, no default → **must pass explicitly**
  - `maxwidth` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `photo_reference` ← `photoReference`, `maxheight` ← `maxheight`, `maxwidth` ← `maxwidth`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### QueryAutocomplete

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAutocomplete(string input, double radius, double? offset, string? location, Language1? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `offset` — nullable, no default → **must pass explicitly**
  - `location` — nullable, no default → **must pass explicitly**
  - `language` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `input` ← `input`, `radius` ← `radius`, `offset` ← `offset`, `location` ← `location`, `language` ← `language`
- **Returns**: `PlacesQueryAutocompleteResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Language1` | `Models/Enums/Language1.cs` |
| `PlacesQueryAutocompleteResponse` | `Models/PlacesQueryAutocompleteResponse.cs` |

### TextSearch

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TextSearch(string query, double radius, string? location, Maxprice1? maxprice, Minprice1? minprice, bool? opennow, string? pagetoken, string? type, Language1? language, Region1? region, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`location` … `region`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `query` ← `query`, `radius` ← `radius`, `location` ← `location`, `maxprice` ← `maxprice`, `minprice` ← `minprice`, `opennow` ← `opennow`, `pagetoken` ← `pagetoken`, `type` ← `type`, `language` ← `language`, `region` ← `region`
- **Returns**: `PlacesTextSearchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Maxprice1` | `Models/Enums/Maxprice1.cs` |
| `Minprice1` | `Models/Enums/Minprice1.cs` |
| `Language1` | `Models/Enums/Language1.cs` |
| `Region1` | `Models/Enums/Region1.cs` |
| `PlacesTextSearchResponse` | `Models/PlacesTextSearchResponse.cs` |

