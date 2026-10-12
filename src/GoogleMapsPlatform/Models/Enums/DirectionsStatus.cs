using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The status field within the Directions response object contains the status of the request, and may contain debugging information to help you track down why the Directions service failed. The status field may contain the following values:
/// <para>
/// - <c>OK</c> indicates the response contains a valid result.
/// - <c>NOT_FOUND</c> indicates at least one of the locations specified in the request's origin, destination, or waypoints could not be geocoded.
/// - <c>ZERO_RESULTS</c> indicates no route could be found between the origin and destination.
/// - <c>MAX_WAYPOINTS_EXCEEDED</c> indicates that too many waypoints were provided in the request. For applications using the Directions API as a web service, or the directions service in the Maps JavaScript API, the maximum allowed number of waypoints is 25, plus the origin and destination.
/// - <c>MAX_ROUTE_LENGTH_EXCEEDED</c> indicates the requested route is too long and cannot be processed. This error occurs when more complex directions are returned. Try reducing the number of waypoints, turns, or instructions.
/// - <c>INVALID_REQUEST</c> indicates that the provided request was invalid. Common causes of this status include an invalid parameter or parameter value.
/// - <c>OVER_DAILY_LIMIT</c> indicates any of the following:
///     - The API key is missing or invalid.
///     - Billing has not been enabled on your account.
///     - A self-imposed usage cap has been exceeded.
///     - The provided method of payment is no longer valid (for example, a credit card has expired).
///     See the <see href="https://developers.google.com/maps/faq#over-limit-key-error">Maps FAQ</see> to learn how to fix this.
/// - <c>OVER_QUERY_LIMIT</c> indicates the service has received too many requests from your application within the allowed time period.
/// - <c>REQUEST_DENIED</c> indicates that the service denied use of the directions service by your application.
/// - <c>UNKNOWN_ERROR</c> indicates a directions request could not be processed due to a server error. The request may succeed if you try again.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DirectionsStatus>))]
public sealed record DirectionsStatus : OpenStringEnum<DirectionsStatus>
{
    private DirectionsStatus(string value) : base(value)
    {
    }

    public static readonly DirectionsStatus Ok = new("OK");

    public static readonly DirectionsStatus NotFound = new("NOT_FOUND");

    public static readonly DirectionsStatus ZeroResults = new("ZERO_RESULTS");

    public static readonly DirectionsStatus MaxWaypointsExceeded = new("MAX_WAYPOINTS_EXCEEDED");

    public static readonly DirectionsStatus MaxRouteLengthExceeded = new("MAX_ROUTE_LENGTH_EXCEEDED");

    public static readonly DirectionsStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly DirectionsStatus OverDailyLimit = new("OVER_DAILY_LIMIT");

    public static readonly DirectionsStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly DirectionsStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly DirectionsStatus UnknownError = new("UNKNOWN_ERROR");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onNotFound,
        Func<TResult> onZeroResults,
        Func<TResult> onMaxWaypointsExceeded,
        Func<TResult> onMaxRouteLengthExceeded,
        Func<TResult> onInvalidRequest,
        Func<TResult> onOverDailyLimit,
        Func<TResult> onOverQueryLimit,
        Func<TResult> onRequestDenied,
        Func<TResult> onUnknownError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == NotFound => onNotFound(),
            _ when this == ZeroResults => onZeroResults(),
            _ when this == MaxWaypointsExceeded => onMaxWaypointsExceeded(),
            _ when this == MaxRouteLengthExceeded => onMaxRouteLengthExceeded(),
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == OverDailyLimit => onOverDailyLimit(),
            _ when this == OverQueryLimit => onOverQueryLimit(),
            _ when this == RequestDenied => onRequestDenied(),
            _ when this == UnknownError => onUnknownError(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk,
        Action onNotFound,
        Action onZeroResults,
        Action onMaxWaypointsExceeded,
        Action onMaxRouteLengthExceeded,
        Action onInvalidRequest,
        Action onOverDailyLimit,
        Action onOverQueryLimit,
        Action onRequestDenied,
        Action onUnknownError,
        Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == NotFound) onNotFound();
        else if (this == ZeroResults) onZeroResults();
        else if (this == MaxWaypointsExceeded) onMaxWaypointsExceeded();
        else if (this == MaxRouteLengthExceeded) onMaxRouteLengthExceeded();
        else if (this == InvalidRequest) onInvalidRequest();
        else if (this == OverDailyLimit) onOverDailyLimit();
        else if (this == OverQueryLimit) onOverQueryLimit();
        else if (this == RequestDenied) onRequestDenied();
        else if (this == UnknownError) onUnknownError();
        else otherwise(Value);
    }
}
