using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record PlaceOpeningHoursPeriod
{
    [JsonPropertyName("open")]
    public required PlaceOpeningHoursPeriodDetail Open { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("close")]
    public PlaceOpeningHoursPeriodDetail? Close { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
