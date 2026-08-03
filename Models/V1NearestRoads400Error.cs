using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record V1NearestRoads400Error
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public NearestRoadsError? Error { get; init; }
}
