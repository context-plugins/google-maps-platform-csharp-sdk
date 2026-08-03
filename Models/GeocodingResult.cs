using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record GeocodingResult
{
    /// <summary>
    /// An array containing the separate components applicable to this address.
    /// </summary>
    [JsonPropertyName("address_components")]
    public required IReadOnlyList<AddressComponent> AddressComponents { get; init; }

    /// <summary>
    /// The human-readable address of this location.
    /// </summary>
    [JsonPropertyName("formatted_address")]
    public required string FormattedAddress { get; init; }

    [JsonPropertyName("geometry")]
    public required Geometry1 Geometry { get; init; }

    /// <summary>
    /// A unique identifier that can be used with other Google APIs. For example, you can use the <c>place_id</c> in a Places API request to get details of a local business, such as phone number, opening hours, user reviews, and more. See the <see href="https://developers.google.com/places/place-id">place ID overview</see>.
    /// </summary>
    [JsonPropertyName("place_id")]
    public required string PlaceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plus_code")]
    public PlusCode1? PlusCode { get; init; }

    /// <summary>
    /// The <c>types[]</c> array indicates the type of the returned result. This array contains a set of zero or more tags identifying the type of feature returned in the result. For example, a geocode of "Chicago" returns "locality" which indicates that "Chicago" is a city, and also returns "political" which indicates it is a political entity.
    /// </summary>
    [JsonPropertyName("types")]
    public required IReadOnlyList<string> Types { get; init; }

    /// <summary>
    /// An array denoting all the localities contained in a postal code. This is only present when the result is a postal code that contains multiple localities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postcode_localities")]
    public IReadOnlyList<string>? PostcodeLocalities { get; init; }

    /// <summary>
    /// Indicates that the geocoder did not return an exact match for the original request, though it was able to match part of the requested address. You may wish to examine the original request for misspellings and/or an incomplete address.
    /// <para>
    /// Partial matches most often occur for street addresses that do not exist within the locality you pass in the request. Partial matches may also be returned when a request matches two or more locations in the same locality.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partial_match")]
    public bool? PartialMatch { get; init; }
}
