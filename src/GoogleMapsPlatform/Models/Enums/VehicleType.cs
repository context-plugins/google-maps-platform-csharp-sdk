using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The type of vehicle used.
/// <list type="bullet">
///   <item><description><c>BUS</c> -	Bus.</description></item>
///   <item><description><c>CABLE_CAR</c> -	A vehicle that operates on a cable, usually on the ground. Aerial cable cars may be of the type GONDOLA_LIFT.</description></item>
///   <item><description><c>COMMUTER_TRAIN</c> -	Commuter rail.</description></item>
///   <item><description><c>FERRY</c> -	Ferry.</description></item>
///   <item><description><c>FUNICULAR</c> -	A vehicle that is pulled up a steep incline by a cable. A Funicular typically consists of two cars, with each car acting as a counterweight for the other.</description></item>
///   <item><description><c>GONDOLA_LIFT</c> -	An aerial cable car.</description></item>
///   <item><description><c>HEAVY_RAIL</c> -	Heavy rail.</description></item>
///   <item><description><c>HIGH_SPEED_TRAIN</c> -	High speed train.</description></item>
///   <item><description><c>INTERCITY_BUS</c> -	Intercity bus.</description></item>
///   <item><description><c>LONG_DISTANCE_TRAIN</c> -	Long distance train.</description></item>
///   <item><description><c>METRO_RAIL</c> -	Light rail transit.</description></item>
///   <item><description><c>MONORAIL</c> -	Monorail.</description></item>
///   <item><description><c>OTHER</c> -	All other vehicles will return this type.</description></item>
///   <item><description><c>RAIL</c> -	Rail.</description></item>
///   <item><description><c>SHARE_TAXI</c> -	Share taxi is a kind of bus with the ability to drop off and pick up passengers anywhere on its route.</description></item>
///   <item><description><c>SUBWAY</c> -	Underground light rail.</description></item>
///   <item><description><c>TRAM</c> -	Above ground light rail.</description></item>
///   <item><description><c>TROLLEYBUS</c> -	Trolleybus.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VehicleType>))]
public sealed record VehicleType : OpenStringEnum<VehicleType>
{
    private VehicleType(string value) : base(value)
    {
    }

    public static readonly VehicleType Bus = new("BUS");

    public static readonly VehicleType CableCar = new("CABLE_CAR");

    public static readonly VehicleType CommuterTrain = new("COMMUTER_TRAIN");

    public static readonly VehicleType Ferry = new("FERRY");

    public static readonly VehicleType Funicular = new("FUNICULAR");

    public static readonly VehicleType GondolaLift = new("GONDOLA_LIFT");

    public static readonly VehicleType HeavyRail = new("HEAVY_RAIL");

    public static readonly VehicleType HighSpeedTrain = new("HIGH_SPEED_TRAIN");

    public static readonly VehicleType IntercityBus = new("INTERCITY_BUS");

    public static readonly VehicleType LongDistanceTrain = new("LONG_DISTANCE_TRAIN");

    public static readonly VehicleType MetroRail = new("METRO_RAIL");

    public static readonly VehicleType Monorail = new("MONORAIL");

    public static readonly VehicleType Other = new("OTHER");

    public static readonly VehicleType Rail = new("RAIL");

    public static readonly VehicleType ShareTaxi = new("SHARE_TAXI");

    public static readonly VehicleType Subway = new("SUBWAY");

    public static readonly VehicleType Tram = new("TRAM");

    public static readonly VehicleType Trolleybus = new("TROLLEYBUS");

    public TResult Match<TResult>(Func<TResult> onBus,
        Func<TResult> onCableCar,
        Func<TResult> onCommuterTrain,
        Func<TResult> onFerry,
        Func<TResult> onFunicular,
        Func<TResult> onGondolaLift,
        Func<TResult> onHeavyRail,
        Func<TResult> onHighSpeedTrain,
        Func<TResult> onIntercityBus,
        Func<TResult> onLongDistanceTrain,
        Func<TResult> onMetroRail,
        Func<TResult> onMonorail,
        Func<TResult> onOther,
        Func<TResult> onRail,
        Func<TResult> onShareTaxi,
        Func<TResult> onSubway,
        Func<TResult> onTram,
        Func<TResult> onTrolleybus,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bus => onBus(),
            _ when this == CableCar => onCableCar(),
            _ when this == CommuterTrain => onCommuterTrain(),
            _ when this == Ferry => onFerry(),
            _ when this == Funicular => onFunicular(),
            _ when this == GondolaLift => onGondolaLift(),
            _ when this == HeavyRail => onHeavyRail(),
            _ when this == HighSpeedTrain => onHighSpeedTrain(),
            _ when this == IntercityBus => onIntercityBus(),
            _ when this == LongDistanceTrain => onLongDistanceTrain(),
            _ when this == MetroRail => onMetroRail(),
            _ when this == Monorail => onMonorail(),
            _ when this == Other => onOther(),
            _ when this == Rail => onRail(),
            _ when this == ShareTaxi => onShareTaxi(),
            _ when this == Subway => onSubway(),
            _ when this == Tram => onTram(),
            _ when this == Trolleybus => onTrolleybus(),
            _ => otherwise(Value)
        };

    public void Match(Action onBus,
        Action onCableCar,
        Action onCommuterTrain,
        Action onFerry,
        Action onFunicular,
        Action onGondolaLift,
        Action onHeavyRail,
        Action onHighSpeedTrain,
        Action onIntercityBus,
        Action onLongDistanceTrain,
        Action onMetroRail,
        Action onMonorail,
        Action onOther,
        Action onRail,
        Action onShareTaxi,
        Action onSubway,
        Action onTram,
        Action onTrolleybus,
        Action<string> otherwise)
    {
        if (this == Bus) onBus();
        else if (this == CableCar) onCableCar();
        else if (this == CommuterTrain) onCommuterTrain();
        else if (this == Ferry) onFerry();
        else if (this == Funicular) onFunicular();
        else if (this == GondolaLift) onGondolaLift();
        else if (this == HeavyRail) onHeavyRail();
        else if (this == HighSpeedTrain) onHighSpeedTrain();
        else if (this == IntercityBus) onIntercityBus();
        else if (this == LongDistanceTrain) onLongDistanceTrain();
        else if (this == MetroRail) onMetroRail();
        else if (this == Monorail) onMonorail();
        else if (this == Other) onOther();
        else if (this == Rail) onRail();
        else if (this == ShareTaxi) onShareTaxi();
        else if (this == Subway) onSubway();
        else if (this == Tram) onTram();
        else if (this == Trolleybus) onTrolleybus();
        else otherwise(Value);
    }
}
