using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record PlaceOpeningHoursPeriodDetail
{
    /// <summary>
    /// A date expressed in RFC3339 format in the local timezone for the place, for example 2010-12-31.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public string? Date { get; init; }

    /// <summary>
    /// A number from 0–6, corresponding to the days of the week, starting on Sunday. For example, 2 means Tuesday.
    /// </summary>
    [JsonPropertyName("day")]
    public required double Day { get; init; }

    /// <summary>
    /// May contain a time of day in 24-hour hhmm format. Values are in the range 0000–2359. The time will be reported in the place’s time zone.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; init; }

    /// <summary>
    /// True if a given period was truncated due to a seven-day cutoff, where the period starts before midnight on the date of the request and/or ends at or after  midnight on the last day. This property indicates that the period for open or close can extend past this seven-day cutoff.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("truncated")]
    public bool? Truncated { get; init; }
}
