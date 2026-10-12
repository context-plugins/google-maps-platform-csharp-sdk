using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Units>))]
public sealed record Units : OpenStringEnum<Units>
{
    private Units(string value) : base(value)
    {
    }

    public static readonly Units Imperial = new("imperial");

    public static readonly Units Metric = new("metric");

    public TResult Match<TResult>(Func<TResult> onImperial, Func<TResult> onMetric, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Imperial => onImperial(),
            _ when this == Metric => onMetric(),
            _ => otherwise(Value)
        };

    public void Match(Action onImperial, Action onMetric, Action<string> otherwise)
    {
        if (this == Imperial) onImperial();
        else if (this == Metric) onMetric();
        else otherwise(Value);
    }
}
