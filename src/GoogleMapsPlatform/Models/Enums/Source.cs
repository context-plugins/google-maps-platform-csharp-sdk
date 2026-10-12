using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Source>))]
public sealed record Source : OpenStringEnum<Source>
{
    private Source(string value) : base(value)
    {
    }

    public static readonly Source Default = new("default");

    public static readonly Source Outdoor = new("outdoor");

    public TResult Match<TResult>(Func<TResult> onDefault, Func<TResult> onOutdoor, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Default => onDefault(),
            _ when this == Outdoor => onOutdoor(),
            _ => otherwise(Value)
        };

    public void Match(Action onDefault, Action onOutdoor, Action<string> otherwise)
    {
        if (this == Default) onDefault();
        else if (this == Outdoor) onOutdoor();
        else otherwise(Value);
    }
}
