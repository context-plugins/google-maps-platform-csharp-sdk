<!-- Generated file — do not edit; regenerated with the SDK. -->

# PlacesApi — operations

Accessor: `client.PlacesApi` · Source: `src/GoogleMapsPlatform/Api/PlacesApi.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Autocomplete

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `Autocomplete(AutocompleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Input`, `Radius`
- **Query params (wire ← C#)**: `input` ← `Input`, `radius` ← `Radius`, `sessiontoken` ← `Sessiontoken`, `components` ← `Components`, `strictbounds` ← `Strictbounds`, `offset` ← `Offset`, `origin` ← `Origin`, `location` ← `Location`, `locationbias` ← `Locationbias`, `locationrestriction` ← `Locationrestriction`, `types` ← `Types`, `language` ← `Language`, `region` ← `Region`
- **Returns**: `PlacesAutocompleteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AutocompleteRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/AutocompleteRequest.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `Region1` | `src/GoogleMapsPlatform/Models/Enums/Region1.cs` |
| `PlacesAutocompleteResponse` | `src/GoogleMapsPlatform/Models/PlacesAutocompleteResponse.cs` |

### FindPlaceFromText

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `FindPlaceFromText(FindPlaceFromTextRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Input`, `Inputtype`
- **Query params (wire ← C#)**: `input` ← `Input`, `inputtype` ← `Inputtype`, `fields` ← `Fields`, `locationbias` ← `Locationbias`, `language` ← `Language`
- **Returns**: `PlacesFindPlaceFromTextResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FindPlaceFromTextRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/FindPlaceFromTextRequest.cs` |
| `Inputtype1` | `src/GoogleMapsPlatform/Models/Enums/Inputtype1.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `PlacesFindPlaceFromTextResponse` | `src/GoogleMapsPlatform/Models/PlacesFindPlaceFromTextResponse.cs` |

### NearbySearch

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `NearbySearch(NearbySearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Location`, `Radius`
- **Query params (wire ← C#)**: `location` ← `Location`, `radius` ← `Radius`, `keyword` ← `Keyword`, `maxprice` ← `Maxprice`, `minprice` ← `Minprice`, `name` ← `Name`, `opennow` ← `Opennow`, `pagetoken` ← `Pagetoken`, `rankby` ← `Rankby`, `type` ← `Type`, `language` ← `Language`
- **Returns**: `PlacesTextSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NearbySearchRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/NearbySearchRequest.cs` |
| `Maxprice1` | `src/GoogleMapsPlatform/Models/Enums/Maxprice1.cs` |
| `Minprice1` | `src/GoogleMapsPlatform/Models/Enums/Minprice1.cs` |
| `Rankby1` | `src/GoogleMapsPlatform/Models/Enums/Rankby1.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `PlacesTextSearchResponse` | `src/GoogleMapsPlatform/Models/PlacesTextSearchResponse.cs` |

### PlaceDetails

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PlaceDetails(PlaceDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PlaceId`
- **Query params (wire ← C#)**: `place_id` ← `PlaceId`, `fields` ← `Fields`, `sessiontoken` ← `Sessiontoken`, `language` ← `Language`, `region` ← `Region`, `reviews_sort` ← `ReviewsSort`, `reviews_no_translations` ← `ReviewsNoTranslations`
- **Returns**: `PlacesDetailsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PlaceDetailsRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/PlaceDetailsRequest.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `Region1` | `src/GoogleMapsPlatform/Models/Enums/Region1.cs` |
| `PlacesDetailsResponse` | `src/GoogleMapsPlatform/Models/PlacesDetailsResponse.cs` |

### PlacePhoto

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `PlacePhoto(PlacePhotoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PhotoReference`
- **Query params (wire ← C#)**: `photo_reference` ← `PhotoReference`, `maxheight` ← `Maxheight`, `maxwidth` ← `Maxwidth`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PlacePhotoRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/PlacePhotoRequest.cs` |

### QueryAutocomplete

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `QueryAutocomplete(QueryAutocompleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Input`, `Radius`
- **Query params (wire ← C#)**: `input` ← `Input`, `radius` ← `Radius`, `offset` ← `Offset`, `location` ← `Location`, `language` ← `Language`
- **Returns**: `PlacesQueryAutocompleteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `QueryAutocompleteRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/QueryAutocompleteRequest.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `PlacesQueryAutocompleteResponse` | `src/GoogleMapsPlatform/Models/PlacesQueryAutocompleteResponse.cs` |

### TextSearch

- **Auth**: `options.ApiKeyAuth`
- **Signature**: `TextSearch(TextSearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Query`, `Radius`
- **Query params (wire ← C#)**: `query` ← `Query`, `radius` ← `Radius`, `location` ← `Location`, `maxprice` ← `Maxprice`, `minprice` ← `Minprice`, `opennow` ← `Opennow`, `pagetoken` ← `Pagetoken`, `type` ← `Type`, `language` ← `Language`, `region` ← `Region`
- **Returns**: `PlacesTextSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TextSearchRequest` | `src/GoogleMapsPlatform/Requests/PlacesApi/TextSearchRequest.cs` |
| `Maxprice1` | `src/GoogleMapsPlatform/Models/Enums/Maxprice1.cs` |
| `Minprice1` | `src/GoogleMapsPlatform/Models/Enums/Minprice1.cs` |
| `Language1` | `src/GoogleMapsPlatform/Models/Enums/Language1.cs` |
| `Region1` | `src/GoogleMapsPlatform/Models/Enums/Region1.cs` |
| `PlacesTextSearchResponse` | `src/GoogleMapsPlatform/Models/PlacesTextSearchResponse.cs` |

