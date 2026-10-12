using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Rankby>))]
public sealed record Rankby : OpenStringEnum<Rankby>
{
    private Rankby(string value) : base(value)
    {
    }

    public static readonly Rankby Prominence = new("prominence");

    public static readonly Rankby Distance = new("distance");

    public TResult Match<TResult>(Func<TResult> onProminence,
        Func<TResult> onDistance,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Prominence => onProminence(),
            _ when this == Distance => onDistance(),
            _ => otherwise(Value)
        };

    public void Match(Action onProminence, Action onDistance, Action<string> otherwise)
    {
        if (this == Prominence) onProminence();
        else if (this == Distance) onDistance();
        else otherwise(Value);
    }
}
