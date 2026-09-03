using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Maxprice>))]
public sealed record Maxprice : StringEnum<Maxprice>
{
    private Maxprice(string value) : base(value)
    {
    }

    /// <summary>
    /// Free.
    /// </summary>
    public static readonly Maxprice _0 = new("0");

    /// <summary>
    /// Inexpensive.
    /// </summary>
    public static readonly Maxprice _1 = new("1");

    /// <summary>
    /// Moderately priced.
    /// </summary>
    public static readonly Maxprice _2 = new("2");

    /// <summary>
    /// Expensive.
    /// </summary>
    public static readonly Maxprice _3 = new("3");

    /// <summary>
    /// Very expensive.
    /// </summary>
    public static readonly Maxprice _4 = new("4");

    public static Maxprice FromValue(string value) => FromValueCore(value);
}
