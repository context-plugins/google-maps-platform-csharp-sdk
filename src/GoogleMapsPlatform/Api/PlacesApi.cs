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
using GoogleMapsPlatform.Requests.PlacesApi;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesAutocompleteResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
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
    public Task<PlacesAutocompleteResponse> Autocomplete(AutocompleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/autocomplete/json"),
            [],
            [
                new Param("input", request.Input),
                new Param("radius", request.Radius),
                new Param("sessiontoken", request.Sessiontoken),
                new Param("components", request.Components),
                new Param("strictbounds", request.Strictbounds),
                new Param("offset", request.Offset),
                new Param("origin", request.Origin),
                new Param("location", request.Location),
                new Param("locationbias", request.Locationbias),
                new Param("locationrestriction", request.Locationrestriction),
                new Param("types", request.Types),
                new Param("language", request.Language),
                new Param("region", request.Region),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesAutocompleteResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// findPlaceFromText
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesFindPlaceFromTextResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A Find Place request takes a text input and returns a place. The input can be any kind of Places text data, such as a name, address, or phone number. The request must be a string. A Find Place request using non-string data such as a lat/lng coordinate or plus code generates an error.
    /// &lt;div class="note"&gt;Note: If you omit the fields parameter from a Find Place request, only the place_id for the result will be returned.&lt;/div&gt;
    /// </remarks>
    public Task<PlacesFindPlaceFromTextResponse> FindPlaceFromText(FindPlaceFromTextRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/findplacefromtext/json"),
            [],
            [
                new Param("input", request.Input),
                new Param("inputtype", request.Inputtype),
                new Param("fields", request.Fields),
                new Param("locationbias", request.Locationbias),
                new Param("language", request.Language),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesFindPlaceFromTextResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// nearbySearch
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesTextSearchResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A Nearby Search lets you search for places within a specified area. You can refine your search request by supplying keywords or specifying the type of place you are searching for.
    /// </remarks>
    public Task<PlacesTextSearchResponse> NearbySearch(NearbySearchRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/nearbysearch/json"),
            [],
            [
                new Param("location", request.Location),
                new Param("radius", request.Radius),
                new Param("keyword", request.Keyword),
                new Param("maxprice", request.Maxprice),
                new Param("minprice", request.Minprice),
                new Param("name", request.Name),
                new Param("opennow", request.Opennow),
                new Param("pagetoken", request.Pagetoken),
                new Param("rankby", request.Rankby),
                new Param("type", request.Type),
                new Param("language", request.Language),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesTextSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// placeDetails
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesDetailsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Places API is a service that returns information about places using HTTP requests. Places are defined within this API as establishments, geographic locations, or prominent points of interest.
    /// </remarks>
    public Task<PlacesDetailsResponse> PlaceDetails(PlaceDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/details/json"),
            [],
            [
                new Param("place_id", request.PlaceId),
                new Param("fields", request.Fields),
                new Param("sessiontoken", request.Sessiontoken),
                new Param("language", request.Language),
                new Param("region", request.Region),
                new Param("reviews_sort", request.ReviewsSort),
                new Param("reviews_no_translations", request.ReviewsNoTranslations),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesDetailsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// placePhoto
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Place Photo service, part of the Places API, is a read- only API that allows you to add high quality photographic content to your application. The Place Photo service gives you access to the millions of photos stored in the Places database. When you get place information using a Place Details request, photo references will be returned for relevant photographic content. Find Place, Nearby Search, and Text Search requests also return a single photo reference per place, when relevant. Using the Photo service you can then access the referenced photos and resize the image to the optimal size for your application.
    /// <para>
    /// Photos returned by the Photo service are sourced from a variety of locations, including business owners and user contributed photos. In most cases, these photos can be used without attribution, or will have the required attribution included as a part of the image. However, if the returned photo element includes a value in the html_attributions field, you will have to include the additional attribution in your application wherever you display the image.
    /// </para>
    /// </remarks>
    public Task PlacePhoto(PlacePhotoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/photo"),
            [],
            [
                new Param("photo_reference", request.PhotoReference),
                new Param("maxheight", request.Maxheight),
                new Param("maxwidth", request.Maxwidth),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// queryAutocomplete
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesQueryAutocompleteResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Query Autocomplete service can be used to provide a query prediction for text-based geographic searches, by returning suggested queries as you type.
    /// <para>
    /// The Query Autocomplete service allows you to add on-the-fly geographic query predictions to your application. Instead of searching for a specific location, a user can type in a categorical search, such as "pizza near New York" and the service responds with a list of suggested queries matching the string. As the Query Autocomplete service can match on both full words and substrings, applications can send queries as the user types to provide on-the-fly predictions.
    /// </para>
    /// </remarks>
    public Task<PlacesQueryAutocompleteResponse> QueryAutocomplete(QueryAutocompleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/queryautocomplete/json"),
            [],
            [
                new Param("input", request.Input),
                new Param("radius", request.Radius),
                new Param("offset", request.Offset),
                new Param("location", request.Location),
                new Param("language", request.Language),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesQueryAutocompleteResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// textSearch
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PlacesTextSearchResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Google Places API Text Search Service is a web service that returns information about a set of places based on a string — for example "pizza in New York" or "shoe stores near Ottawa" or "123 Main Street". The service responds with a list of places matching the text string and any location bias that has been set.
    /// <para>
    /// The service is especially useful for making <see href="https://developers.google.com/maps/documentation/geocoding/best-practices">ambiguous address</see> queries in an automated system, and non-address components of the string may match businesses as well as addresses. Examples of ambiguous address queries are incomplete addresses, poorly formatted addresses, or a request that includes non-address components such as business names.
    /// </para>
    /// <para>
    /// The search response will include a list of places. You can send a Place Details request for more information about any of the places in the response.
    /// </para>
    /// </remarks>
    public Task<PlacesTextSearchResponse> TextSearch(TextSearchRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/place/textsearch/json"),
            [],
            [
                new Param("query", request.Query),
                new Param("radius", request.Radius),
                new Param("location", request.Location),
                new Param("maxprice", request.Maxprice),
                new Param("minprice", request.Minprice),
                new Param("opennow", request.Opennow),
                new Param("pagetoken", request.Pagetoken),
                new Param("type", request.Type),
                new Param("language", request.Language),
                new Param("region", request.Region),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PlacesTextSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
