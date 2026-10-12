using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record DistanceMatrixRow
{
    /// <summary>
    /// When the Distance Matrix API returns results, it places them within a JSON rows array. Even if no results are returned (such as when the origins and/or destinations don't exist), it still returns an empty array.
    /// <para>
    /// Rows are ordered according to the values in the origin parameter of the request. Each row corresponds to an origin, and each element within that row corresponds to a pairing of the origin with a destination value.
    /// </para>
    /// <para>
    /// Each row array contains one or more element entries, which in turn contain the information about a single origin-destination pairing.
    /// </para>
    /// </summary>
    [JsonPropertyName("elements")]
    public required IReadOnlyList<DistanceMatrixElement> Elements { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
