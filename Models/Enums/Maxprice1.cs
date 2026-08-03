using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Maxprice1>))]
public sealed record Maxprice1 : StringEnum<Maxprice1>
{
    private Maxprice1(string value) : base(value)
    {
    }

    public static readonly Maxprice1 _0 = new("0");

    public static readonly Maxprice1 _1 = new("1");

    public static readonly Maxprice1 _2 = new("2");

    public static readonly Maxprice1 _3 = new("3");

    public static readonly Maxprice1 _4 = new("4");

    public static Maxprice1 FromValue(string value) => FromValueCore(value);
}
