using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record Geometry1
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bounds")]
    public Bounds1? Bounds { get; init; }

    [JsonPropertyName("viewport")]
    public required Viewport Viewport { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
