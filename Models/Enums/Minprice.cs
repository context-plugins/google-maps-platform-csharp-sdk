using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Minprice>))]
public sealed record Minprice : StringEnum<Minprice>
{
    private Minprice(string value) : base(value)
    {
    }

    /// <summary>
    /// Free.
    /// </summary>
    public static readonly Minprice _0 = new("0");

    /// <summary>
    /// Inexpensive.
    /// </summary>
    public static readonly Minprice _1 = new("1");

    /// <summary>
    /// Moderately priced.
    /// </summary>
    public static readonly Minprice _2 = new("2");

    /// <summary>
    /// Expensive.
    /// </summary>
    public static readonly Minprice _3 = new("3");

    /// <summary>
    /// Very expensive.
    /// </summary>
    public static readonly Minprice _4 = new("4");

    public static Minprice FromValue(string value) => FromValueCore(value);
}
