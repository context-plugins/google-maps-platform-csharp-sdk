using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record PlacesFindPlaceFromTextResponse
{
    /// <summary>
    /// Contains an array of Place candidates.
    /// &lt;div class="caution"&gt;Place Search requests return a subset of the fields that are returned by Place Details requests. If the field you want is not returned by Place Search, you can use Place Search to get a place_id, then use that Place ID to make a Place Details request.&lt;/div&gt;
    /// </summary>
    [JsonPropertyName("candidates")]
    public required IReadOnlyList<Place> Candidates { get; init; }

    [JsonPropertyName("status")]
    public required PlacesSearchStatus Status { get; init; }

    /// <summary>
    /// When the service returns a status code other than <c>OK&lt;</c>, there may be an additional <c>error_message</c> field within the response object. This field contains more detailed information about thereasons behind the given status code. This field is not always returned, and its content is subject to change.
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
}
