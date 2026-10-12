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
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public GoogleMapsPlatformClient(HttpClient httpClient, GoogleMapsPlatformClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "GoogleMapsPlatformClient/1.22.5 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "1.22.5"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "GoogleMapsPlatformClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public DirectionsApi DirectionsApi => field ??= new DirectionsApi(_rawClient, _server, _auth);

    public DistanceMatrixApi DistanceMatrixApi => field ??= new DistanceMatrixApi(_rawClient, _server, _auth);

    public ElevationApi ElevationApi => field ??= new ElevationApi(_rawClient, _server, _auth);

    public GeocodingApi GeocodingApi => field ??= new GeocodingApi(_rawClient, _server, _auth);

    public GeolocationApi GeolocationApi => field ??= new GeolocationApi(_rawClient, _server, _auth);

    public PlacesApi PlacesApi => field ??= new PlacesApi(_rawClient, _server, _auth);

    public RoadsApi RoadsApi => field ??= new RoadsApi(_rawClient, _server, _auth);

    public StreetViewApi StreetViewApi => field ??= new StreetViewApi(_rawClient, _server, _auth);

    public TimeZoneApi TimeZoneApi => field ??= new TimeZoneApi(_rawClient, _server, _auth);
}
