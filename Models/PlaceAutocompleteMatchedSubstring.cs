using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record PlaceAutocompleteMatchedSubstring
{
    /// <summary>
    /// Length of the matched substring in the prediction result text.
    /// </summary>
    [JsonPropertyName("length")]
    public required double Length { get; init; }

    /// <summary>
    /// Start location of the matched substring in the prediction result text.
    /// </summary>
    [JsonPropertyName("offset")]
    public required double Offset { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
