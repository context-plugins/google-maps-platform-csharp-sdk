using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// For the calculation of distances and directions, you may specify the transportation mode to use. By default, <c>DRIVING</c> mode is used. By default, directions are calculated as driving directions. The following travel modes are supported:
/// <list type="bullet">
///   <item><description><c>driving</c> (default) indicates standard driving directions or distance using the road network.</description></item>
///   <item><description><c>walking</c> requests walking directions or distance via pedestrian paths &amp; sidewalks (where available).</description></item>
///   <item><description><c>bicycling</c> requests bicycling directions or distance via bicycle paths &amp; preferred streets (where available).</description></item>
///   <item><description><c>transit</c> requests directions or distance via public transit routes (where available). Transit trips are available for up to 7 days in the past or 100 days in the future. If you set the mode to transit, you can optionally specify either a <c>departure_time</c> or an <c>arrival_time</c>. If neither time is specified, the <c>departure_time</c> defaults to now (that is, the departure time defaults to the current time). You can also optionally include a <c>transit_mode</c> and/or a <c>transit_routing_preference</c>.</description></item>
/// </list>
/// <para>
/// &lt;div class="note"&gt;Note: Both walking and bicycling directions may sometimes not include clear pedestrian or bicycling paths, so these directions will return warnings in the returned result which you must display to the user.&lt;/div&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode1>))]
public sealed record Mode1 : OpenStringEnum<Mode1>
{
    private Mode1(string value) : base(value)
    {
    }

    public static readonly Mode1 Driving = new("driving");

    public static readonly Mode1 Bicycling = new("bicycling");

    public static readonly Mode1 Transit = new("transit");

    public static readonly Mode1 Walking = new("walking");

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
