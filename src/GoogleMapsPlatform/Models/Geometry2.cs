using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record Geometry2
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    [JsonPropertyName("viewport")]
    public required Viewport Viewport { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
