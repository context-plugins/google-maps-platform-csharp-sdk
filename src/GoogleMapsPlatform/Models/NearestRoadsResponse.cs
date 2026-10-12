using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record NearestRoadsResponse
{
    /// <summary>
    /// An array of snapped points. Sometimes containing several snapped points for the same point with differing placeId or location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snappedPoints")]
    public IReadOnlyList<SnappedPoint>? SnappedPoints { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
