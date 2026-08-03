using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record PlaceOpeningHoursPeriod
{
    [JsonPropertyName("open")]
    public required PlaceOpeningHoursPeriodDetail Open { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("close")]
    public PlaceOpeningHoursPeriodDetail? Close { get; init; }
}
