using GoogleMapsPlatform.Core.Configuration;
using GoogleMapsPlatform.Servers;

namespace GoogleMapsPlatform;

public class GoogleMapsPlatformClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public string? ApiKeyAuth { get; set; }
}
