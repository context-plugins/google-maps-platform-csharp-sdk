using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TrafficModel>))]
public sealed record TrafficModel : StringEnum<TrafficModel>
{
    private TrafficModel(string value) : base(value)
    {
    }

    public static readonly TrafficModel BestGuess = new("best_guess");

    public static readonly TrafficModel Pessimistic = new("pessimistic");

    public static readonly TrafficModel Optimistic = new("optimistic");

    public static TrafficModel FromValue(string value) => FromValueCore(value);
}
