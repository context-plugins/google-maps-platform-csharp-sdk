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
    /// <param name="location">A comma-separated latitude,longitude tuple, <c>location=39.6034810,-119.6822510</c>, representing the location to look up.</param>
    /// <param name="timestamp">The desired time as seconds since midnight, January 1, 1970 UTC. The Time Zone API uses the <c>timestamp</c> to determine whether or not Daylight Savings should be applied, based on the time zone of the <c>location</c>.   Note that the API does not take historical time zones into account. That is, if you specify a past timestamp, the API does not take into account the possibility that the location was previously in a different time zone.</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TimeZoneResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Time Zone API provides a simple interface to request the time zone for locations on the surface of the earth, as well as the time offset from UTC for each of those locations. You request the time zone information for a specific latitude/longitude pair and date. The API returns the name of that time zone, the time offset from UTC, and the daylight savings offset.
    /// </remarks>
    public Task<TimeZoneResponse> Timezone(string location,
        double timestamp,
        Language1? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/timezone/json"),
            [],
            [new Param("location", location), new Param("timestamp", timestamp), new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TimeZoneResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
