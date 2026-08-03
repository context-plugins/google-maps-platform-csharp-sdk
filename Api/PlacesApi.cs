using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Exceptions;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Core.Request;
using GoogleMapsPlatform.Core.Response;
using GoogleMapsPlatform.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Api;

public sealed class PlacesApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PlacesApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// autocomplete
    /// </summary>
    /// <param name="input">The text string on which to search. The Place Autocomplete service will return candidate matches based on this string and order results based on their perceived relevance.</param>
    /// <param name="radius">Defines the distance (in meters) within which to return place results. You may bias results to a specified circle by passing a <c>location</c> and a <c>radius</c> parameter. Doing so instructs the Places service to _prefer_ showing results within that circle; results outside of the defined area may still be displayed.  The radius will automatically be clamped to a maximum value depending on the type of search and other parameters.  * Autocomplete: 50,000 meters * Nearby Search:    * with <c>keyword</c> or <c>name</c>: 50,000 meters   * without <c>keyword</c> or <c>name</c>     * Up to 50,000 meters, adjusted dynamically based on area density, independent of <c>rankby</c> parameter.     * When using <c>rankby=distance</c>, the radius parameter will not be accepted, and will result in an <c>INVALID_REQUEST</c>. * Query Autocomplete: 50,000 meters * Text Search: 50,000 meters</param>
    /// <param name="sessiontoken">A random string which identifies an autocomplete <see href="https://developers.google.com/maps/documentation/places/web-service/details#session_tokens">session</see> for billing purposes.  The session begins when the user starts typing a query, and concludes when they select a place and a call to Place Details is made. Each session can have multiple queries, followed by one place selection. The API key(s) used for each request within a session must belong to the same Google Cloud Console project. Once a session has concluded, the token is no longer valid; your app must generate a fresh token for each session. If the <c>sessiontoken</c> parameter is omitted, or if you reuse a session token, the session is charged as if no session token was provided (each request is billed separately).  We recommend the following guidelines:  - Use session tokens for all autocomplete sessions. - Generate a fresh token for each session. Using a version 4 UUID is recommended. - Ensure that the API key(s) used for all Place Autocomplete and Place Details requests within a session belong to the same Cloud Console project. - Be sure to pass a unique session token for each new session. Using the same token for more than one session will result in each request being billed individually.</param>
    /// <param name="components">A grouping of places to which you would like to restrict your results. Currently, you can use components to filter by up to 5 countries. Countries must be passed as a two character, ISO 3166-1 Alpha-2 compatible country code. For example: <c>components=country:fr</c> would restrict your results to places within France. Multiple countries must be passed as multiple <c>country:XX</c> filters, with the pipe character <c>|</c> as a separator. For example: <c>components=country:us|country:pr|country:vi|country:gu|country:mp</c> would restrict your results to places within the United States and its unincorporated organized territories. &lt;div class="note"&gt;&lt;strong&gt;Note:&lt;/strong&gt; If you receive unexpected results with a country code, verify that you are using a code which includes the countries, dependent territories, and special areas of geographical interest you intend.  You can find code information at &lt;a href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes" target="blank" class="external"&gt;Wikipedia: List of ISO 3166 country codes&lt;/a&gt; or the &lt;a href="https://www.iso.org/obp/ui/#search" target="blank" class="external"&gt;ISO Online Browsing Platform&lt;/a&gt;.&lt;/div&gt;</param>
    /// <param name="strictbounds">Returns only those places that are strictly within the region defined by <c>location</c> and <c>radius</c>. This is a restriction, rather than a bias, meaning that results outside this region will not be returned even if they match the user input.</param>
    /// <param name="offset">The position, in the input term, of the last character that the service uses to match predictions. For example, if the input is <c>Google</c> and the offset is 3, the service will match on <c>Goo</c>. The string determined by the offset is matched against the first word in the input term only. For example, if the input term is <c>Google abc</c> and the offset is 3, the service will attempt to match against <c>Goo abc</c>. If no offset is supplied, the service will use the whole term. The offset should generally be set to the position of the text caret.</param>
    /// <param name="origin">The origin point from which to calculate straight-line distance to the destination (returned as <c>distance_meters</c>). If this value is omitted, straight-line distance will not be returned. Must be specified as <c>latitude,longitude</c>.</param>
    /// <param name="location">The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>. The <c>radius</c> parameter must also be provided when specifying a location. If <c>radius</c> is not provided, the <c>location</c> parameter is ignored.  &lt;div class="note"&gt;When using the Text Search API, the <c>location</c> parameter may be overriden if the <c>query</c> contains an explicit location such as <c>Market in Barcelona</c>.&lt;/div&gt;</param>
    /// <param name="locationbias">Prefer results in a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs representing the points of a rectangle. If this parameter is not specified, the API uses IP address biasing by default. - IP bias: Instructs the API to use IP address biasing. Pass the string <c>ipbias</c> (this option has no additional parameters). - Circular: A string specifying radius in meters, plus lat/lng in decimal degrees. Use the following format: <c>circle:radiuslat,lng</c>. - Rectangular: A string specifying two lat/lng pairs in decimal degrees, representing the south/west and north/east points of a rectangle. Use the following format:<c>rectangle:south,west|north,east</c>. Note that east/west values are wrapped to the range -180, 180, and north/south values are clamped to the range -90, 90.</param>
    /// <param name="locationrestriction">Restrict results to a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs representing the points of a rectangle. - Circular: A string specifying radius in meters, plus lat/lng in decimal degrees. Use the following format: <c>circle:radiuslat,lng</c>. - Rectangular: A string specifying two lat/lng pairs in decimal degrees, representing the south/west and north/east points of a rectangle. Use the following format:<c>rectangle:south,west|north,east</c>. Note that east/west values are wrapped to the range -180, 180, and north/south values are clamped to the range -90, 90.</param>
    /// <param name="types">You can restrict results from a Place Autocomplete request to be of a certain type by passing the <c>types</c> parameter. This parameter specifies a type or a type collection, as listed in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">Place Types</see>. If nothing is specified, all types are returned.  For the value of the <c>types</c> parameter you can specify either: * Up to five values from <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table1">Table 1</see> or <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table2">Table 2</see>. For multiple values, separate each value with a <c>|</c> (vertical bar). For example:    <c>types=book_store|cafe</c>  * Any supported filter in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table3">Table 3</see>. You can safely mix the <c>geocode</c> and <c>establishment</c> types. You cannot mix type collections (<c>address</c>, <c>(cities)</c> or <c>(regions)</c>) with any other type, or an error occurs.  The request will be rejected with an <c>INVALID_REQUEST</c> error if:  * More than five types are specified. * Any unrecognized types are present. * Any types from in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table1">Table 1</see> or <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table2">Table 2</see> are mixed with any of the filters in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table3">Table 3</see>.</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="region">The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesAutocompleteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Place Autocomplete service is a web service that returns place predictions in response to an HTTP request. The request specifies a textual search string and optional geographic bounds. The service can be used to provide autocomplete functionality for text-based geographic searches, by returning places such as businesses, addresses and points of interest as a user types.
    /// &lt;div class="note"&gt;Note: You can use Place Autocomplete even without a map. If you do show a map, it must be a Google map. When you display predictions from the Place Autocomplete service without a map, you must include the <see href="https://developers.google.com/maps/documentation/places/web-service/policies#logo_requirementshttps://developers.google.com/maps/documentation/places/web-service/policies#logo_requirements">'Powered by Google'</see> logo.&lt;/div&gt;
    /// <para>
    /// The Place Autocomplete service can match on full words and substrings, resolving place names, addresses, and plus codes. Applications can therefore send queries as the user types, to provide on-the-fly place predictions.
    /// </para>
    /// <para>
    /// The returned predictions are designed to be presented to the user to aid them in selecting the desired place. You can send a <see href="https://developers.google.com/maps/documentation/places/web-service/details#PlaceDetailsRequests">Place Details</see> request for more information about any of the places which are returned.
    /// </para>
    /// </remarks>
    public Task<PlacesAutocompleteResponse> Autocomplete(string input,
        double radius,
        string? sessiontoken,
        string? components,
        bool? strictbounds,
        double? offset,
        string? origin,
        string? location,
        string? locationbias,
        string? locationrestriction,
        string? types,
        Language1? language,
        Region1? region,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/autocomplete/json"),
            [],
            [new Param("input", input),
                new Param("radius", radius),
                new Param("sessiontoken", sessiontoken),
                new Param("components", components),
                new Param("strictbounds", strictbounds),
                new Param("offset", offset),
                new Param("origin", origin),
                new Param("location", location),
                new Param("locationbias", locationbias),
                new Param("locationrestriction", locationrestriction),
                new Param("types", types),
                new Param("language", language),
                new Param("region", region)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesAutocompleteResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// findPlaceFromText
    /// </summary>
    /// <param name="input">The text string on which to search, for example: "restaurant" or "123 Main Street". This must be a place name, address, or category of establishments. Any other types of input can generate errors and are not guaranteed to return valid results. The Places API will return candidate matches based on this string and order the results based on their perceived relevance.</param>
    /// <param name="inputtype">The type of input. This can be one of either <c>textquery</c> or <c>phonenumber</c>. Phone numbers must be in international format (prefixed by a plus sign ("+"), followed by the country code, then the phone number itself). See <see href="https://en.wikipedia.org/wiki/E.164">E.164 ITU recommendation</see> for more information.</param>
    /// <param name="fields">&lt;div class="caution"&gt; Caution: Place Search requests and Place Details requests do not return the same fields. Place Search requests return a subset of the fields that are returned by Place Details requests. If the field you want is not returned by Place Search, you can use Place Search to get a &lt;code&gt;place_id&lt;/code&gt;, then use that Place ID to make a Place Details request. For more information on the fields that are unavailable in a Place Search request, see &lt;a href="https://developers.google.com/maps/documentation/places/web-service/place-data-fields#places-api-fields-support"&gt;Places API fields support&lt;/a&gt;.&lt;/div&gt;  Use the fields parameter to specify a comma-separated list of place data types to return. For example: <c>fields=formatted_address,name,geometry</c>. Use a forward slash when specifying compound values. For example: <c>opening_hours/open_now</c>.  Fields are divided into three billing categories: Basic, Contact, and Atmosphere. Basic fields are billed at base rate, and incur no additional charges. Contact and Atmosphere fields are billed at a higher rate. See the <see href="https://developers.google.com/maps/documentation/places/web-service/usage-and-billing/">pricing sheet</see> for more information. Attributions, <c>html_attributions</c>, are always returned with every call, regardless of whether the field has been requested.  <b>Basic</b>  The Basic category includes the following fields: <c>address_components</c>, <c>adr_address</c>, <c>business_status</c>, <c>formatted_address</c>, <c>geometry</c>, <c>icon</c>, <c>icon_mask_base_uri</c>, <c>icon_background_color</c>, <c>name</c>, <c>permanently_closed</c> (<see href="https://developers.google.com/maps/deprecations">deprecated</see>), <c>photo</c>, <c>place_id</c>, <c>plus_code</c>, <c>type</c>, <c>url</c>, <c>utc_offset</c>, <c>vicinity</c>, <c>wheelchair_accessible_entrance</c>.  <b>Contact</b>  The Contact category includes the following fields: <c>current_opening_hours</c>, <c>formatted_phone_number</c>, <c>international_phone_number</c>, <c>opening_hours</c>, <c>secondary_opening_hours</c>, <c>website</c>  <b>Atmosphere</b>  The Atmosphere category includes the following fields: <c>curbside_pickup</c>, <c>delivery</c>, <c>dine_in</c>, <c>editorial_summary</c>, <c>price_level</c>, <c>rating</c>, <c>reservable</c>, <c>reviews</c>, <c>serves_beer</c>, <c>serves_breakfast</c>, <c>serves_brunch</c>, <c>serves_dinner</c>, <c>serves_lunch</c>, <c>serves_vegetarian_food</c>, <c>serves_wine</c>, <c>takeout</c>, <c>user_ratings_total</c>.</param>
    /// <param name="locationbias">Prefer results in a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs representing the points of a rectangle. If this parameter is not specified, the API uses IP address biasing by default. - IP bias: Instructs the API to use IP address biasing. Pass the string <c>ipbias</c> (this option has no additional parameters). - Circular: A string specifying radius in meters, plus lat/lng in decimal degrees. Use the following format: <c>circle:radiuslat,lng</c>. - Rectangular: A string specifying two lat/lng pairs in decimal degrees, representing the south/west and north/east points of a rectangle. Use the following format:<c>rectangle:south,west|north,east</c>. Note that east/west values are wrapped to the range -180, 180, and north/south values are clamped to the range -90, 90.</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesFindPlaceFromTextResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A Find Place request takes a text input and returns a place. The input can be any kind of Places text data, such as a name, address, or phone number. The request must be a string. A Find Place request using non-string data such as a lat/lng coordinate or plus code generates an error.
    /// &lt;div class="note"&gt;Note: If you omit the fields parameter from a Find Place request, only the place_id for the result will be returned.&lt;/div&gt;
    /// </remarks>
    public Task<PlacesFindPlaceFromTextResponse> FindPlaceFromText(string input,
        Inputtype1 inputtype,
        IReadOnlyList<string>? fields,
        string? locationbias,
        Language1? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/findplacefromtext/json"),
            [],
            [new Param("input", input),
                new Param("inputtype", inputtype),
                new Param("fields", fields),
                new Param("locationbias", locationbias),
                new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesFindPlaceFromTextResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// nearbySearch
    /// </summary>
    /// <param name="location">The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>.</param>
    /// <param name="radius">Defines the distance (in meters) within which to return place results. You may bias results to a specified circle by passing a <c>location</c> and a <c>radius</c> parameter. Doing so instructs the Places service to _prefer_ showing results within that circle; results outside of the defined area may still be displayed.  The radius will automatically be clamped to a maximum value depending on the type of search and other parameters.  * Autocomplete: 50,000 meters * Nearby Search:    * with <c>keyword</c> or <c>name</c>: 50,000 meters   * without <c>keyword</c> or <c>name</c>     * Up to 50,000 meters, adjusted dynamically based on area density, independent of <c>rankby</c> parameter.     * When using <c>rankby=distance</c>, the radius parameter will not be accepted, and will result in an <c>INVALID_REQUEST</c>. * Query Autocomplete: 50,000 meters * Text Search: 50,000 meters</param>
    /// <param name="keyword">The text string on which to search, for example: "restaurant" or "123 Main Street". This must be a place name, address, or category of establishments. Any other types of input can generate errors and are not guaranteed to return valid results. The Google Places service will return candidate matches based on this string and order the results based on their perceived relevance.  Explicitly including location information using this parameter may conflict with the location, radius, and rankby parameters, causing unexpected results.  If this parameter is omitted, places with a business_status of CLOSED_TEMPORARILY or CLOSED_PERMANENTLY will not be returned.</param>
    /// <param name="maxprice">Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.</param>
    /// <param name="minprice">Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.</param>
    /// <param name="name">Equivalent to <c>keyword</c>. Values in this field are combined with values in the <c>keyword</c> field and passed as part of the same search string.</param>
    /// <param name="opennow">Returns only those places that are open for business at the time the query is sent. Places that do not specify opening hours in the Google Places database will not be returned if you include this parameter in your query.</param>
    /// <param name="pagetoken">Returns up to 20 results from a previously run search. Setting a <c>pagetoken</c> parameter will execute a search with the same parameters used previously — all parameters other than pagetoken will be ignored.</param>
    /// <param name="rankby">Specifies the order in which results are listed. Possible values are: - <c>prominence</c> (default). This option sorts results based on their importance. Ranking will favor prominent places within the set radius over nearby places that match but that are less prominent. Prominence can be affected by a place's ranking in Google's index, global popularity, and other factors. When prominence is specified, the <c>radius</c> parameter is required. - <c>distance</c>. This option biases search results in ascending order by their distance from the specified location. When <c>distance</c> is specified, one or more of <c>keyword</c>, <c>name</c>, or <c>type</c> is required and <c>radius</c> is disallowed.</param>
    /// <param name="type">Restricts the results to places matching the specified type. Only one type may be specified. If more than one type is provided, all types following the first entry are ignored.  * <c>type=hospital|pharmacy|doctor</c> becomes <c>type=hospital</c> * <c>type=hospital,pharmacy,doctor</c> is ignored entirely  See the list of <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">supported types</see>. &lt;div class="note"&gt;Note: Adding both <c>keyword</c> and <c>type</c> with the same value (<c>keyword=cafe&amp;type=cafe</c> or <c>keyword=parking&amp;type=parking</c>) can yield <c>ZERO_RESULTS</c>.&lt;/div&gt;</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesTextSearchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A Nearby Search lets you search for places within a specified area. You can refine your search request by supplying keywords or specifying the type of place you are searching for.
    /// </remarks>
    public Task<PlacesTextSearchResponse> NearbySearch(string location,
        double radius,
        string? keyword,
        Maxprice1? maxprice,
        Minprice1? minprice,
        string? name,
        bool? opennow,
        string? pagetoken,
        Rankby1? rankby,
        string? type,
        Language1? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/nearbysearch/json"),
            [],
            [new Param("location", location),
                new Param("radius", radius),
                new Param("keyword", keyword),
                new Param("maxprice", maxprice),
                new Param("minprice", minprice),
                new Param("name", name),
                new Param("opennow", opennow),
                new Param("pagetoken", pagetoken),
                new Param("rankby", rankby),
                new Param("type", type),
                new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesTextSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// placeDetails
    /// </summary>
    /// <param name="placeId">A textual identifier that uniquely identifies a place, returned from a <see href="https://developers.google.com/maps/documentation/places/web-service/search">Place Search</see>. For more information about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">place ID overview</see>.</param>
    /// <param name="fields">&lt;div class="caution"&gt; Caution: Place Search requests and Place Details requests do not return the same fields. Place Search requests return a subset of the fields that are returned by Place Details requests. If the field you want is not returned by Place Search, you can use Place Search to get a &lt;code&gt;place_id&lt;/code&gt;, then use that Place ID to make a Place Details request. For more information on the fields that are unavailable in a Place Search request, see &lt;a href="https://developers.google.com/maps/documentation/places/web-service/place-data-fields#places-api-fields-support"&gt;Places API fields support&lt;/a&gt;.&lt;/div&gt;  Use the fields parameter to specify a comma-separated list of place data types to return. For example: <c>fields=formatted_address,name,geometry</c>. Use a forward slash when specifying compound values. For example: <c>opening_hours/open_now</c>.  Fields are divided into three billing categories: Basic, Contact, and Atmosphere. Basic fields are billed at base rate, and incur no additional charges. Contact and Atmosphere fields are billed at a higher rate. See the <see href="https://developers.google.com/maps/documentation/places/web-service/usage-and-billing/">pricing sheet</see> for more information. Attributions, <c>html_attributions</c>, are always returned with every call, regardless of whether the field has been requested.  <b>Basic</b>  The Basic category includes the following fields: <c>address_components</c>, <c>adr_address</c>, <c>business_status</c>, <c>formatted_address</c>, <c>geometry</c>, <c>icon</c>, <c>icon_mask_base_uri</c>, <c>icon_background_color</c>, <c>name</c>, <c>permanently_closed</c> (<see href="https://developers.google.com/maps/deprecations">deprecated</see>), <c>photo</c>, <c>place_id</c>, <c>plus_code</c>, <c>type</c>, <c>url</c>, <c>utc_offset</c>, <c>vicinity</c>, <c>wheelchair_accessible_entrance</c>.  <b>Contact</b>  The Contact category includes the following fields: <c>current_opening_hours</c>, <c>formatted_phone_number</c>, <c>international_phone_number</c>, <c>opening_hours</c>, <c>secondary_opening_hours</c>, <c>website</c>  <b>Atmosphere</b>  The Atmosphere category includes the following fields: <c>curbside_pickup</c>, <c>delivery</c>, <c>dine_in</c>, <c>editorial_summary</c>, <c>price_level</c>, <c>rating</c>, <c>reservable</c>, <c>reviews</c>, <c>serves_beer</c>, <c>serves_breakfast</c>, <c>serves_brunch</c>, <c>serves_dinner</c>, <c>serves_lunch</c>, <c>serves_vegetarian_food</c>, <c>serves_wine</c>, <c>takeout</c>, <c>user_ratings_total</c>.</param>
    /// <param name="sessiontoken">A random string which identifies an autocomplete <see href="https://developers.google.com/maps/documentation/places/web-service/details#session_tokens">session</see> for billing purposes.  The session begins when the user starts typing a query, and concludes when they select a place and a call to Place Details is made. Each session can have multiple queries, followed by one place selection. The API key(s) used for each request within a session must belong to the same Google Cloud Console project. Once a session has concluded, the token is no longer valid; your app must generate a fresh token for each session. If the <c>sessiontoken</c> parameter is omitted, or if you reuse a session token, the session is charged as if no session token was provided (each request is billed separately).  We recommend the following guidelines:  - Use session tokens for all autocomplete sessions. - Generate a fresh token for each session. Using a version 4 UUID is recommended. - Ensure that the API key(s) used for all Place Autocomplete and Place Details requests within a session belong to the same Cloud Console project. - Be sure to pass a unique session token for each new session. Using the same token for more than one session will result in each request being billed individually.</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="region">The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").</param>
    /// <param name="reviewsSort">The sorting method to use when returning reviews. Can be set to <c>most_relevant</c> (default) or <c>newest</c>.  - For <c>most_relevant</c> (default), reviews are sorted by relevance; the service will bias the results to return reviews originally written in the preferred language. - For <c>newest</c>, reviews are sorted in chronological order; the preferred language does not affect the sort order.  Google recommends that you display how the reviews are being sorted to the end user.</param>
    /// <param name="reviewsNoTranslations">Specify <c>reviews_no_translations=true</c> to disable translation of reviews; specify <c>reviews_no_translations=false</c> to enable translation of reviews. Reviews are returned in their original language.  If omitted, or passed with no value, translation of reviews is enabled. If the <c>language</c> parameter was specified in the request, use the specified language as the preferred language for translation. If <c>language</c> is omitted, the API attempts to use the <c>Accept-Language</c> header as the preferred language.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesDetailsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Places API is a service that returns information about places using HTTP requests. Places are defined within this API as establishments, geographic locations, or prominent points of interest.
    /// </remarks>
    public Task<PlacesDetailsResponse> PlaceDetails(string placeId,
        IReadOnlyList<string>? fields,
        string? sessiontoken,
        Language1? language,
        Region1? region,
        string? reviewsSort,
        bool? reviewsNoTranslations,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/details/json"),
            [],
            [new Param("place_id", placeId),
                new Param("fields", fields),
                new Param("sessiontoken", sessiontoken),
                new Param("language", language),
                new Param("region", region),
                new Param("reviews_sort", reviewsSort),
                new Param("reviews_no_translations", reviewsNoTranslations)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesDetailsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// placePhoto
    /// </summary>
    /// <param name="photoReference">A string identifier that uniquely identifies a photo. Photo references are returned from either a Place Search or Place Details request.</param>
    /// <param name="maxheight">Specifies the maximum desired height, in pixels, of the image. If the image is smaller than the values specified, the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the two dimensions, restricted to its original aspect ratio. Both the <c>maxheight</c> and <c>maxwidth</c> properties accept an integer between <c>1</c> and <c>1600</c>.</param>
    /// <param name="maxwidth">Specifies the maximum desired width, in pixels, of the image. If the image is smaller than the values specified, the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the two dimensions, restricted to its original aspect ratio. Both the <c>maxheight</c> and <c>maxwidth</c> properties accept an integer between <c>1</c> and <c>1600</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Place Photo service, part of the Places API, is a read- only API that allows you to add high quality photographic content to your application. The Place Photo service gives you access to the millions of photos stored in the Places database. When you get place information using a Place Details request, photo references will be returned for relevant photographic content. Find Place, Nearby Search, and Text Search requests also return a single photo reference per place, when relevant. Using the Photo service you can then access the referenced photos and resize the image to the optimal size for your application.
    /// <para>
    /// Photos returned by the Photo service are sourced from a variety of locations, including business owners and user contributed photos. In most cases, these photos can be used without attribution, or will have the required attribution included as a part of the image. However, if the returned photo element includes a value in the html_attributions field, you will have to include the additional attribution in your application wherever you display the image.
    /// </para>
    /// </remarks>
    public Task PlacePhoto(string photoReference,
        double? maxheight,
        double? maxwidth,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/photo"),
            [],
            [new Param("photo_reference", photoReference),
                new Param("maxheight", maxheight),
                new Param("maxwidth", maxwidth)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// queryAutocomplete
    /// </summary>
    /// <param name="input">The text string on which to search. The Place Autocomplete service will return candidate matches based on this string and order results based on their perceived relevance.</param>
    /// <param name="radius">Defines the distance (in meters) within which to return place results. You may bias results to a specified circle by passing a <c>location</c> and a <c>radius</c> parameter. Doing so instructs the Places service to _prefer_ showing results within that circle; results outside of the defined area may still be displayed.  The radius will automatically be clamped to a maximum value depending on the type of search and other parameters.  * Autocomplete: 50,000 meters * Nearby Search:    * with <c>keyword</c> or <c>name</c>: 50,000 meters   * without <c>keyword</c> or <c>name</c>     * Up to 50,000 meters, adjusted dynamically based on area density, independent of <c>rankby</c> parameter.     * When using <c>rankby=distance</c>, the radius parameter will not be accepted, and will result in an <c>INVALID_REQUEST</c>. * Query Autocomplete: 50,000 meters * Text Search: 50,000 meters</param>
    /// <param name="offset">The position, in the input term, of the last character that the service uses to match predictions. For example, if the input is <c>Google</c> and the offset is 3, the service will match on <c>Goo</c>. The string determined by the offset is matched against the first word in the input term only. For example, if the input term is <c>Google abc</c> and the offset is 3, the service will attempt to match against <c>Goo abc</c>. If no offset is supplied, the service will use the whole term. The offset should generally be set to the position of the text caret.</param>
    /// <param name="location">The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>.   &lt;div class="note"&gt;The &lt;code&gt;location&lt;/code&gt; parameter may be overriden if the &lt;code&gt;query&lt;/code&gt; contains an explicit location such as &lt;code&gt;Market in Barcelona&lt;/code&gt;. Using quotes around the query may also influence the weight given to the &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt;.&lt;/div&gt;</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesQueryAutocompleteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Query Autocomplete service can be used to provide a query prediction for text-based geographic searches, by returning suggested queries as you type.
    /// <para>
    /// The Query Autocomplete service allows you to add on-the-fly geographic query predictions to your application. Instead of searching for a specific location, a user can type in a categorical search, such as "pizza near New York" and the service responds with a list of suggested queries matching the string. As the Query Autocomplete service can match on both full words and substrings, applications can send queries as the user types to provide on-the-fly predictions.
    /// </para>
    /// </remarks>
    public Task<PlacesQueryAutocompleteResponse> QueryAutocomplete(string input,
        double radius,
        double? offset,
        string? location,
        Language1? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/queryautocomplete/json"),
            [],
            [new Param("input", input),
                new Param("radius", radius),
                new Param("offset", offset),
                new Param("location", location),
                new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesQueryAutocompleteResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// textSearch
    /// </summary>
    /// <param name="query">The text string on which to search, for example: "restaurant" or "123 Main Street". This must a place name, address, or category of establishments. Any other types of input can generate errors and are not guaranteed to return valid results. The Google Places service will return candidate matches based on this string and order the results based on their perceived relevance.</param>
    /// <param name="radius">Defines the distance (in meters) within which to return place results. You may bias results to a specified circle by passing a <c>location</c> and a <c>radius</c> parameter. Doing so instructs the Places service to _prefer_ showing results within that circle; results outside of the defined area may still be displayed.  The radius will automatically be clamped to a maximum value depending on the type of search and other parameters.  * Autocomplete: 50,000 meters * Nearby Search:    * with <c>keyword</c> or <c>name</c>: 50,000 meters   * without <c>keyword</c> or <c>name</c>     * Up to 50,000 meters, adjusted dynamically based on area density, independent of <c>rankby</c> parameter.     * When using <c>rankby=distance</c>, the radius parameter will not be accepted, and will result in an <c>INVALID_REQUEST</c>. * Query Autocomplete: 50,000 meters * Text Search: 50,000 meters</param>
    /// <param name="location">The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>.   &lt;div class="note"&gt;The &lt;code&gt;location&lt;/code&gt; parameter may be overriden if the &lt;code&gt;query&lt;/code&gt; contains an explicit location such as &lt;code&gt;Market in Barcelona&lt;/code&gt;. Using quotes around the query may also influence the weight given to the &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt;.&lt;/div&gt;</param>
    /// <param name="maxprice">Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.</param>
    /// <param name="minprice">Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.</param>
    /// <param name="opennow">Returns only those places that are open for business at the time the query is sent. Places that do not specify opening hours in the Google Places database will not be returned if you include this parameter in your query.</param>
    /// <param name="pagetoken">Returns up to 20 results from a previously run search. Setting a <c>pagetoken</c> parameter will execute a search with the same parameters used previously — all parameters other than pagetoken will be ignored.</param>
    /// <param name="type">Restricts the results to places matching the specified type. Only one type may be specified. If more than one type is provided, all types following the first entry are ignored.  * <c>type=hospital|pharmacy|doctor</c> becomes <c>type=hospital</c> * <c>type=hospital,pharmacy,doctor</c> is ignored entirely  See the list of <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">supported types</see>. &lt;div class="note"&gt;Note: Adding both <c>keyword</c> and <c>type</c> with the same value (<c>keyword=cafe&amp;type=cafe</c> or <c>keyword=parking&amp;type=parking</c>) can yield <c>ZERO_RESULTS</c>.&lt;/div&gt;</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="region">The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesTextSearchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Google Places API Text Search Service is a web service that returns information about a set of places based on a string — for example "pizza in New York" or "shoe stores near Ottawa" or "123 Main Street". The service responds with a list of places matching the text string and any location bias that has been set.
    /// <para>
    /// The service is especially useful for making <see href="https://developers.google.com/maps/documentation/geocoding/best-practices">ambiguous address</see> queries in an automated system, and non-address components of the string may match businesses as well as addresses. Examples of ambiguous address queries are incomplete addresses, poorly formatted addresses, or a request that includes non-address components such as business names.
    /// </para>
    /// <para>
    /// The search response will include a list of places. You can send a Place Details request for more information about any of the places in the response.
    /// </para>
    /// </remarks>
    public Task<PlacesTextSearchResponse> TextSearch(string query,
        double radius,
        string? location,
        Maxprice1? maxprice,
        Minprice1? minprice,
        bool? opennow,
        string? pagetoken,
        string? type,
        Language1? language,
        Region1? region,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/place/textsearch/json"),
            [],
            [new Param("query", query),
                new Param("radius", radius),
                new Param("location", location),
                new Param("maxprice", maxprice),
                new Param("minprice", minprice),
                new Param("opennow", opennow),
                new Param("pagetoken", pagetoken),
                new Param("type", type),
                new Param("language", language),
                new Param("region", region)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesTextSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
