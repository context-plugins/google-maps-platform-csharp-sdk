using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record Duration
{
    /// <summary>
    /// String value.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// Numeric value.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }
}
