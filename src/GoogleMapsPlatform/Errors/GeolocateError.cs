using System.Threading.Tasks;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models;

namespace GoogleMapsPlatform.Errors;

public sealed class GeolocateError : ApiError
{
    private readonly Optional<GeolocationV1Geolocate400Error1> _geolocationV1Geolocate400Error1Value;

    private readonly Optional<GeolocationV1Geolocate404Error1> _geolocationV1Geolocate404Error1Value;

    private GeolocateError(Optional<GeolocationV1Geolocate400Error1> geolocationV1Geolocate400Error1Value,
        Optional<GeolocationV1Geolocate404Error1> geolocationV1Geolocate404Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _geolocationV1Geolocate400Error1Value = geolocationV1Geolocate400Error1Value;
        _geolocationV1Geolocate404Error1Value = geolocationV1Geolocate404Error1Value;
    }

    private static GeolocateError AsGeolocationV1Geolocate400Error1(GeolocationV1Geolocate400Error1 value) =>
        new(Optional<GeolocationV1Geolocate400Error1>.Some(value), default, default);

    private static GeolocateError AsGeolocationV1Geolocate404Error1(GeolocationV1Geolocate404Error1 value) =>
        new(default, Optional<GeolocationV1Geolocate404Error1>.Some(value), default);

    private static GeolocateError AsFallback(RawError value) => new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGeolocationV1Geolocate400Error1(out GeolocationV1Geolocate400Error1 value) =>
        _geolocationV1Geolocate400Error1Value.TryGetValue(out value);

    public bool TryGetGeolocationV1Geolocate404Error1(out GeolocationV1Geolocate404Error1 value) =>
        _geolocationV1Geolocate404Error1Value.TryGetValue(out value);

    private static Task<GeolocateError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<GeolocationV1Geolocate400Error1>().As(AsGeolocationV1Geolocate400Error1),
            404 => response.Json<GeolocationV1Geolocate404Error1>().As(AsGeolocationV1Geolocate404Error1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GeolocateError> Response { get; } = new(Create);
}
