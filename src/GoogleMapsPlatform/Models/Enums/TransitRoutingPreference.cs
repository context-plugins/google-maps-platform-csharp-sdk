using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransitRoutingPreference>))]
public sealed record TransitRoutingPreference : OpenStringEnum<TransitRoutingPreference>
{
    private TransitRoutingPreference(string value) : base(value)
    {
    }

    public static readonly TransitRoutingPreference LessWalking = new("less_walking");

    public static readonly TransitRoutingPreference FewerTransfers = new("fewer_transfers");

    public TResult Match<TResult>(Func<TResult> onLessWalking,
        Func<TResult> onFewerTransfers,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LessWalking => onLessWalking(),
            _ when this == FewerTransfers => onFewerTransfers(),
            _ => otherwise(Value)
        };

    public void Match(Action onLessWalking, Action onFewerTransfers, Action<string> otherwise)
    {
        if (this == LessWalking) onLessWalking();
        else if (this == FewerTransfers) onFewerTransfers();
        else otherwise(Value);
    }
}
