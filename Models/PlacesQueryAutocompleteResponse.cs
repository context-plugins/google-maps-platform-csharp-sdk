using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record PlacesQueryAutocompleteResponse
{
    /// <summary>
    /// Contains an array of predictions.
    /// </summary>
    [JsonPropertyName("predictions")]
    public required IReadOnlyList<PlaceAutocompletePrediction> Predictions { get; init; }

    [JsonPropertyName("status")]
    public required PlacesAutocompleteStatus Status { get; init; }

    /// <summary>
    /// When the service returns a status code other than <c>OK</c>, there may be an additional <c>error_message</c> field within the response object. This field contains more detailed information about thereasons behind the given status code. This field is not always returned, and its content is subject to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// When the service returns additional information about the request specification, there may be an additional <c>info_messages</c> field within the response object. This field is only returned for successful requests. It may not always be returned, and its content is subject to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info_messages")]
    public IReadOnlyList<string>? InfoMessages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
