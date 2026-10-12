using System.Collections.Generic;

namespace GoogleMapsPlatform.Requests.RoadsApi;

/// <summary>
/// The inputs of the NearestRoads operation.
/// </summary>
public sealed record NearestRoadsRequest
{
    /// <summary>
    /// The points to be snapped. The points parameter accepts a list of latitude/longitude pairs. Separate latitude and longitude values with commas. Separate coordinates with the pipe character: "|". For example: <c>points=60.170880,24.942795|60.170879,24.942796|60.170877,24.942796</c>.
    /// </summary>
    public required IReadOnlyList<string> Points { get; init; }
}
