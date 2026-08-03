using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record DirectionsTrafficSpeedEntry
{
    /// <summary>
    /// The current traffic/speed conditions on this portion of a path.
    /// </summary>
    [JsonPropertyName("speed_category")]
    public required string SpeedCategory { get; init; }

    /// <summary>
    /// The offset along the path (in meters) up to which this speed category is valid.
    /// </summary>
    [JsonPropertyName("offset_meters")]
    public required double OffsetMeters { get; init; }
}
