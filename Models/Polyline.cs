using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record Polyline
{
    /// <summary>
    /// A single string representation of the polyline.
    /// </summary>
    [JsonPropertyName("points")]
    public required string Points { get; init; }
}
