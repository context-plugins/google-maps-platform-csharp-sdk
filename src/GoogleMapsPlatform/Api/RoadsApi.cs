using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Exceptions;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Core.Request;
using GoogleMapsPlatform.Core.Response;
using GoogleMapsPlatform.Errors;
using GoogleMapsPlatform.Models;
using GoogleMapsPlatform.Requests.RoadsApi;

namespace GoogleMapsPlatform.Api;

public sealed class RoadsApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RoadsApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// nearestRoads
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NearestRoadsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="NearestRoadsApiError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This service returns individual road segments for a given set of GPS coordinates. This services takes up to 100 GPS points and returns the closest road segments for each point. The points passed do not need to be part of a continuous path.
    /// </remarks>
    public Task<NearestRoadsResponse> NearestRoads(NearestRoadsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/nearestRoads"),
            [],
            [new Param("points", request.Points)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NearestRoadsResponse>(),
            NearestRoadsApiError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// snapToRoads
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SnapToRoadsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This service returns the best-fit road geometry for a given set of GPS coordinates. This service takes up to 100 GPS points collected along a route, and returns a similar set of data with the points snapped to the most likely roads the vehicle was traveling along. Optionally, you can request that the points be interpolated, resulting in a path that smoothly follows the geometry of the road.
    /// </remarks>
    public Task<SnapToRoadsResponse> SnapToRoads(SnapToRoadsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v1/snaptoroads"),
            [],
            [new Param("path", request.Path), new Param("interpolate", request.Interpolate)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SnapToRoadsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
