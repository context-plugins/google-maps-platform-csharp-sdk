using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An object describing the location.
/// </summary>
public record GeocodingGeometry
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bounds")]
    public Bounds1? Bounds { get; init; }

    [JsonPropertyName("viewport")]
    public required Viewport Viewport { get; init; }
}
