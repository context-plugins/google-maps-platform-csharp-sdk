using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record SnappedPoint
{
    [JsonPropertyName("location")]
    public required Location6 Location { get; init; }

    /// <summary>
    /// An integer that indicates the corresponding value in the original request. Each value in the request should map to a snapped value in the response. However, if you've set interpolate=true or if you're using nearest roads, then it's possible that the response will contain more coordinates than the request. Interpolated values will not have an <c>originalIndex</c>. These values are indexed from <c>0</c>, so a point with an originalIndex of <c>4</c> will be the snapped value of the 5th latitude/longitude passed to the path parameter. Nearest Roads points may contain several points for single coordinates with differing location or placeId.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalIndex")]
    public double? OriginalIndex { get; init; }

    /// <summary>
    /// A unique identifier for a place. All place IDs returned by the Roads API correspond to road segments.
    /// </summary>
    [JsonPropertyName("placeId")]
    public required string PlaceId { get; init; }
}
