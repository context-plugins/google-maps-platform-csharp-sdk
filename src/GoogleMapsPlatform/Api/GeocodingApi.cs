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
using GoogleMapsPlatform.Requests.GeocodingApi;

namespace GoogleMapsPlatform.Api;

public sealed class GeocodingApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GeocodingApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// geocode
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeocodingResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Geocoding API is a service that provides geocoding and reverse geocoding of addresses.
    /// <para>
    /// <b>Geocoding</b> is the process of converting addresses (like a street address) into geographic coordinates (like latitude and longitude), which you can use to place markers on a map, or position the map.
    /// </para>
    /// <para>
    /// <b>Reverse geocoding</b> is the process of converting geographic coordinates into a human-readable address.
    /// </para>
    /// <para>
    /// You can also use the Geocoding API to find the address for a given place ID.
    /// </para>
    /// <para>
    /// To see countries currently supported by the Google Maps Platform Geocoding API, please consult the <see href="https://developers.google.com/maps/coverage">Google Maps coverage data</see>. The accuracy of geocoded locations may vary per country, so you should consider using the returned <c>location_type</c> field to determine if a good enough match has been found for the purposes of your application. Please note that the availability of geocoding data depends on our contracts with data providers, so it is subject to change.
    /// </para>
    /// </remarks>
    public Task<GeocodingResponse> Geocode(GeocodeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/geocode/json"),
            [],
            [
                new Param("address", request.Address),
                new Param("bounds", request.Bounds),
                new Param("components", request.Components),
                new Param("latlng", request.Latlng),
                new Param("location_type", request.LocationType),
                new Param("place_id", request.PlaceId),
                new Param("result_type", request.ResultType),
                new Param("language", request.Language),
                new Param("region", request.Region),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GeocodingResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
