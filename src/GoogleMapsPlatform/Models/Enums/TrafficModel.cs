using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TrafficModel>))]
public sealed record TrafficModel : OpenStringEnum<TrafficModel>
{
    private TrafficModel(string value) : base(value)
    {
    }

    public static readonly TrafficModel BestGuess = new("best_guess");

    public static readonly TrafficModel Pessimistic = new("pessimistic");

    public static readonly TrafficModel Optimistic = new("optimistic");

    public TResult Match<TResult>(Func<TResult> onBestGuess,
        Func<TResult> onPessimistic,
        Func<TResult> onOptimistic,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BestGuess => onBestGuess(),
            _ when this == Pessimistic => onPessimistic(),
            _ when this == Optimistic => onOptimistic(),
            _ => otherwise(Value)
        };

    public void Match(Action onBestGuess, Action onPessimistic, Action onOptimistic, Action<string> otherwise)
    {
        if (this == BestGuess) onBestGuess();
        else if (this == Pessimistic) onPessimistic();
        else if (this == Optimistic) onOptimistic();
        else otherwise(Value);
    }
}
