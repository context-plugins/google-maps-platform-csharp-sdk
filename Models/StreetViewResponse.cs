using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record StreetViewResponse
{
    /// <summary>
    /// Contains the copyright notices associated with this panorama.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("copyright")]
    public string? Copyright { get; init; }

    /// <summary>
    /// A string indicating year and month that the panorama was captured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public string? Date { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Location? Location { get; init; }

    /// <summary>
    /// A specific panorama ID. These are generally stable, though panoramas may change ID over time as imagery is refreshed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pano_id")]
    public string? PanoId { get; init; }

    [JsonPropertyName("status")]
    public required StreetViewStatus Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
