using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Maxprice>))]
public sealed record Maxprice : StringEnum<Maxprice>
{
    private Maxprice(string value) : base(value)
    {
    }

    public static readonly Maxprice _0 = new("0");

    public static readonly Maxprice _1 = new("1");

    public static readonly Maxprice _2 = new("2");

    public static readonly Maxprice _3 = new("3");

    public static readonly Maxprice _4 = new("4");

    public static Maxprice FromValue(string value) => FromValueCore(value);
}
