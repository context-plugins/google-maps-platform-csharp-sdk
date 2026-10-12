using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Inputtype>))]
public sealed record Inputtype : OpenStringEnum<Inputtype>
{
    private Inputtype(string value) : base(value)
    {
    }

    public static readonly Inputtype Textquery = new("textquery");

    public static readonly Inputtype Phonenumber = new("phonenumber");

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
