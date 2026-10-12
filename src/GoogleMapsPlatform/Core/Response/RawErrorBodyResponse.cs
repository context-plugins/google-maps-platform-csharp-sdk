using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Core.Response;

internal sealed class RawErrorBodyResponse : IResponse<RawError>
{
    public static RawErrorBodyResponse Instance { get; } = new();

    private RawErrorBodyResponse() { }

    public ValueTask<RawError> Map(ResponseContext context, CancellationToken cancellationToken) =>
        new(RawError.Create(context.Response, cancellationToken));
}
