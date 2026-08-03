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
    /// <param name="locations">Positional requests are indicated through use of the locations parameter, indicating elevation requests for the specific locations passed as latitude/longitude values.  The locations parameter may take the following arguments:  - A single coordinate: <c>locations=40.714728,-73.998672</c> - An array of coordinates separated using the pipe ('|') character:    ```   locations=40.714728,-73.998672|-34.397,150.644   ``` - A set of encoded coordinates using the <see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm">Encoded Polyline Algorithm</see>:    ```   locations=enc:gfo}EtohhU   ```  Latitude and longitude coordinate strings are defined using numerals within a comma-separated text string. For example, "40.714728,-73.998672" is a valid locations value. Latitude and longitude values must correspond to a valid location on the face of the earth. Latitudes can take any value between -90 and 90 while longitude values can take any value between -180 and 180. If you specify an invalid latitude or longitude value, your request will be rejected as a bad request.  You may pass any number of multiple coordinates within an array or encoded polyline, while still constructing a valid URL. Note that when passing multiple coordinates, the accuracy of any returned data may be of lower resolution than when requesting data for a single coordinate.</param>
    /// <param name="path">An array of comma separated <c>latitude,longitude</c> strings.</param>
    /// <param name="samples">Required if path parameter is set.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MapsApiElevationJsonResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Elevation API provides a simple interface to query locations on the earth for elevation data. Additionally, you may request sampled elevation data along paths, allowing you to calculate elevation changes along routes. With the Elevation API, you can develop hiking and biking applications, positioning applications, or low resolution surveying applications.
    /// <para>
    /// Elevation data is available for all locations on the surface of the earth, including depth locations on the ocean floor (which return negative values). In those cases where Google does not possess exact elevation measurements at the precise location you request, the service interpolates and returns an averaged value using the four nearest locations. Elevation values are expressed relative to local mean sea level (LMSL).
    /// </para>
    /// <para>
    /// Requests to the Elevation API utilize different parameters based on whether the request is for discrete locations or for an ordered path. For discrete locations, requests for elevation return data on the specific locations passed in the request; for paths, elevation requests are instead sampled along the given path.
    /// </para>
    /// </remarks>
    public Task<MapsApiElevationJsonResponse> Elevation(IReadOnlyList<string>? locations,
        IReadOnlyList<string>? path,
        double? samples,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/elevation/json"),
            [],
            [new Param("locations", locations), new Param("path", path), new Param("samples", samples)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MapsApiElevationJsonResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
