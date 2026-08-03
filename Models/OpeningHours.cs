using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record OpeningHours
{
    /// <summary>
    /// A boolean value indicating if the place is open at the current time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("open_now")]
    public bool? OpenNow { get; init; }

    /// <summary>
    /// An array of opening periods covering seven days, starting from Sunday, in chronological order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periods")]
    public IReadOnlyList<PlaceOpeningHoursPeriod>? Periods { get; init; }

    /// <summary>
    /// An array of up to seven entries corresponding to the next seven days.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("special_days")]
    public IReadOnlyList<PlaceSpecialDay>? SpecialDays { get; init; }

    /// <summary>
    /// A type string used to identify the type of secondary hours (for example, <c>DRIVE_THROUGH</c>, <c>HAPPY_HOUR</c>, <c>DELIVERY</c>, <c>TAKEOUT</c>, <c>KITCHEN</c>, <c>BREAKFAST</c>, <c>LUNCH</c>, <c>DINNER</c>, <c>BRUNCH</c>, <c>PICKUP</c>, <c>SENIOR_HOURS</c>). Set for <c>secondary_opening_hours</c> only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// An array of strings describing in human-readable text the hours of the place.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weekday_text")]
    public IReadOnlyList<string>? WeekdayText { get; init; }
}
