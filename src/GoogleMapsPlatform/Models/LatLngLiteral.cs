using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An object describing a specific location with Latitude and Longitude in decimal degrees.
/// </summary>
public record LatLngLiteral
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
