using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Status codes returned by service.
/// - <c>OK</c> indicates the response contains a valid result.
/// - <c>INVALID_REQUEST</c> indicates that the provided request was invalid.
/// - <c>MAX_ELEMENTS_EXCEEDED</c> indicates that the product of origins and destinations exceeds the per-query limit.
/// - <c>MAX_DIMENSIONS_EXCEEDED</c> indicates that the number of origins or destinations exceeds the per-query limit.
/// - <c>OVER_DAILY_LIMIT</c> indicates any of the following:
///   - The API key is missing or invalid.
///   - Billing has not been enabled on your account.
///   - A self-imposed usage cap has been exceeded.
///   - The provided method of payment is no longer valid (for example, a credit card has expired).
/// - <c>OVER_QUERY_LIMIT</c> indicates the service has received too many requests from your application within the allowed time period.
/// - <c>REQUEST_DENIED</c> indicates that the service denied use of the Distance Matrix service by your application.
/// - <c>UNKNOWN_ERROR</c> indicates a Distance Matrix request could not be processed due to a server error. The request may succeed if you try again.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DistanceMatrixStatus>))]
public sealed record DistanceMatrixStatus : OpenStringEnum<DistanceMatrixStatus>
{
    private DistanceMatrixStatus(string value) : base(value)
    {
    }

    public static readonly DistanceMatrixStatus Ok = new("OK");

    public static readonly DistanceMatrixStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly DistanceMatrixStatus MaxElementsExceeded = new("MAX_ELEMENTS_EXCEEDED");

    public static readonly DistanceMatrixStatus MaxDimensionsExceeded = new("MAX_DIMENSIONS_EXCEEDED");

    public static readonly DistanceMatrixStatus OverDailyLimit = new("OVER_DAILY_LIMIT");

    public static readonly DistanceMatrixStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly DistanceMatrixStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly DistanceMatrixStatus UnknownError = new("UNKNOWN_ERROR");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onInvalidRequest,
        Func<TResult> onMaxElementsExceeded,
        Func<TResult> onMaxDimensionsExceeded,
        Func<TResult> onOverDailyLimit,
        Func<TResult> onOverQueryLimit,
        Func<TResult> onRequestDenied,
        Func<TResult> onUnknownError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == MaxElementsExceeded => onMaxElementsExceeded(),
            _ when this == MaxDimensionsExceeded => onMaxDimensionsExceeded(),
            _ when this == OverDailyLimit => onOverDailyLimit(),
            _ when this == OverQueryLimit => onOverQueryLimit(),
            _ when this == RequestDenied => onRequestDenied(),
            _ when this == UnknownError => onUnknownError(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk,
        Action onInvalidRequest,
        Action onMaxElementsExceeded,
        Action onMaxDimensionsExceeded,
        Action onOverDailyLimit,
        Action onOverQueryLimit,
        Action onRequestDenied,
        Action onUnknownError,
        Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == InvalidRequest) onInvalidRequest();
        else if (this == MaxElementsExceeded) onMaxElementsExceeded();
        else if (this == MaxDimensionsExceeded) onMaxDimensionsExceeded();
        else if (this == OverDailyLimit) onOverDailyLimit();
        else if (this == OverQueryLimit) onOverQueryLimit();
        else if (this == RequestDenied) onRequestDenied();
        else if (this == UnknownError) onUnknownError();
        else otherwise(Value);
    }
}
