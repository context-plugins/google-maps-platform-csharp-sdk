using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record SnapToRoadsResponse
{
    /// <summary>
    /// An array of snapped points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snappedPoints")]
    public IReadOnlyList<SnappedPoint>? SnappedPoints { get; init; }

    /// <summary>
    /// A string containing a user-visible warning.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warningMessage")]
    public string? WarningMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
