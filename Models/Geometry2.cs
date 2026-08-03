using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record Geometry2
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    [JsonPropertyName("viewport")]
    public required Viewport Viewport { get; init; }
}
