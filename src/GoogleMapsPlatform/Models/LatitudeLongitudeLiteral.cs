using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An object describing a specific location with Latitude and Longitude in decimal degrees.
/// </summary>
public record LatitudeLongitudeLiteral
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
