# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [GoogleMapsPlatformClient](src/GoogleMapsPlatform/GoogleMapsPlatformClient.cs)

## DirectionsApi

> Source: [DirectionsApi](src/GoogleMapsPlatform/Api/DirectionsApi.cs)

<details>
<summary><code>Task&lt;DirectionsResponse&gt; Directions(DirectionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Directions API is a web service that uses an HTTP request to return JSON or XML-formatted directions between locations. You can receive directions for several modes of transportation, such as transit, driving, walking, or cycling.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DirectionsApi.Directions(new DirectionsRequest
    {
        Destination = "Victoria, BC",
        Origin = "Vancouver, BC",
        Avoid = "highways",
        Waypoints = "MA|Lexington,MA",
        TransitMode = "train|tram|subway",
    });
    // TODO: Handle 'response' of type DirectionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DirectionsRequest](src/GoogleMapsPlatform/Requests/DirectionsApi/DirectionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DirectionsResponse](src/GoogleMapsPlatform/Models/DirectionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DistanceMatrixApi

> Source: [DistanceMatrixApi](src/GoogleMapsPlatform/Api/DistanceMatrixApi.cs)

<details>
<summary><code>Task&lt;DistanceMatrixResponse&gt; DistanceMatrix(DistanceMatrixRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Distance Matrix API is a service that provides travel distance and time for a matrix of origins and destinations. The API returns information based on the recommended route between start and end points, as calculated by the Google Maps API, and consists of rows containing duration and distance values for each pair.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DistanceMatrixApi.DistanceMatrix(new DistanceMatrixRequest
    {
        Destinations = ["San Francisco", "Victoria BC"],
        Origins = ["Vancouver BC", "Seattle"],
        Avoid = "highways",
        TransitMode = "train|tram|subway",
    });
    // TODO: Handle 'response' of type DistanceMatrixResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DistanceMatrixRequest](src/GoogleMapsPlatform/Requests/DistanceMatrixApi/DistanceMatrixRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DistanceMatrixResponse](src/GoogleMapsPlatform/Models/DistanceMatrixResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ElevationApi

> Source: [ElevationApi](src/GoogleMapsPlatform/Api/ElevationApi.cs)

<details>
<summary><code>Task&lt;MapsApiElevationJsonResponse&gt; Elevation(ElevationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Elevation API provides a simple interface to query locations on the earth for elevation data. Additionally, you may request sampled elevation data along paths, allowing you to calculate elevation changes along routes. With the Elevation API, you can develop hiking and biking applications, positioning applications, or low resolution surveying applications.

Elevation data is available for all locations on the surface of the earth, including depth locations on the ocean floor (which return negative values). In those cases where Google does not possess exact elevation measurements at the precise location you request, the service interpolates and returns an averaged value using the four nearest locations. Elevation values are expressed relative to local mean sea level (LMSL).

Requests to the Elevation API utilize different parameters based on whether the request is for discrete locations or for an ordered path. For discrete locations, requests for elevation return data on the specific locations passed in the request; for paths, elevation requests are instead sampled along the given path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ElevationApi.Elevation(new ElevationRequest
    {
        Locations = ["35,-100", "40,-110"],
        Path = ["35,-110", "33,-110", "31,-110"],
        Samples = 10d,
    });
    // TODO: Handle 'response' of type MapsApiElevationJsonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ElevationRequest](src/GoogleMapsPlatform/Requests/ElevationApi/ElevationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MapsApiElevationJsonResponse](src/GoogleMapsPlatform/Models/MapsApiElevationJsonResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GeocodingApi

> Source: [GeocodingApi](src/GoogleMapsPlatform/Api/GeocodingApi.cs)

<details>
<summary><code>Task&lt;GeocodingResponse&gt; Geocode(GeocodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Geocoding API is a service that provides geocoding and reverse geocoding of addresses.

**Geocoding** is the process of converting addresses (like a street address) into geographic coordinates (like latitude and longitude), which you can use to place markers on a map, or position the map.

**Reverse geocoding** is the process of converting geographic coordinates into a human-readable address.

You can also use the Geocoding API to find the address for a given place ID.

To see countries currently supported by the Google Maps Platform Geocoding API, please consult the [Google Maps coverage data](https://developers.google.com/maps/coverage). The accuracy of geocoded locations may vary per country, so you should consider using the returned `location_type` field to determine if a good enough match has been found for the purposes of your application. Please note that the availability of geocoding data depends on our contracts with data providers, so it is subject to change.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GeocodingApi.Geocode(new GeocodeRequest
    {
        Address = "1600 Amphitheatre+Parkway, Mountain View, CA",
        Bounds = ["35,-100", "40,-110"],
        Components = [
            "street_number:1600",
            "route:Amphitheatre+Parkway",
            "locality:Mountain+View",
            "administrative_area_level_1:CA",
            "country:US",
        ],
        Latlng = "40,-110",
        PlaceId = "ChIJN1t_tDeuEmsRUsoyG83frY4",
    });
    // TODO: Handle 'response' of type GeocodingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GeocodeRequest](src/GoogleMapsPlatform/Requests/GeocodingApi/GeocodeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeocodingResponse](src/GoogleMapsPlatform/Models/GeocodingResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GeolocationApi

> Source: [GeolocationApi](src/GoogleMapsPlatform/Api/GeolocationApi.cs)

<details>
<summary><code>Task&lt;GeolocationV1GeolocateResponse&gt; Geolocate(GeolocateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Geolocation API returns a location and accuracy radius based on information about cell towers and WiFi nodes that the mobile client can detect. This document describes the protocol used to send this data to the server and to return a response to the client.

Communication is done over HTTPS using POST. Both request and response are formatted as JSON, and the content type of both is `application/json`.

You must specify a key in your request, included as the value of a`key` parameter. A `key` is your application's  API key. This key identifies your application for purposes of quota management. Learn how to [get a key](https://developers.google.com/maps/documentation/geolocation/get-api-key).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GeolocationApi.Geolocate(new GeolocateRequest
    {
        Body = new GeolocationV1GeolocateRequest
        {
            ConsiderIp = "false",
            WifiAccessPoints = [
                new WiFiAccessPoint { MacAddress = "84:d4:7e:09:a5:f1", SignalStrength = -43, SignalToNoiseRatio = 0 },
                new WiFiAccessPoint { MacAddress = "44:48:c1:a6:f3:d0", SignalStrength = -55, SignalToNoiseRatio = 0 },
            ],
        },
    });
    // TODO: Handle 'response' of type GeolocationV1GeolocateResponse
}
catch (ApiException<GeolocateError> ex)
{
    if (ex.Error.TryGetGeolocationV1Geolocate400Error1(out var error))
    {
        // TODO: Handle 'error' of type GeolocationV1Geolocate400Error1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GeolocateRequest](src/GoogleMapsPlatform/Requests/GeolocationApi/GeolocateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GeolocationV1GeolocateResponse](src/GoogleMapsPlatform/Models/GeolocationV1GeolocateResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[GeolocateError](src/GoogleMapsPlatform/Errors/GeolocateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PlacesApi

> Source: [PlacesApi](src/GoogleMapsPlatform/Api/PlacesApi.cs)

<details>
<summary><code>Task&lt;PlacesAutocompleteResponse&gt; Autocomplete(AutocompleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Place Autocomplete service is a web service that returns place predictions in response to an HTTP request. The request specifies a textual search string and optional geographic bounds. The service can be used to provide autocomplete functionality for text-based geographic searches, by returning places such as businesses, addresses and points of interest as a user types.
<div class="note">Note: You can use Place Autocomplete even without a map. If you do show a map, it must be a Google map. When you display predictions from the Place Autocomplete service without a map, you must include the ['Powered by Google'](https://developers.google.com/maps/documentation/places/web-service/policies#logo_requirementshttps://developers.google.com/maps/documentation/places/web-service/policies#logo_requirements) logo.</div>

The Place Autocomplete service can match on full words and substrings, resolving place names, addresses, and plus codes. Applications can therefore send queries as the user types, to provide on-the-fly place predictions.

The returned predictions are designed to be presented to the user to aid them in selecting the desired place. You can send a [Place Details](https://developers.google.com/maps/documentation/places/web-service/details#PlaceDetailsRequests) request for more information about any of the places which are returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacesApi.Autocomplete(new AutocompleteRequest
    {
        Input = "some example string",
        Radius = 1000d,
        Components = "country:us|country:pr",
        Offset = 3d,
        Origin = "40,-110",
        Location = "40,-110",
        Locationbias = "ipbias",
        Locationrestriction = "circle:1000@37.781157,-122.398720",
    });
    // TODO: Handle 'response' of type PlacesAutocompleteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AutocompleteRequest](src/GoogleMapsPlatform/Requests/PlacesApi/AutocompleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlacesAutocompleteResponse](src/GoogleMapsPlatform/Models/PlacesAutocompleteResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlacesFindPlaceFromTextResponse&gt; FindPlaceFromText(FindPlaceFromTextRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A Find Place request takes a text input and returns a place. The input can be any kind of Places text data, such as a name, address, or phone number. The request must be a string. A Find Place request using non-string data such as a lat/lng coordinate or plus code generates an error.
<div class="note">Note: If you omit the fields parameter from a Find Place request, only the place_id for the result will be returned.</div>

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacesApi.FindPlaceFromText(new FindPlaceFromTextRequest
    {
        Input = "Museum of Contemporary Art Australia",
        Inputtype = Inputtype1.Textquery,
        Fields = ["formatted_address"],
        Locationbias = "ipbias",
    });
    // TODO: Handle 'response' of type PlacesFindPlaceFromTextResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FindPlaceFromTextRequest](src/GoogleMapsPlatform/Requests/PlacesApi/FindPlaceFromTextRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlacesFindPlaceFromTextResponse](src/GoogleMapsPlatform/Models/PlacesFindPlaceFromTextResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlacesTextSearchResponse&gt; NearbySearch(NearbySearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A Nearby Search lets you search for places within a specified area. You can refine your search request by supplying keywords or specifying the type of place you are searching for.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacesApi.NearbySearch(new NearbySearchRequest
    {
        Location = "40,-110",
        Radius = 1000d,
    });
    // TODO: Handle 'response' of type PlacesTextSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NearbySearchRequest](src/GoogleMapsPlatform/Requests/PlacesApi/NearbySearchRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlacesTextSearchResponse](src/GoogleMapsPlatform/Models/PlacesTextSearchResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlacesDetailsResponse&gt; PlaceDetails(PlaceDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Places API is a service that returns information about places using HTTP requests. Places are defined within this API as establishments, geographic locations, or prominent points of interest.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacesApi.PlaceDetails(new PlaceDetailsRequest
    {
        PlaceId = "ChIJN1t_tDeuEmsRUsoyG83frY4",
        Fields = ["formatted_address"],
    });
    // TODO: Handle 'response' of type PlacesDetailsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PlaceDetailsRequest](src/GoogleMapsPlatform/Requests/PlacesApi/PlaceDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlacesDetailsResponse](src/GoogleMapsPlatform/Models/PlacesDetailsResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PlacePhoto(PlacePhotoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Place Photo service, part of the Places API, is a read- only API that allows you to add high quality photographic content to your application. The Place Photo service gives you access to the millions of photos stored in the Places database. When you get place information using a Place Details request, photo references will be returned for relevant photographic content. Find Place, Nearby Search, and Text Search requests also return a single photo reference per place, when relevant. Using the Photo service you can then access the referenced photos and resize the image to the optimal size for your application.

Photos returned by the Photo service are sourced from a variety of locations, including business owners and user contributed photos. In most cases, these photos can be used without attribution, or will have the required attribution included as a part of the image. However, if the returned photo element includes a value in the html_attributions field, you will have to include the additional attribution in your application wherever you display the image.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PlacesApi.PlacePhoto(new PlacePhotoRequest { PhotoReference = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PlacePhotoRequest](src/GoogleMapsPlatform/Requests/PlacesApi/PlacePhotoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlacesQueryAutocompleteResponse&gt; QueryAutocomplete(QueryAutocompleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Query Autocomplete service can be used to provide a query prediction for text-based geographic searches, by returning suggested queries as you type.

The Query Autocomplete service allows you to add on-the-fly geographic query predictions to your application. Instead of searching for a specific location, a user can type in a categorical search, such as "pizza near New York" and the service responds with a list of suggested queries matching the string. As the Query Autocomplete service can match on both full words and substrings, applications can send queries as the user types to provide on-the-fly predictions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacesApi.QueryAutocomplete(new QueryAutocompleteRequest
    {
        Input = "some example string",
        Radius = 1000d,
        Offset = 3d,
        Location = "40,-110",
    });
    // TODO: Handle 'response' of type PlacesQueryAutocompleteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[QueryAutocompleteRequest](src/GoogleMapsPlatform/Requests/PlacesApi/QueryAutocompleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlacesQueryAutocompleteResponse](src/GoogleMapsPlatform/Models/PlacesQueryAutocompleteResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlacesTextSearchResponse&gt; TextSearch(TextSearchRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Google Places API Text Search Service is a web service that returns information about a set of places based on a string — for example "pizza in New York" or "shoe stores near Ottawa" or "123 Main Street". The service responds with a list of places matching the text string and any location bias that has been set.

The service is especially useful for making [ambiguous address](https://developers.google.com/maps/documentation/geocoding/best-practices) queries in an automated system, and non-address components of the string may match businesses as well as addresses. Examples of ambiguous address queries are incomplete addresses, poorly formatted addresses, or a request that includes non-address components such as business names.

The search response will include a list of places. You can send a Place Details request for more information about any of the places in the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacesApi.TextSearch(new TextSearchRequest
    {
        Query = "restaurants in Sydney",
        Radius = 1000d,
        Location = "40,-110",
    });
    // TODO: Handle 'response' of type PlacesTextSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TextSearchRequest](src/GoogleMapsPlatform/Requests/PlacesApi/TextSearchRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlacesTextSearchResponse](src/GoogleMapsPlatform/Models/PlacesTextSearchResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RoadsApi

> Source: [RoadsApi](src/GoogleMapsPlatform/Api/RoadsApi.cs)

<details>
<summary><code>Task&lt;NearestRoadsResponse&gt; NearestRoads(NearestRoadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This service returns individual road segments for a given set of GPS coordinates. This services takes up to 100 GPS points and returns the closest road segments for each point. The points passed do not need to be part of a continuous path.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoadsApi.NearestRoads(new NearestRoadsRequest
    {
        Points = ["60.170880,24.942795", "60.170879,24.942796", "60.170877,24.942796"],
    });
    // TODO: Handle 'response' of type NearestRoadsResponse
}
catch (ApiException<NearestRoadsApiError> ex)
{
    if (ex.Error.TryGetNearestRoadsErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type NearestRoadsErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NearestRoadsRequest](src/GoogleMapsPlatform/Requests/RoadsApi/NearestRoadsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NearestRoadsResponse](src/GoogleMapsPlatform/Models/NearestRoadsResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[NearestRoadsApiError](src/GoogleMapsPlatform/Errors/NearestRoadsApiError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SnapToRoadsResponse&gt; SnapToRoads(SnapToRoadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This service returns the best-fit road geometry for a given set of GPS coordinates. This service takes up to 100 GPS points collected along a route, and returns a similar set of data with the points snapped to the most likely roads the vehicle was traveling along. Optionally, you can request that the points be interpolated, resulting in a path that smoothly follows the geometry of the road.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoadsApi.SnapToRoads(new SnapToRoadsRequest
    {
        Path = ["60.170880,24.942795", "60.170879,24.942796", "60.170877,24.942796"],
        Interpolate = true,
    });
    // TODO: Handle 'response' of type SnapToRoadsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SnapToRoadsRequest](src/GoogleMapsPlatform/Requests/RoadsApi/SnapToRoadsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SnapToRoadsResponse](src/GoogleMapsPlatform/Models/SnapToRoadsResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## StreetViewApi

> Source: [StreetViewApi](src/GoogleMapsPlatform/Api/StreetViewApi.cs)

<details>
<summary><code>Task StreetView(StreetViewRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Street View Static API lets you embed a static (non-interactive) Street View panorama or thumbnail into your web page, without the use of JavaScript. The viewport is defined with URL parameters sent through a standard HTTP request, and is returned as a static image.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.StreetViewApi.StreetView(new StreetViewRequest { Size = "some example string", Location = "40,-110" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StreetViewRequest](src/GoogleMapsPlatform/Requests/StreetViewApi/StreetViewRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StreetViewResponse&gt; StreetViewMetadata(StreetViewMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Street View Static API metadata requests provide data about Street View panoramas. Using the metadata, you can find out if a Street View image is available at a given location, as well as getting programmatic access to the latitude and longitude, the panorama ID, the date the photo was taken, and the copyright information for the image. Accessing this metadata allows you to customize error behavior in your application.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StreetViewApi.StreetViewMetadata(new StreetViewMetadataRequest
    {
        Location = "40,-110",
    });
    // TODO: Handle 'response' of type StreetViewResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StreetViewMetadataRequest](src/GoogleMapsPlatform/Requests/StreetViewApi/StreetViewMetadataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StreetViewResponse](src/GoogleMapsPlatform/Models/StreetViewResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TimeZoneApi

> Source: [TimeZoneApi](src/GoogleMapsPlatform/Api/TimeZoneApi.cs)

<details>
<summary><code>Task&lt;TimeZoneResponse&gt; Timezone(TimezoneRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The Time Zone API provides a simple interface to request the time zone for locations on the surface of the earth, as well as the time offset from UTC for each of those locations. You request the time zone information for a specific latitude/longitude pair and date. The API returns the name of that time zone, the time offset from UTC, and the daylight savings offset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TimeZoneApi.Timezone(new TimezoneRequest
    {
        Location = "39.6034810,-119.6822510",
        Timestamp = 1331161200d,
    });
    // TODO: Handle 'response' of type TimeZoneResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TimezoneRequest](src/GoogleMapsPlatform/Requests/TimeZoneApi/TimezoneRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TimeZoneResponse](src/GoogleMapsPlatform/Models/TimeZoneResponse.cs)</code>

**OnError**: <code>[ApiException](src/GoogleMapsPlatform/Core/Exceptions/ApiException.cs)&lt;[RawError](src/GoogleMapsPlatform/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

