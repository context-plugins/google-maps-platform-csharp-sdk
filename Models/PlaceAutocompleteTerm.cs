using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record PlaceAutocompleteTerm
{
    /// <summary>
    /// The text of the term.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// Defines the start position of this term in the description, measured in Unicode characters
    /// </summary>
    [JsonPropertyName("offset")]
    public required double Offset { get; init; }
}
