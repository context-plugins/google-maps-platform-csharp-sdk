using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record DirectionsViaWaypoint
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Location? Location { get; init; }

    /// <summary>
    /// The index of the step containing the waypoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("step_index")]
    public int? StepIndex { get; init; }

    /// <summary>
    /// The position of the waypoint along the step's polyline, expressed as a ratio from 0 to 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("step_interpolation")]
    public double? StepInterpolation { get; init; }
}
