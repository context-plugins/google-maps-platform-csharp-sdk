using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record EditorialSummary
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
