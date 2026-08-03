using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Status codes returned by service.
/// - <c>OK</c> indicating the API request was successful.
/// - <c>DATA_NOT_AVAILABLE</c> indicating that there's no available data for the input locations.
/// - <c>INVALID_REQUEST</c> indicating the API request was malformed.
/// - <c>OVER_DAILY_LIMIT</c> indicating any of the following:
///   - The API key is missing or invalid.
///   - Billing has not been enabled on your account.
///   - A self-imposed usage cap has been exceeded.
///   - The provided method of payment is no longer valid (for example, a credit card has expired).
/// - <c>OVER_QUERY_LIMIT</c> indicating the requestor has exceeded quota.
/// - <c>REQUEST_DENIED</c> indicating the API did not complete the request.
/// - <c>UNKNOWN_ERROR</c> indicating an unknown error.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ElevationStatus>))]
public sealed record ElevationStatus : StringEnum<ElevationStatus>
{
    private ElevationStatus(string value) : base(value)
    {
    }

    public static readonly ElevationStatus Ok = new("OK");

    public static readonly ElevationStatus DataNotAvailable = new("DATA_NOT_AVAILABLE");

    public static readonly ElevationStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly ElevationStatus OverDailyLimit = new("OVER_DAILY_LIMIT");

    public static readonly ElevationStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly ElevationStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly ElevationStatus UnknownError = new("UNKNOWN_ERROR");

    public static ElevationStatus FromValue(string value) => FromValueCore(value);
}
