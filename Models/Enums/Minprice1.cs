using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Minprice1>))]
public sealed record Minprice1 : StringEnum<Minprice1>
{
    private Minprice1(string value) : base(value)
    {
    }

    /// <summary>
    /// Free.
    /// </summary>
    public static readonly Minprice1 _0 = new("0");

    /// <summary>
    /// Inexpensive.
    /// </summary>
    public static readonly Minprice1 _1 = new("1");

    /// <summary>
    /// Moderately priced.
    /// </summary>
    public static readonly Minprice1 _2 = new("2");

    /// <summary>
    /// Expensive.
    /// </summary>
    public static readonly Minprice1 _3 = new("3");

    /// <summary>
    /// Very expensive.
    /// </summary>
    public static readonly Minprice1 _4 = new("4");

    public static Minprice1 FromValue(string value) => FromValueCore(value);
}
