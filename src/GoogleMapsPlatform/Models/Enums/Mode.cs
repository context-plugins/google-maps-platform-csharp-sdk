using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : OpenStringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode Driving = new("driving");

    public static readonly Mode Bicycling = new("bicycling");

    public static readonly Mode Transit = new("transit");

    public static readonly Mode Walking = new("walking");

    public TResult Match<TResult>(Func<TResult> onDriving,
        Func<TResult> onBicycling,
        Func<TResult> onTransit,
        Func<TResult> onWalking,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Driving => onDriving(),
            _ when this == Bicycling => onBicycling(),
            _ when this == Transit => onTransit(),
            _ when this == Walking => onWalking(),
            _ => otherwise(Value)
        };

    public void Match(Action onDriving,
        Action onBicycling,
        Action onTransit,
        Action onWalking,
        Action<string> otherwise)
    {
        if (this == Driving) onDriving();
        else if (this == Bicycling) onBicycling();
        else if (this == Transit) onTransit();
        else if (this == Walking) onWalking();
        else otherwise(Value);
    }
}
