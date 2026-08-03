using System.Net.Http;
using System.Threading;
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

    private static GeolocateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGeolocationV1Geolocate400Error1(out GeolocationV1Geolocate400Error1 value) =>
        _geolocationV1Geolocate400Error1Value.TryGetValue(out value);

    public bool TryGetGeolocationV1Geolocate404Error1(out GeolocationV1Geolocate404Error1 value) =>
        _geolocationV1Geolocate404Error1Value.TryGetValue(out value);

    internal static Task<GeolocateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GeolocationV1Geolocate400Error1>(response, ct).As(AsGeolocationV1Geolocate400Error1),
            404 => FromJson<GeolocationV1Geolocate404Error1>(response, ct).As(AsGeolocationV1Geolocate404Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GeolocateErrorResponse : IErrorResponse<GeolocateError>
{
    public static GeolocateErrorResponse Instance { get; } = new();

    private GeolocateErrorResponse()
    {
    }

    public Task<GeolocateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GeolocateError.Create(response, ct);
}
