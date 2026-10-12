using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The <c>status</c> field within the Geocoding response object contains the status of the request, and may contain debugging information to help you track down why geocoding is not working. The "status" field may contain the following values:
/// <list type="bullet">
///   <item><description><c>OK</c> indicates that no errors occurred; the address was successfully parsed and at least one geocode was returned.</description></item>
///   <item><description><c>ZERO_RESULTS</c> indicates that the geocode was successful but returned no results. This may occur if the geocoder was passed a non-existent address or a <c>latlng</c> in a remote location.</description></item>
///   <item><description><c>OVER_DAILY_LIMIT</c> indicates any of the following:
///     <list type="bullet">
///       <item><description>The API key is missing or invalid.</description></item>
///       <item><description>Billing has not been enabled on your account.</description></item>
///       <item><description>A self-imposed usage cap has been exceeded.</description></item>
///       <item><description>The provided method of payment is no longer valid (for example, a credit card has expired).</description></item>
///     </list>
///   </description></item>
///   <item><description><c>OVER_QUERY_LIMIT</c> indicates that you are over your quota.</description></item>
///   <item><description><c>REQUEST_DENIED</c> indicates that your request was denied.</description></item>
///   <item><description><c>INVALID_REQUEST</c> generally indicates that the query (address, components, or latlng) is missing.</description></item>
///   <item><description><c>UNKNOWN_ERROR</c> indicates that the request could not be processed due to a server error. The request may succeed if you try again.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GeocodingStatus>))]
public sealed record GeocodingStatus : OpenStringEnum<GeocodingStatus>
{
    private GeocodingStatus(string value) : base(value)
    {
    }

    public static readonly GeocodingStatus Ok = new("OK");

    public static readonly GeocodingStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly GeocodingStatus OverDailyLimit = new("OVER_DAILY_LIMIT");

    public static readonly GeocodingStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly GeocodingStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly GeocodingStatus UnknownError = new("UNKNOWN_ERROR");

    public static readonly GeocodingStatus ZeroResults = new("ZERO_RESULTS");

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
