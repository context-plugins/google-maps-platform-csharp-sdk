using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record DirectionsLeg
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrival_time")]
    public ArrivalTime? ArrivalTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departure_time")]
    public DepartureTime? DepartureTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public Distance? Distance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public Duration? Duration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration_in_traffic")]
    public DurationInTraffic? DurationInTraffic { get; init; }

    /// <summary>
    /// Contains the human-readable address (typically a street address) from reverse geocoding the <c>end_location</c> of this leg. This content is meant to be read as-is. Do not programmatically parse the formatted address.
    /// </summary>
    [JsonPropertyName("end_address")]
    public required string EndAddress { get; init; }

    [JsonPropertyName("end_location")]
    public required EndLocation EndLocation { get; init; }

    /// <summary>
    /// Contains the human-readable address (typically a street address) resulting from reverse geocoding the <c>start_location</c> of this leg. This content is meant to be read as-is. Do not programmatically parse the formatted address.
    /// </summary>
    [JsonPropertyName("start_address")]
    public required string StartAddress { get; init; }

    [JsonPropertyName("start_location")]
    public required StartLocation StartLocation { get; init; }

    /// <summary>
    /// An array of steps denoting information about each separate step of the leg of the journey.
    /// </summary>
    [JsonPropertyName("steps")]
    public required IReadOnlyList<DirectionsStep> Steps { get; init; }

    /// <summary>
    /// Information about traffic speed along the leg.
    /// </summary>
    [JsonPropertyName("traffic_speed_entry")]
    public required IReadOnlyList<DirectionsTrafficSpeedEntry> TrafficSpeedEntry { get; init; }

    /// <summary>
    /// The locations of via waypoints along this leg.
    /// </summary>
    [JsonPropertyName("via_waypoint")]
    public required IReadOnlyList<DirectionsViaWaypoint> ViaWaypoint { get; init; }
}
