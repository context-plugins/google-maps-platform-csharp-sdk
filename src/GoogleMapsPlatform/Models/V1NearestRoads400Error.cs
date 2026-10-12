using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record V1NearestRoads400Error
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public NearestRoadsError? Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
