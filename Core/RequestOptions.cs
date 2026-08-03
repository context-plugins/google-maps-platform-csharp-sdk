using Microsoft.Extensions.Logging;

namespace GoogleMapsPlatform.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
