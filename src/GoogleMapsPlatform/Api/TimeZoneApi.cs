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
using GoogleMapsPlatform.Requests.TimeZoneApi;

namespace GoogleMapsPlatform.Api;

public sealed class TimeZoneApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TimeZoneApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// timezone
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TimeZoneResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Time Zone API provides a simple interface to request the time zone for locations on the surface of the earth, as well as the time offset from UTC for each of those locations. You request the time zone information for a specific latitude/longitude pair and date. The API returns the name of that time zone, the time offset from UTC, and the daylight savings offset.
    /// </remarks>
    public Task<TimeZoneResponse> Timezone(TimezoneRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/timezone/json"),
            [],
            [
                new Param("location", request.Location),
                new Param("timestamp", request.Timestamp),
                new Param("language", request.Language),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TimeZoneResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
