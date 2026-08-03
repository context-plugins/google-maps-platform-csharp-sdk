using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record DirectionsTransitStop
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    /// <summary>
    /// The name of the transit stop.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
