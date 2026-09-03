using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record Viewport
{
    [JsonPropertyName("northeast")]
    public required Northeast Northeast { get; init; }

    [JsonPropertyName("southwest")]
    public required Southwest Southwest { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
