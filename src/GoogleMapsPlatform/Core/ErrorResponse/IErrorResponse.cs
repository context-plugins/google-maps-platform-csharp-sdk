using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}