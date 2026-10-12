using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record OverviewPolyline
{
    /// <summary>
    /// A single string representation of the polyline.
    /// </summary>
    [JsonPropertyName("points")]
    public required string Points { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
