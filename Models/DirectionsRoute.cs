using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// Routes consist of nested <c>legs</c> and <c>steps</c>.
/// </summary>
public record DirectionsRoute
{
    /// <summary>
    /// An array which contains information about a leg of the route, between two locations within the given route. A separate leg will be present for each waypoint or destination specified. (A route with no waypoints will contain exactly one leg within the legs array.) Each leg consists of a series of steps.
    /// </summary>
    [JsonPropertyName("legs")]
    public required IReadOnlyList<DirectionsLeg> Legs { get; init; }

    [JsonPropertyName("bounds")]
    public required Bounds1 Bounds { get; init; }

    /// <summary>
    /// Contains the copyright notices to be displayed for this route. You must handle and display this information yourself. This content is meant to be read as-is. Do not programmatically parse this display-only content.
    /// </summary>
    [JsonPropertyName("copyrights")]
    public required string Copyrights { get; init; }

    /// <summary>
    /// Contains a short textual description for the route, suitable for naming and disambiguating the route from alternatives.
    /// </summary>
    [JsonPropertyName("summary")]
    public required string Summary { get; init; }

    /// <summary>
    /// An array indicating the order of any waypoints in the calculated route. This waypoints may be reordered if the request was passed optimize:true within its waypoints parameter.
    /// </summary>
    [JsonPropertyName("waypoint_order")]
    public required IReadOnlyList<int> WaypointOrder { get; init; }

    /// <summary>
    /// Contains an array of warnings to be displayed when showing these directions. You must handle and display these warnings yourself.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<string> Warnings { get; init; }

    [JsonPropertyName("overview_polyline")]
    public required OverviewPolyline OverviewPolyline { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fare")]
    public Fare1? Fare { get; init; }
}
