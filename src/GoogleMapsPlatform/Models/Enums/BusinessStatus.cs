using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Indicates the operational status of the place, if it is a business. If no data exists, <c>business_status</c> is not returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessStatus>))]
public sealed record BusinessStatus : OpenStringEnum<BusinessStatus>
{
    private BusinessStatus(string value) : base(value)
    {
    }

    public static readonly BusinessStatus Operational = new("OPERATIONAL");

    public static readonly BusinessStatus ClosedTemporarily = new("CLOSED_TEMPORARILY");

    public static readonly BusinessStatus ClosedPermanently = new("CLOSED_PERMANENTLY");

    public TResult Match<TResult>(Func<TResult> onOperational,
        Func<TResult> onClosedTemporarily,
        Func<TResult> onClosedPermanently,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Operational => onOperational(),
            _ when this == ClosedTemporarily => onClosedTemporarily(),
            _ when this == ClosedPermanently => onClosedPermanently(),
            _ => otherwise(Value)
        };

    public void Match(Action onOperational,
        Action onClosedTemporarily,
        Action onClosedPermanently,
        Action<string> otherwise)
    {
        if (this == Operational) onOperational();
        else if (this == ClosedTemporarily) onClosedTemporarily();
        else if (this == ClosedPermanently) onClosedPermanently();
        else otherwise(Value);
    }
}
