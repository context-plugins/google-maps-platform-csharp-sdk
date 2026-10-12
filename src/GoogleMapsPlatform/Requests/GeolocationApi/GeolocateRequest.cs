using GoogleMapsPlatform.Models;

namespace GoogleMapsPlatform.Requests.GeolocationApi;

/// <summary>
/// The inputs of the Geolocate operation.
/// </summary>
public sealed record GeolocateRequest
{
    /// <summary>
    /// The request body must be formatted as JSON.
    /// </summary>
    public GeolocationV1GeolocateRequest? Body { get; init; }
}
