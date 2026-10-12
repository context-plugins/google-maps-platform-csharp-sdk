using System.Threading.Tasks;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models;

namespace GoogleMapsPlatform.Errors;

public sealed class NearestRoadsApiError : ApiError
{
    private readonly Optional<NearestRoadsErrorResponse> _nearestRoadsErrorResponseValue;

    private NearestRoadsApiError(Optional<NearestRoadsErrorResponse> nearestRoadsErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _nearestRoadsErrorResponseValue = nearestRoadsErrorResponseValue;
    }

    private static NearestRoadsApiError AsNearestRoadsErrorResponse(NearestRoadsErrorResponse value) =>
        new(Optional<NearestRoadsErrorResponse>.Some(value), default);

    private static NearestRoadsApiError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNearestRoadsErrorResponse(out NearestRoadsErrorResponse value) =>
        _nearestRoadsErrorResponseValue.TryGetValue(out value);

    private static Task<NearestRoadsApiError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<NearestRoadsErrorResponse>().As(AsNearestRoadsErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<NearestRoadsApiError> Response { get; } = new(Create);
}
