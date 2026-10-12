using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// <list type="bullet">
///   <item><description><c>OK</c> indicates the response contains a valid result.</description></item>
///   <item><description><c>NOT_FOUND</c> indicates that the origin and/or destination of this pairing could not be geocoded.</description></item>
///   <item><description><c>ZERO_RESULTS</c> indicates no route could be found between the origin and destination.</description></item>
///   <item><description><c>MAX_ROUTE_LENGTH_EXCEEDED</c> indicates the requested route is too long and cannot be processed.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DistanceMatrixElementStatus>))]
public sealed record DistanceMatrixElementStatus : OpenStringEnum<DistanceMatrixElementStatus>
{
    private DistanceMatrixElementStatus(string value) : base(value)
    {
    }

    public static readonly DistanceMatrixElementStatus Ok = new("OK");

    public static readonly DistanceMatrixElementStatus NotFound = new("NOT_FOUND");

    public static readonly DistanceMatrixElementStatus ZeroResults = new("ZERO_RESULTS");

    public static readonly DistanceMatrixElementStatus MaxRouteLengthExceeded = new("MAX_ROUTE_LENGTH_EXCEEDED");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onNotFound,
        Func<TResult> onZeroResults,
        Func<TResult> onMaxRouteLengthExceeded,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == NotFound => onNotFound(),
            _ when this == ZeroResults => onZeroResults(),
            _ when this == MaxRouteLengthExceeded => onMaxRouteLengthExceeded(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk,
        Action onNotFound,
        Action onZeroResults,
        Action onMaxRouteLengthExceeded,
        Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == NotFound) onNotFound();
        else if (this == ZeroResults) onZeroResults();
        else if (this == MaxRouteLengthExceeded) onMaxRouteLengthExceeded();
        else otherwise(Value);
    }
}
