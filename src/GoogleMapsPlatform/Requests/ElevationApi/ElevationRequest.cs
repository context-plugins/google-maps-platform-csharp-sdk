using System.Collections.Generic;

namespace GoogleMapsPlatform.Requests.ElevationApi;

/// <summary>
/// The inputs of the Elevation operation.
/// </summary>
public sealed record ElevationRequest
{
    /// <summary>
    /// Positional requests are indicated through use of the locations parameter, indicating elevation requests for the specific locations passed as latitude/longitude values.
    /// <para>
    /// The locations parameter may take the following arguments:
    /// </para>
    /// <para>
    /// - A single coordinate: <c>locations=40.714728,-73.998672</c>
    /// - An array of coordinates separated using the pipe ('|') character:
    ///   ```
    ///   locations=40.714728,-73.998672|-34.397,150.644
    ///   ```
    /// - A set of encoded coordinates using the <see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm">Encoded Polyline Algorithm</see>:
    ///   ```
    ///   locations=enc:gfo}EtohhU
    ///   ```
    /// </para>
    /// <para>
    /// Latitude and longitude coordinate strings are defined using numerals within a comma-separated text string. For example, "40.714728,-73.998672" is a valid locations value. Latitude and longitude values must correspond to a valid location on the face of the earth. Latitudes can take any value between -90 and 90 while longitude values can take any value between -180 and 180. If you specify an invalid latitude or longitude value, your request will be rejected as a bad request.
    /// </para>
    /// <para>
    /// You may pass any number of multiple coordinates within an array or encoded polyline, while still constructing a valid URL. Note that when passing multiple coordinates, the accuracy of any returned data may be of lower resolution than when requesting data for a single coordinate.
    /// </para>
    /// </summary>
    public IReadOnlyList<string>? Locations { get; init; }

    /// <summary>
    /// An array of comma separated <c>latitude,longitude</c> strings.
    /// </summary>
    public IReadOnlyList<string>? Path { get; init; }

    /// <summary>
    /// Required if path parameter is set.
    /// </summary>
    public double? Samples { get; init; }
}
