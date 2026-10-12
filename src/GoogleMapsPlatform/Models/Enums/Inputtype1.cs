using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The type of input. This can be one of either <c>textquery</c> or <c>phonenumber</c>. Phone numbers must be in international format (prefixed by a plus sign ("+"), followed by the country code, then the phone number itself). See <see href="https://en.wikipedia.org/wiki/E.164">E.164 ITU recommendation</see> for more information.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Inputtype1>))]
public sealed record Inputtype1 : OpenStringEnum<Inputtype1>
{
    private Inputtype1(string value) : base(value)
    {
    }

    public static readonly Inputtype1 Textquery = new("textquery");

    public static readonly Inputtype1 Phonenumber = new("phonenumber");

    public TResult Match<TResult>(Func<TResult> onTextquery,
        Func<TResult> onPhonenumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Textquery => onTextquery(),
            _ when this == Phonenumber => onPhonenumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onTextquery, Action onPhonenumber, Action<string> otherwise)
    {
        if (this == Textquery) onTextquery();
        else if (this == Phonenumber) onPhonenumber();
        else otherwise(Value);
    }
}
