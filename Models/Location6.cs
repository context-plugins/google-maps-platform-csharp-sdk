using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record Location6
{
    /// <summary>
    /// Latitude in decimal degrees
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; init; }

    /// <summary>
    /// Longitude in decimal degrees
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; init; }
}
