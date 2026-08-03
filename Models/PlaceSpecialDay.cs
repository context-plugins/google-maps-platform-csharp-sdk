using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record PlaceSpecialDay
{
    /// <summary>
    /// A date expressed in RFC3339 format in the local timezone for the place, for example 2010-12-31.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public string? Date { get; init; }

    /// <summary>
    /// True if there are exceptional hours for this day. If <c>true</c>, this means that there is at least one exception for this day. Exceptions cause different values to occur in the subfields of <c>current_opening_hours</c> and <c>secondary_opening_hours</c> such as <c>periods</c>, <c>weekday_text</c>, <c>open_now</c>. The exceptions apply to the hours, and the hours are used to generate the other fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exceptional_hours")]
    public bool? ExceptionalHours { get; init; }
}
