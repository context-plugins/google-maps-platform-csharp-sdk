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
using GoogleMapsPlatform.Requests.DirectionsApi;

namespace GoogleMapsPlatform.Api;

public sealed class DirectionsApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DirectionsApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// directions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DirectionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Directions API is a web service that uses an HTTP request to return JSON or XML-formatted directions between locations. You can receive directions for several modes of transportation, such as transit, driving, walking, or cycling.
    /// </remarks>
    public Task<DirectionsResponse> Directions(DirectionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/directions/json"),
            [],
            [
                new Param("destination", request.Destination),
                new Param("origin", request.Origin),
                new Param("arrival_time", request.ArrivalTime),
                new Param("departure_time", request.DepartureTime),
                new Param("alternatives", request.Alternatives),
                new Param("avoid", request.Avoid),
                new Param("units", request.Units),
                new Param("waypoints", request.Waypoints),
                new Param("language", request.Language),
                new Param("mode", request.Mode),
                new Param("region", request.Region),
                new Param("traffic_model", request.TrafficModel),
                new Param("transit_mode", request.TransitMode),
                new Param("transit_routing_preference", request.TransitRoutingPreference),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DirectionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
