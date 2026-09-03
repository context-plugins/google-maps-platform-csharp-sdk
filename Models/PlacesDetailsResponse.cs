using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record PlacesDetailsResponse
{
    /// <summary>
    /// May contain a set of attributions about this listing which must be displayed to the user (some listings may not have attribution).
    /// </summary>
    [JsonPropertyName("html_attributions")]
    public required IReadOnlyList<string> HtmlAttributions { get; init; }

    [JsonPropertyName("result")]
    public required Result2 Result { get; init; }

    [JsonPropertyName("status")]
    public required PlacesDetailsStatus Status { get; init; }

    /// <summary>
    /// When the service returns additional information about the request specification, there may be an additional <c>info_messages</c> field within the response object. This field is only returned for successful requests. It may not always be returned, and its content is subject to change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info_messages")]
    public IReadOnlyList<string>? InfoMessages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
