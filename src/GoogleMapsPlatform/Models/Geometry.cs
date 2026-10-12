using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An object describing the location.
/// </summary>
public record Geometry
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    [JsonPropertyName("viewport")]
    public required Viewport Viewport { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
