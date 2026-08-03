using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Status codes returned by service.
/// - <c>OK</c> indicating the API request was successful.
/// - <c>ZERO_RESULTS</c> indicating that the search was successful but returned no results. This may occur if the search was passed a bounds in a remote location.
/// - <c>INVALID_REQUEST</c> indicating the API request was malformed, generally due to the missing <c>input</c> parameter.
/// - <c>OVER_QUERY_LIMIT</c> indicating any of the following:
///   - You have exceeded the QPS limits.
///   - Billing has not been enabled on your account.
///   - The monthly $200 credit, or a self-imposed usage cap, has been exceeded.
///   - The provided method of payment is no longer valid (for example, a credit card has expired).
///   See the <see href="https://developers.google.com/maps/faq#over-limit-key-error">Maps FAQ</see> for more information about how to resolve this error.
/// - <c>REQUEST_DENIED</c> indicating that your request was denied, generally because:
///   - The request is missing an API key.
///   - The <c>key</c> parameter is invalid.
/// - <c>UNKNOWN_ERROR</c> indicating an unknown error.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlacesAutocompleteStatus>))]
public sealed record PlacesAutocompleteStatus : StringEnum<PlacesAutocompleteStatus>
{
    private PlacesAutocompleteStatus(string value) : base(value)
    {
    }

    public static readonly PlacesAutocompleteStatus Ok = new("OK");

    public static readonly PlacesAutocompleteStatus ZeroResults = new("ZERO_RESULTS");

    public static readonly PlacesAutocompleteStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly PlacesAutocompleteStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly PlacesAutocompleteStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly PlacesAutocompleteStatus UnknownError = new("UNKNOWN_ERROR");

    public static PlacesAutocompleteStatus FromValue(string value) => FromValueCore(value);
}
