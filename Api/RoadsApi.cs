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
using GoogleMapsPlatform.Errors;
using GoogleMapsPlatform.Models;

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
    /// <param name="points">The points to be snapped. The points parameter accepts a list of latitude/longitude pairs. Separate latitude and longitude values with commas. Separate coordinates with the pipe character: "|". For example: <c>points=60.170880,24.942795|60.170879,24.942796|60.170877,24.942796</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NearestRoadsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="NearestRoadsApiError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This service returns individual road segments for a given set of GPS coordinates. This services takes up to 100 GPS points and returns the closest road segments for each point. The points passed do not need to be part of a continuous path.
    /// </remarks>
    public Task<NearestRoadsResponse> NearestRoads(IReadOnlyList<string> points,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/nearestRoads"),
            [],
            [new Param("points", points)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NearestRoadsResponse>(),
            NearestRoadsApiErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// snapToRoads
    /// </summary>
    /// <param name="path">The path to be snapped. The path parameter accepts a list of latitude/longitude pairs. Latitude and longitude values should be separated by commas. Coordinates should be separated by the pipe character: "|". For example: <c>path=60.170880,24.942795|60.170879,24.942796|60.170877,24.942796</c>. &lt;div class="note"&gt;Note: The snapping algorithm works best for points that are not too far apart. If you observe odd snapping behavior, try creating paths that have points closer together. To ensure the best snap-to-road quality, you should aim to provide paths on which consecutive pairs of points are within 300m of each other. This will also help in handling any isolated, long jumps between consecutive points caused by GPS signal loss, or noise.&lt;/div&gt;</param>
    /// <param name="interpolate">Whether to interpolate a path to include all points forming the full road-geometry. When true, additional interpolated points will also be returned, resulting in a path that smoothly follows the geometry of the road, even around corners and through tunnels. Interpolated paths will most likely contain more points than the original path. Defaults to <c>false</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SnapToRoadsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This service returns the best-fit road geometry for a given set of GPS coordinates. This service takes up to 100 GPS points collected along a route, and returns a similar set of data with the points snapped to the most likely roads the vehicle was traveling along. Optionally, you can request that the points be interpolated, resulting in a path that smoothly follows the geometry of the road.
    /// </remarks>
    public Task<SnapToRoadsResponse> SnapToRoads(IReadOnlyList<string> path,
        bool? interpolate,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/snaptoroads"),
            [],
            [new Param("path", path), new Param("interpolate", interpolate)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SnapToRoadsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
