using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record PlaceAutocompleteStructuredFormat
{
    /// <summary>
    /// Contains the main text of a prediction, usually the name of the place.
    /// </summary>
    [JsonPropertyName("main_text")]
    public required string MainText { get; init; }

    /// <summary>
    /// Contains an array with <c>offset</c> value and <c>length</c>. These describe the location of the entered term in the prediction result text, so that the term can be highlighted if desired.
    /// </summary>
    [JsonPropertyName("main_text_matched_substrings")]
    public required IReadOnlyList<PlaceAutocompleteMatchedSubstring> MainTextMatchedSubstrings { get; init; }

    /// <summary>
    /// Contains the secondary text of a prediction, usually the location of the place.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_text")]
    public string? SecondaryText { get; init; }

    /// <summary>
    /// Contains an array with <c>offset</c> value and <c>length</c>. These describe the location of the entered term in the prediction result text, so that the term can be highlighted if desired.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_text_matched_substrings")]
    public IReadOnlyList<PlaceAutocompleteMatchedSubstring>? SecondaryTextMatchedSubstrings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
