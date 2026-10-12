using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Indicates the status code resulting from the geocoding operation. This field may contain the following values.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GeocoderStatus>))]
public sealed record GeocoderStatus : OpenStringEnum<GeocoderStatus>
{
    private GeocoderStatus(string value) : base(value)
    {
    }

    public static readonly GeocoderStatus Ok = new("OK");

    public static readonly GeocoderStatus ZeroResults = new("ZERO_RESULTS");

    public TResult Match<TResult>(Func<TResult> onOk, Func<TResult> onZeroResults, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == ZeroResults => onZeroResults(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk, Action onZeroResults, Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == ZeroResults) onZeroResults();
        else otherwise(Value);
    }
}
