using System.Net.Http;

namespace GoogleMapsPlatform.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}