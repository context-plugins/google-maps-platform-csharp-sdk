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
using GoogleMapsPlatform.Requests.ElevationApi;

namespace GoogleMapsPlatform.Api;

public sealed class ElevationApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ElevationApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// elevation
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MapsApiElevationJsonResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Elevation API provides a simple interface to query locations on the earth for elevation data. Additionally, you may request sampled elevation data along paths, allowing you to calculate elevation changes along routes. With the Elevation API, you can develop hiking and biking applications, positioning applications, or low resolution surveying applications.
    /// <para>
    /// Elevation data is available for all locations on the surface of the earth, including depth locations on the ocean floor (which return negative values). In those cases where Google does not possess exact elevation measurements at the precise location you request, the service interpolates and returns an averaged value using the four nearest locations. Elevation values are expressed relative to local mean sea level (LMSL).
    /// </para>
    /// <para>
    /// Requests to the Elevation API utilize different parameters based on whether the request is for discrete locations or for an ordered path. For discrete locations, requests for elevation return data on the specific locations passed in the request; for paths, elevation requests are instead sampled along the given path.
    /// </para>
    /// </remarks>
    public Task<MapsApiElevationJsonResponse> Elevation(ElevationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/elevation/json"),
            [],
            [
                new Param("locations", request.Locations),
                new Param("path", request.Path),
                new Param("samples", request.Samples),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MapsApiElevationJsonResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
