using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record MapsApiElevationJsonResponse
{
    /// <summary>
    /// When the service returns a status code other than <c>OK&lt;</c>, there may be an additional <c>error_message</c> field within the response object. This field contains more detailed information about thereasons behind the given status code. This field is not always returned, and its content is subject to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }

    [JsonPropertyName("status")]
    public required ElevationStatus Status { get; init; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<Result> Results { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
