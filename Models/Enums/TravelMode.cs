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
public sealed record TravelMode : StringEnum<TravelMode>
{
    private TravelMode(string value) : base(value)
    {
    }

    public static readonly TravelMode Driving = new("DRIVING");

    public static readonly TravelMode Bicycling = new("BICYCLING");

    public static readonly TravelMode Transit = new("TRANSIT");

    public static readonly TravelMode Walking = new("WALKING");

    public static TravelMode FromValue(string value) => FromValueCore(value);
}
