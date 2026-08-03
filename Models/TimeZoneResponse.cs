using System.Text.Json.Serialization;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record TimeZoneResponse
{
    /// <summary>
    /// The offset for daylight-savings time in seconds. This will be zero if the time zone is not in Daylight Savings Time during the specified <c>timestamp</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dstOffset")]
    public double? DstOffset { get; init; }

    /// <summary>
    /// The offset from UTC (in seconds) for the given location. This does not take into effect daylight savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rawOffset")]
    public double? RawOffset { get; init; }

    /// <summary>
    /// a string containing the ID of the time zone, such as "America/Los_Angeles" or "Australia/Sydney". These IDs are defined by <see href="http://cldr.unicode.org/">Unicode Common Locale Data Repository (CLDR) project</see>, and currently available in file timezone.xml. When a timezone has several IDs, the canonical one is returned. In xml responses, this is the first alias of each timezone. For example, "Asia/Calcutta" is returned, not "Asia/Kolkata".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeZoneId")]
    public string? TimeZoneId { get; init; }

    /// <summary>
    /// The long form name of the time zone. This field will be localized if the language parameter is set. eg. <c>Pacific Daylight Time</c> or <c>Australian Eastern Daylight Time</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeZoneName")]
    public string? TimeZoneName { get; init; }

    [JsonPropertyName("status")]
    public required TimeZoneStatus Status { get; init; }

    /// <summary>
    /// Detailed information about the reasons behind the given status code. Included if status other than <c>Ok</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }
}
