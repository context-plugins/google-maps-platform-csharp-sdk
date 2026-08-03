using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record NearestRoadsErrorResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public NearestRoadsError? Error { get; init; }
}
