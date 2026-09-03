using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record PlacesTextSearchResponse
{
    /// <summary>
    /// May contain a set of attributions about this listing which must be displayed to the user (some listings may not have attribution).
    /// </summary>
    [JsonPropertyName("html_attributions")]
    public required IReadOnlyList<string> HtmlAttributions { get; init; }

    /// <summary>
    /// Contains an array of places.
    /// &lt;div class="caution"&gt;Place Search requests return a subset of the fields that are returned by Place Details requests. If the field you want is not returned by Place Search, you can use Place Search to get a <c>place_id</c>, then use that Place ID to make a Place Details request.&lt;/div&gt;
    /// </summary>
    [JsonPropertyName("results")]
    public required IReadOnlyList<Place> Results { get; init; }

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

    /// <summary>
    /// Contains a token that can be used to return up to 20 additional results. A next_page_token will not be returned if there are no additional results to display. The maximum number of results that can be returned is 60. There is a short delay between when a next_page_token is issued, and when it will become valid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
