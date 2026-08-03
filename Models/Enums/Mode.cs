using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : StringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode Driving = new("driving");

    public static readonly Mode Bicycling = new("bicycling");

    public static readonly Mode Transit = new("transit");

    public static readonly Mode Walking = new("walking");

    public static Mode FromValue(string value) => FromValueCore(value);
}
