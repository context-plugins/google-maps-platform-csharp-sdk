using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Specifies the assumptions to use when calculating time in traffic. This setting affects the value returned in the duration_in_traffic field in the response, which contains the predicted time in traffic based on historical averages. The <c>traffic_model</c> parameter may only be specified for driving directions where the request includes a <c>departure_time</c>. The available values for this parameter are:
/// * <c>best_guess</c> (default) indicates that the returned duration_in_traffic should be the best estimate of travel time given what is known about both historical traffic conditions and live traffic. Live traffic becomes more important the closer the <c>departure_time</c> is to now.
/// * <c>pessimistic</c> indicates that the returned duration_in_traffic should be longer than the actual travel time on most days, though occasional days with particularly bad traffic conditions may exceed this value.
/// * <c>optimistic</c> indicates that the returned duration_in_traffic should be shorter than the actual travel time on most days, though occasional days with particularly good traffic conditions may be faster than this value.
/// The default value of <c>best_guess</c> will give the most useful predictions for the vast majority of use cases. It is possible the <c>best_guess</c> travel time prediction may be shorter than <c>optimistic</c>, or alternatively, longer than <c>pessimistic</c>, due to the way the <c>best_guess</c> prediction model integrates live traffic information.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrafficModel1>))]
public sealed record TrafficModel1 : StringEnum<TrafficModel1>
{
    private TrafficModel1(string value) : base(value)
    {
    }

    public static readonly TrafficModel1 BestGuess = new("best_guess");

    public static readonly TrafficModel1 Pessimistic = new("pessimistic");

    public static readonly TrafficModel1 Optimistic = new("optimistic");

    public static TrafficModel1 FromValue(string value) => FromValueCore(value);
}
