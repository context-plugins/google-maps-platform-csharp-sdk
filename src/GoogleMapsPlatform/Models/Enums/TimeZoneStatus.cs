using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The <c>status</c> field within the Time Zone response object contains the status of the request. The <c>status</c> field may contain the following values:
/// <list type="bullet">
///   <item><description><c>OK</c> indicates that the request was successful.</description></item>
///   <item><description><c>INVALID_REQUEST</c> indicates that the request was malformed.</description></item>
///   <item><description><c>OVER_DAILY_LIMIT</c> indicates any of the following:
///     <list type="bullet">
///       <item><description>The API key is missing or invalid.</description></item>
///       <item><description>Billing has not been enabled on your account.</description></item>
///       <item><description>A self-imposed usage cap has been exceeded.</description></item>
///       <item><description>The provided method of payment is no longer valid (for example, a credit card has expired).</description></item>
///     </list>
///   </description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>OVER_QUERY_LIMIT</c> indicates the requestor has exceeded quota.</description></item>
///   <item><description><c>REQUEST_DENIED</c> indicates that the API did not complete the request. Confirm that the request was sent over HTTPS instead of HTTP.</description></item>
///   <item><description><c>UNKNOWN_ERROR</c> indicates an unknown error.</description></item>
///   <item><description><c>ZERO_RESULTS</c> indicates that no time zone data could be found for the specified position or time. Confirm that the request is for a location on land, and not over water.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimeZoneStatus>))]
public sealed record TimeZoneStatus : OpenStringEnum<TimeZoneStatus>
{
    private TimeZoneStatus(string value) : base(value)
    {
    }

    public static readonly TimeZoneStatus Ok = new("OK");

    public static readonly TimeZoneStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly TimeZoneStatus OverDailyLimit = new("OVER_DAILY_LIMIT");

    public static readonly TimeZoneStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly TimeZoneStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly TimeZoneStatus UnknownError = new("UNKNOWN_ERROR");

    public static readonly TimeZoneStatus ZeroResults = new("ZERO_RESULTS");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onInvalidRequest,
        Func<TResult> onOverDailyLimit,
        Func<TResult> onOverQueryLimit,
        Func<TResult> onRequestDenied,
        Func<TResult> onUnknownError,
        Func<TResult> onZeroResults,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == OverDailyLimit => onOverDailyLimit(),
            _ when this == OverQueryLimit => onOverQueryLimit(),
            _ when this == RequestDenied => onRequestDenied(),
            _ when this == UnknownError => onUnknownError(),
            _ when this == ZeroResults => onZeroResults(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk,
        Action onInvalidRequest,
        Action onOverDailyLimit,
        Action onOverQueryLimit,
        Action onRequestDenied,
        Action onUnknownError,
        Action onZeroResults,
        Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == InvalidRequest) onInvalidRequest();
        else if (this == OverDailyLimit) onOverDailyLimit();
        else if (this == OverQueryLimit) onOverQueryLimit();
        else if (this == RequestDenied) onRequestDenied();
        else if (this == UnknownError) onUnknownError();
        else if (this == ZeroResults) onZeroResults();
        else otherwise(Value);
    }
}
