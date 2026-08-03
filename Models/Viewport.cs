using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record Viewport
{
    [JsonPropertyName("northeast")]
    public required Northeast Northeast { get; init; }

    [JsonPropertyName("southwest")]
    public required Southwest Southwest { get; init; }
}
