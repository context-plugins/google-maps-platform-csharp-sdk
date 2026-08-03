using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Minprice>))]
public sealed record Minprice : StringEnum<Minprice>
{
    private Minprice(string value) : base(value)
    {
    }

    public static readonly Minprice _0 = new("0");

    public static readonly Minprice _1 = new("1");

    public static readonly Minprice _2 = new("2");

    public static readonly Minprice _3 = new("3");

    public static readonly Minprice _4 = new("4");

    public static Minprice FromValue(string value) => FromValueCore(value);
}
