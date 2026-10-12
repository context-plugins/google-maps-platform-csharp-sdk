using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Contains the action to take for the current step (turn left, merge, straight, etc.). Values are subject to change, and new values may be introduced without prior notice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Maneuver>))]
public sealed record Maneuver : OpenStringEnum<Maneuver>
{
    private Maneuver(string value) : base(value)
    {
    }

    public static readonly Maneuver TurnSlightLeft = new("turn-slight-left");

    public static readonly Maneuver TurnSharpLeft = new("turn-sharp-left");

    public static readonly Maneuver TurnLeft = new("turn-left");

    public static readonly Maneuver TurnSlightRight = new("turn-slight-right");

    public static readonly Maneuver TurnSharpRight = new("turn-sharp-right");

    public static readonly Maneuver KeepRight = new("keep-right");

    public static readonly Maneuver KeepLeft = new("keep-left");

    public static readonly Maneuver UturnLeft = new("uturn-left");

    public static readonly Maneuver UturnRight = new("uturn-right");

    public static readonly Maneuver TurnRight = new("turn-right");

    public static readonly Maneuver Straight = new("straight");

    public static readonly Maneuver RampLeft = new("ramp-left");

    public static readonly Maneuver RampRight = new("ramp-right");

    public static readonly Maneuver Merge = new("merge");

    public static readonly Maneuver ForkLeft = new("fork-left");

    public static readonly Maneuver ForkRight = new("fork-right");

    public static readonly Maneuver Ferry = new("ferry");

    public static readonly Maneuver FerryTrain = new("ferry-train");

    public static readonly Maneuver RoundaboutLeft = new("roundabout-left");

    public static readonly Maneuver RoundaboutRight = new("roundabout-right");

    public TResult Match<TResult>(Func<TResult> onTurnSlightLeft,
        Func<TResult> onTurnSharpLeft,
        Func<TResult> onTurnLeft,
        Func<TResult> onTurnSlightRight,
        Func<TResult> onTurnSharpRight,
        Func<TResult> onKeepRight,
        Func<TResult> onKeepLeft,
        Func<TResult> onUturnLeft,
        Func<TResult> onUturnRight,
        Func<TResult> onTurnRight,
        Func<TResult> onStraight,
        Func<TResult> onRampLeft,
        Func<TResult> onRampRight,
        Func<TResult> onMerge,
        Func<TResult> onForkLeft,
        Func<TResult> onForkRight,
        Func<TResult> onFerry,
        Func<TResult> onFerryTrain,
        Func<TResult> onRoundaboutLeft,
        Func<TResult> onRoundaboutRight,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TurnSlightLeft => onTurnSlightLeft(),
            _ when this == TurnSharpLeft => onTurnSharpLeft(),
            _ when this == TurnLeft => onTurnLeft(),
            _ when this == TurnSlightRight => onTurnSlightRight(),
            _ when this == TurnSharpRight => onTurnSharpRight(),
            _ when this == KeepRight => onKeepRight(),
            _ when this == KeepLeft => onKeepLeft(),
            _ when this == UturnLeft => onUturnLeft(),
            _ when this == UturnRight => onUturnRight(),
            _ when this == TurnRight => onTurnRight(),
            _ when this == Straight => onStraight(),
            _ when this == RampLeft => onRampLeft(),
            _ when this == RampRight => onRampRight(),
            _ when this == Merge => onMerge(),
            _ when this == ForkLeft => onForkLeft(),
            _ when this == ForkRight => onForkRight(),
            _ when this == Ferry => onFerry(),
            _ when this == FerryTrain => onFerryTrain(),
            _ when this == RoundaboutLeft => onRoundaboutLeft(),
            _ when this == RoundaboutRight => onRoundaboutRight(),
            _ => otherwise(Value)
        };

    public void Match(Action onTurnSlightLeft,
        Action onTurnSharpLeft,
        Action onTurnLeft,
        Action onTurnSlightRight,
        Action onTurnSharpRight,
        Action onKeepRight,
        Action onKeepLeft,
        Action onUturnLeft,
        Action onUturnRight,
        Action onTurnRight,
        Action onStraight,
        Action onRampLeft,
        Action onRampRight,
        Action onMerge,
        Action onForkLeft,
        Action onForkRight,
        Action onFerry,
        Action onFerryTrain,
        Action onRoundaboutLeft,
        Action onRoundaboutRight,
        Action<string> otherwise)
    {
        if (this == TurnSlightLeft) onTurnSlightLeft();
        else if (this == TurnSharpLeft) onTurnSharpLeft();
        else if (this == TurnLeft) onTurnLeft();
        else if (this == TurnSlightRight) onTurnSlightRight();
        else if (this == TurnSharpRight) onTurnSharpRight();
        else if (this == KeepRight) onKeepRight();
        else if (this == KeepLeft) onKeepLeft();
        else if (this == UturnLeft) onUturnLeft();
        else if (this == UturnRight) onUturnRight();
        else if (this == TurnRight) onTurnRight();
        else if (this == Straight) onStraight();
        else if (this == RampLeft) onRampLeft();
        else if (this == RampRight) onRampRight();
        else if (this == Merge) onMerge();
        else if (this == ForkLeft) onForkLeft();
        else if (this == ForkRight) onForkRight();
        else if (this == Ferry) onFerry();
        else if (this == FerryTrain) onFerryTrain();
        else if (this == RoundaboutLeft) onRoundaboutLeft();
        else if (this == RoundaboutRight) onRoundaboutRight();
        else otherwise(Value);
    }
}
