using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record DistanceMatrixElement
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fare")]
    public Fare1? Fare { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public Distance? Distance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration_in_traffic")]
    public DurationInTraffic? DurationInTraffic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public Duration? Duration { get; init; }

    [JsonPropertyName("status")]
    public required DistanceMatrixElementStatus Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
