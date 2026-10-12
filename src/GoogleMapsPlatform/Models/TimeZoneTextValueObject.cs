using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An object containing Unix time, a time zone, and its formatted text representation.
/// </summary>
public record TimeZoneTextValueObject
{
    /// <summary>
    /// The time specified as a string in the time zone.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// The time specified as Unix time, or seconds since midnight, January 1, 1970 UTC.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    /// <summary>
    /// Contains the time zone. The value is the name of the time zone as defined in the <see href="http://www.iana.org/time-zones">IANA Time Zone Database</see>, e.g. "America/New_York".
    /// </summary>
    [JsonPropertyName("time_zone")]
    public required string TimeZone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
