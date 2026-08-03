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
public sealed record GeocodingStatus : StringEnum<GeocodingStatus>
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

    public static GeocodingStatus FromValue(string value) => FromValueCore(value);
}
