using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record ElevationResult
{
    /// <summary>
    /// The elevation of the location in meters.
    /// </summary>
    [JsonPropertyName("elevation")]
    public required double Elevation { get; init; }

    /// <summary>
    /// The value indicating the maximum distance between data points from which the elevation was interpolated, in meters. This property will be missing if the resolution is not known. Note that elevation data becomes more coarse (larger resolution values) when multiple points are passed. To obtain the most accurate elevation value for a point, it should be queried independently.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resolution")]
    public double? Resolution { get; init; }

    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
