using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record GeolocationV1Geolocate404Error
{
    [JsonPropertyName("error")]
    public required ErrorObject Error { get; init; }
}
