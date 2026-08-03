using System.Net.Http;
using GoogleMapsPlatform.Api;
using GoogleMapsPlatform.Core;
using GoogleMapsPlatform.Core.Logging;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform;

/// <summary>
/// API Specification for Google Maps Platform
/// </summary>
public sealed class GoogleMapsPlatformClient
{
    public GoogleMapsPlatformClient(HttpClient httpClient, GoogleMapsPlatformClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "GoogleMapsPlatformClient/1.22.5 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.22.5"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "GoogleMapsPlatformClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        var auth = new AuthSchemes(options);
        DirectionsApi = new DirectionsApi(rawClient, server, auth);
        DistanceMatrixApi = new DistanceMatrixApi(rawClient, server, auth);
        ElevationApi = new ElevationApi(rawClient, server, auth);
        GeocodingApi = new GeocodingApi(rawClient, server, auth);
        GeolocationApi = new GeolocationApi(rawClient, server, auth);
        PlacesApi = new PlacesApi(rawClient, server, auth);
        RoadsApi = new RoadsApi(rawClient, server, auth);
        StreetViewApi = new StreetViewApi(rawClient, server, auth);
        TimeZoneApi = new TimeZoneApi(rawClient, server, auth);
    }

    public DirectionsApi DirectionsApi { get; }

    public DistanceMatrixApi DistanceMatrixApi { get; }

    public ElevationApi ElevationApi { get; }

    public GeocodingApi GeocodingApi { get; }

    public GeolocationApi GeolocationApi { get; }

    public PlacesApi PlacesApi { get; }

    public RoadsApi RoadsApi { get; }

    public StreetViewApi StreetViewApi { get; }

    public TimeZoneApi TimeZoneApi { get; }
}
