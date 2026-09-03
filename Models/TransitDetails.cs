using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record TransitDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrival_stop")]
    public DirectionsTransitStop? ArrivalStop { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arrival_time")]
    public ArrivalTime? ArrivalTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departure_stop")]
    public DirectionsTransitStop? DepartureStop { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("departure_time")]
    public DepartureTime? DepartureTime { get; init; }

    /// <summary>
    /// Specifies the direction in which to travel on this line, as it is marked on the vehicle or at the departure stop. This will often be the terminus station.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headsign")]
    public string? Headsign { get; init; }

    /// <summary>
    /// Specifies the expected number of seconds between departures from the same stop at this time. For example, with a <c>headway</c> value of 600, you would expect a ten minute wait if you should miss your bus.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headway")]
    public int? Headway { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line")]
    public DirectionsTransitLine? Line { get; init; }

    /// <summary>
    /// The number of stops from the departure to the arrival stop. This includes the arrival stop, but not the departure stop. For example, if your directions involve leaving from Stop A, passing through stops B and C, and arriving at stop D, <c>num_stops</c> will return 3.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_stops")]
    public int? NumStops { get; init; }

    /// <summary>
    /// The text that appears in schedules and sign boards to identify a transit trip to passengers. The text should uniquely identify a trip within a service day. For example, "538" is the <c>trip_short_name</c> of the Amtrak train that leaves San Jose, CA at 15:10 on weekdays to Sacramento, CA.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trip_short_name")]
    public string? TripShortName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
