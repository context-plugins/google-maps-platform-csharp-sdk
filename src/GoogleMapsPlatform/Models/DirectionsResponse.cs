using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record DirectionsResponse
{
    /// <summary>
    /// Contains an array with details about the geocoding of origin, destination and waypoints. Elements in the geocoded_waypoints array correspond, by their zero-based position, to the origin, the waypoints in the order they are specified, and the destination.
    /// <para>
    /// These details will not be present for waypoints specified as textual latitude/longitude values if the service returns no results. This is because such waypoints are only reverse geocoded to obtain their representative address after a route has been found. An empty JSON object will occupy the corresponding places in the geocoded_waypoints array.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geocoded_waypoints")]
    public IReadOnlyList<DirectionsGeocodedWaypoint>? GeocodedWaypoints { get; init; }

    /// <summary>
    /// Contains an array of routes from the origin to the destination. Routes consist of nested Legs and Steps.
    /// </summary>
    [JsonPropertyName("routes")]
    public required IReadOnlyList<DirectionsRoute> Routes { get; init; }

    [JsonPropertyName("status")]
    public required DirectionsStatus Status { get; init; }

    /// <summary>
    /// Contains an array of available travel modes. This field is returned when a request specifies a travel mode and gets no results. The array contains the available travel modes in the countries of the given set of waypoints. This field is not returned if one or more of the waypoints are 'via waypoints'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_travel_modes")]
    public IReadOnlyList<TravelMode>? AvailableTravelModes { get; init; }

    /// <summary>
    /// When the service returns a status code other than <c>OK</c>, there may be an additional <c>error_message</c> field within the response object. This field contains more detailed information about the reasons behind the given status code. This field is not always returned, and its content is subject to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
