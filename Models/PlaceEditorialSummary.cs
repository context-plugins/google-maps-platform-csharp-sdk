using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// Contains a summary of the place. A summary is comprised of a textual overview, and also includes the language code for these if applicable. Summary text must be presented as-is and can not be modified or altered.
/// </summary>
public record PlaceEditorialSummary
{
    /// <summary>
    /// A medium-length textual summary of the place.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overview")]
    public string? Overview { get; init; }

    /// <summary>
    /// The language of the previous fields. May not always be present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }
}
