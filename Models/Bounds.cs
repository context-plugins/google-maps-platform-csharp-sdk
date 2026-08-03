using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// A rectangle in geographical coordinates from points at the southwest and northeast corners.
/// </summary>
public record Bounds
{
    [JsonPropertyName("northeast")]
    public required Northeast Northeast { get; init; }

    [JsonPropertyName("southwest")]
    public required Southwest Southwest { get; init; }
}
