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
public sealed record TimeZoneStatus : StringEnum<TimeZoneStatus>
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

    public static TimeZoneStatus FromValue(string value) => FromValueCore(value);
}
