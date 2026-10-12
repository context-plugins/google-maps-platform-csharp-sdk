using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// A review of the place submitted by a user.
/// </summary>
public record PlaceReview
{
    /// <summary>
    /// The name of the user who submitted the review. Anonymous reviews are attributed to "A Google user".
    /// </summary>
    [JsonPropertyName("author_name")]
    public required string AuthorName { get; init; }

    /// <summary>
    /// The URL to the user's Google Maps Local Guides profile, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("author_url")]
    public string? AuthorUrl { get; init; }

    /// <summary>
    /// The URL to the user's profile photo, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile_photo_url")]
    public string? ProfilePhotoUrl { get; init; }

    /// <summary>
    /// An IETF language code indicating the language of the returned review.
    /// This field contains the main language tag only, and not the secondary tag indicating country or region. For example, all the English reviews are tagged as 'en', and not 'en-AU' or 'en-UK' and so on.
    /// This field is empty if there is only a rating with no review text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// An IETF language code indicating the original language of the review. If the review has been translated, then <c>original_language</c> != <c>language</c>.
    /// This field contains the main language tag only, and not the secondary tag indicating country or region. For example, all the English reviews are tagged as 'en', and not 'en-AU' or 'en-UK' and so on.
    /// This field is empty if there is only a rating with no review text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; init; }

    /// <summary>
    /// The user's overall rating for this place. This is a whole number, ranging from 1 to 5.
    /// </summary>
    [JsonPropertyName("rating")]
    public required double Rating { get; init; }

    /// <summary>
    /// The time that the review was submitted in text, relative to the current time.
    /// </summary>
    [JsonPropertyName("relative_time_description")]
    public required string RelativeTimeDescription { get; init; }

    /// <summary>
    /// The user's review. When reviewing a location with Google Places, text reviews are considered optional. Therefore, this field may be empty. Note that this field may include simple HTML markup. For example, the entity reference <c>&amp;amp;</c> may represent an ampersand character.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    /// <summary>
    /// The time that the review was submitted, measured in the number of seconds since since midnight, January 1, 1970 UTC.
    /// </summary>
    [JsonPropertyName("time")]
    public required double Time { get; init; }

    /// <summary>
    /// A boolean value indicating if the review was translated from the original language it was written in.
    /// If a review has been translated, corresponding to a value of true, Google recommends that you indicate this to your users. For example, you can add the following string, “Translated by Google”, to the review.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("translated")]
    public bool? Translated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
