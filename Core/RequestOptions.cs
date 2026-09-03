using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using GoogleMapsPlatform.Core.Hooks;

namespace GoogleMapsPlatform.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
