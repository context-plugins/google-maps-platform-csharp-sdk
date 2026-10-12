using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The <c>status</c> field within the Streetview Metadata response object contains the status of the request. The <c>status</c> field may contain the following values:
/// <list type="bullet">
///   <item><description><c>OK</c> indicates that no errors occurred; a panorama is found and metadata is returned.</description></item>
///   <item><description><c>INVALID_REQUEST</c> indicates that the request was malformed.</description></item>
///   <item><description><c>NOT_FOUND</c> indicates that the address string provided in the <c>location</c> parameter could not be found. This may occur if a non-existent address is given.</description></item>
///   <item><description><c>ZERO_RESULTS</c> indicates that no panorama could be found near the provided location. This may occur if a non-existent or invalid <c>pano</c> id is given.</description></item>
///   <item><description><c>OVER_QUERY_LIMIT</c> indicates the requestor has exceeded quota.</description></item>
///   <item><description><c>REQUEST_DENIED</c> indicates that your request was denied. This may occur if you did not <see href="https://developers.google.com/maps/documentation/streetview/get-api-key">authorize</see> your request, or if the Street View Static API is not activated in the Google Cloud Console project containing your API key.</description></item>
///   <item><description><c>UNKNOWN_ERROR</c> indicates that the request could not be processed due to a server error. This is often a temporary status. The request may succeed if you try again</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StreetViewStatus>))]
public sealed record StreetViewStatus : OpenStringEnum<StreetViewStatus>
{
    private StreetViewStatus(string value) : base(value)
    {
    }

    public static readonly StreetViewStatus Ok = new("OK");

    public static readonly StreetViewStatus InvalidRequest = new("INVALID_REQUEST");

    public static readonly StreetViewStatus NotFound = new("NOT_FOUND");

    public static readonly StreetViewStatus ZeroResults = new("ZERO_RESULTS");

    public static readonly StreetViewStatus OverQueryLimit = new("OVER_QUERY_LIMIT");

    public static readonly StreetViewStatus RequestDenied = new("REQUEST_DENIED");

    public static readonly StreetViewStatus UnknownError = new("UNKNOWN_ERROR");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onInvalidRequest,
        Func<TResult> onNotFound,
        Func<TResult> onZeroResults,
        Func<TResult> onOverQueryLimit,
        Func<TResult> onRequestDenied,
        Func<TResult> onUnknownError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == NotFound => onNotFound(),
            _ when this == ZeroResults => onZeroResults(),
            _ when this == OverQueryLimit => onOverQueryLimit(),
            _ when this == RequestDenied => onRequestDenied(),
            _ when this == UnknownError => onUnknownError(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk,
        Action onInvalidRequest,
        Action onNotFound,
        Action onZeroResults,
        Action onOverQueryLimit,
        Action onRequestDenied,
        Action onUnknownError,
        Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == InvalidRequest) onInvalidRequest();
        else if (this == NotFound) onNotFound();
        else if (this == ZeroResults) onZeroResults();
        else if (this == OverQueryLimit) onOverQueryLimit();
        else if (this == RequestDenied) onRequestDenied();
        else if (this == UnknownError) onUnknownError();
        else otherwise(Value);
    }
}
