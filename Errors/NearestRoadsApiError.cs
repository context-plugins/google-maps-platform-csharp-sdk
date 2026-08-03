using System.Net.Http;
using System.Threading;
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

    private static NearestRoadsApiError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNearestRoadsErrorResponse(out NearestRoadsErrorResponse value) =>
        _nearestRoadsErrorResponseValue.TryGetValue(out value);

    internal static Task<NearestRoadsApiError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<NearestRoadsErrorResponse>(response, ct).As(AsNearestRoadsErrorResponse),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NearestRoadsApiErrorResponse : IErrorResponse<NearestRoadsApiError>
{
    public static NearestRoadsApiErrorResponse Instance { get; } = new();

    private NearestRoadsApiErrorResponse()
    {
    }

    public Task<NearestRoadsApiError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NearestRoadsApiError.Create(response, ct);
}
