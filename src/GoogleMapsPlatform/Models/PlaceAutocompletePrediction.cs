using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record PlaceAutocompletePrediction
{
    /// <summary>
    /// Contains the human-readable name for the returned result. For <c>establishment</c> results, this is usually the business name. This content is meant to be read as-is. Do not programmatically parse the formatted address.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// A list of substrings that describe the location of the entered term in the prediction result text, so that the term can be highlighted if desired.
    /// </summary>
    [JsonPropertyName("matched_substrings")]
    public required IReadOnlyList<PlaceAutocompleteMatchedSubstring> MatchedSubstrings { get; init; }

    /// <summary>
    /// A textual identifier that uniquely identifies a place. To retrieve information about the place, pass this identifier in the placeId field of a Places API request. For more information about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">Place IDs</see> overview.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("place_id")]
    public string? PlaceId { get; init; }

    /// <summary>
    /// See place_id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonPropertyName("structured_formatting")]
    public required PlaceAutocompleteStructuredFormat StructuredFormatting { get; init; }

    /// <summary>
    /// Contains an array of terms identifying each section of the returned description (a section of the description is generally terminated with a comma). Each entry in the array has a <c>value</c> field, containing the text of the term, and an <c>offset</c> field, defining the start position of this term in the description, measured in Unicode characters.
    /// </summary>
    [JsonPropertyName("terms")]
    public required IReadOnlyList<PlaceAutocompleteTerm> Terms { get; init; }

    /// <summary>
    /// Contains an array of types that apply to this place. For example: <c>[ "political", "locality" ]</c> or <c>[ "establishment", "geocode", "beauty_salon" ]</c>. The array can contain multiple values. Learn more about <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">Place types</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("types")]
    public IReadOnlyList<string>? Types { get; init; }

    /// <summary>
    /// The straight-line distance in meters from the origin. This field is only returned for requests made with an <c>origin</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance_meters")]
    public int? DistanceMeters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
