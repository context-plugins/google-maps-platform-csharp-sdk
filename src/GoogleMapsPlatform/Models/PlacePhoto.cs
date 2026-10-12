using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// A photo of a Place. The photo can be accesed via the <see href="https://developers.google.com/places/web-service/photos">Place Photo</see> API using an url in the following pattern:
/// <code>
/// https://maps.googleapis.com/maps/api/place/photo?maxwidth=400&amp;photo_reference=photo_reference&amp;key=YOUR_API_KEY
/// </code>
/// <para>
/// See <see href="https://developers.google.com/places/web-service/photos">Place Photos</see> for more information.
/// </para>
/// </summary>
public record PlacePhoto
{
    /// <summary>
    /// The height of the photo.
    /// </summary>
    [JsonPropertyName("height")]
    public required double Height { get; init; }

    /// <summary>
    /// The width of the photo.
    /// </summary>
    [JsonPropertyName("width")]
    public required double Width { get; init; }

    /// <summary>
    /// The HTML attributions for the photo.
    /// </summary>
    [JsonPropertyName("html_attributions")]
    public required IReadOnlyList<string> HtmlAttributions { get; init; }

    /// <summary>
    /// A string used to identify the photo when you perform a Photo request.
    /// </summary>
    [JsonPropertyName("photo_reference")]
    public required string PhotoReference { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
