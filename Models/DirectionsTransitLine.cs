using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record DirectionsTransitLine
{
    /// <summary>
    /// The transit agency (or agencies) that operates this transit line.
    /// </summary>
    [JsonPropertyName("agencies")]
    public required IReadOnlyList<DirectionsTransitAgency> Agencies { get; init; }

    /// <summary>
    /// The color commonly used in signage for this line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    /// <summary>
    /// The full name of this transit line, e.g. "8 Avenue Local".
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The short name of this transit line. This will normally be a line number, such as "M7" or "355".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_name")]
    public string? ShortName { get; init; }

    /// <summary>
    /// The color commonly used in signage for this line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_color")]
    public string? TextColor { get; init; }

    /// <summary>
    /// Contains the URL for this transit line as provided by the transit agency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Contains the URL for the icon associated with this line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicle")]
    public DirectionsTransitVehicle? Vehicle { get; init; }
}
