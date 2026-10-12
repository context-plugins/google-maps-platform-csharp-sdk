using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An object containing a numeric value and its formatted text representation.
/// </summary>
public record TextValueObject
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
