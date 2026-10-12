using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// <list type="bullet">
///   <item><description><c>DRIVING</c> (default) indicates calculation using the road network.</description></item>
///   <item><description><c>BICYCLING</c> requests calculation for bicycling via bicycle paths &amp; preferred streets (where available).</description></item>
///   <item><description><c>TRANSIT</c> requests calculation via public transit routes (where available).</description></item>
///   <item><description><c>WALKING</c> requests calculation for walking via pedestrian paths &amp; sidewalks (where available).</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TravelMode>))]
public sealed record TravelMode : OpenStringEnum<TravelMode>
{
    private TravelMode(string value) : base(value)
    {
    }

    public static readonly TravelMode Driving = new("DRIVING");

    public static readonly TravelMode Bicycling = new("BICYCLING");

    public static readonly TravelMode Transit = new("TRANSIT");

    public static readonly TravelMode Walking = new("WALKING");

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
