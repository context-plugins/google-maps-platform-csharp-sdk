using GoogleMapsPlatform.Core.Authentication;
using GoogleMapsPlatform.Core.Authentication.ApiKey;

namespace GoogleMapsPlatform;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKeyAuth { get; }

    public AuthSchemes(GoogleMapsPlatformClientOptions options)
    {
        ApiKeyAuth = ApiKeyQueryScheme.Create("key", options.ApiKeyAuth);
    }
}
