using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Minprice>))]
public sealed record Minprice : OpenStringEnum<Minprice>
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

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action on_1, Action on_2, Action on_3, Action on_4, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else otherwise(Value);
    }
}
