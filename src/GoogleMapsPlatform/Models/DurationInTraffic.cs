using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record DurationInTraffic
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
