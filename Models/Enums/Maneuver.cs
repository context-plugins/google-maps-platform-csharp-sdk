using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Contains the action to take for the current step (turn left, merge, straight, etc.). Values are subject to change, and new values may be introduced without prior notice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Maneuver>))]
public sealed record Maneuver : StringEnum<Maneuver>
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

    public static Maneuver FromValue(string value) => FromValueCore(value);
}
