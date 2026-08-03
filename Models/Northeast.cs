using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record Northeast
{
    /// <summary>
    /// Latitude in decimal degrees
    /// </summary>
    [JsonPropertyName("lat")]
    public required double Lat { get; init; }

    /// <summary>
    /// Longitude in decimal degrees
    /// </summary>
    [JsonPropertyName("lng")]
    public required double Lng { get; init; }
}
