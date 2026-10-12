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
using GoogleMapsPlatform.Requests.DistanceMatrixApi;

namespace GoogleMapsPlatform.Api;

public sealed class DistanceMatrixApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DistanceMatrixApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// distanceMatrix
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DistanceMatrixResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Distance Matrix API is a service that provides travel distance and time for a matrix of origins and destinations. The API returns information based on the recommended route between start and end points, as calculated by the Google Maps API, and consists of rows containing duration and distance values for each pair.
    /// </remarks>
    public Task<DistanceMatrixResponse> DistanceMatrix(DistanceMatrixRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/distancematrix/json"),
            [],
            [
                new Param("destinations", request.Destinations),
                new Param("origins", request.Origins),
                new Param("arrival_time", request.ArrivalTime),
                new Param("departure_time", request.DepartureTime),
                new Param("avoid", request.Avoid),
                new Param("units", request.Units),
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
            JsonResponse.Create<DistanceMatrixResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
