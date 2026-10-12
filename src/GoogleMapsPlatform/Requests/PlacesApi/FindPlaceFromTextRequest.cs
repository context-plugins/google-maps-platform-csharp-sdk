using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.PlacesApi;

/// <summary>
/// The inputs of the FindPlaceFromText operation.
/// </summary>
public sealed record FindPlaceFromTextRequest
{
    /// <summary>
    /// The text string on which to search, for example: "restaurant" or "123 Main Street". This must be a place name, address, or category of establishments. Any other types of input can generate errors
    /// and are not guaranteed to return valid results. The Places API will return candidate matches based on this string and order the results based on their perceived relevance.
    /// </summary>
    public required string Input { get; init; }

    /// <summary>
    /// The type of input. This can be one of either <c>textquery</c> or <c>phonenumber</c>. Phone numbers must be in international format (prefixed by a plus sign ("+"), followed by the country code, then the phone number itself). See <see href="https://en.wikipedia.org/wiki/E.164">E.164 ITU recommendation</see> for more information.
    /// </summary>
    public required Inputtype1 Inputtype { get; init; }

    /// <summary>
    /// &lt;div class="caution"&gt; Caution: Place Search requests and Place Details requests do not return the same fields. Place Search requests return a subset of the fields that are returned by Place Details requests. If the field you want is not returned by Place Search, you can use Place Search to get a &lt;code&gt;place_id&lt;/code&gt;, then use that Place ID to make a Place Details request. For more information on the fields that are unavailable in a Place Search request, see &lt;a href="https://developers.google.com/maps/documentation/places/web-service/place-data-fields#places-api-fields-support"&gt;Places API fields support&lt;/a&gt;.&lt;/div&gt;
    /// <para>
    /// Use the fields parameter to specify a comma-separated list of place data types to return. For example: <c>fields=formatted_address,name,geometry</c>. Use a forward slash when specifying compound values. For example: <c>opening_hours/open_now</c>.
    /// </para>
    /// <para>
    /// Fields are divided into three billing categories: Basic, Contact, and Atmosphere. Basic fields are billed at base rate, and incur no additional charges. Contact and Atmosphere fields are billed at a higher rate. See the <see href="https://developers.google.com/maps/documentation/places/web-service/usage-and-billing/">pricing sheet</see> for more information. Attributions, <c>html_attributions</c>, are always returned with every call, regardless of whether the field has been requested.
    /// </para>
    /// <para>
    /// <b>Basic</b>
    /// </para>
    /// <para>
    /// The Basic category includes the following fields: <c>address_components</c>, <c>adr_address</c>, <c>business_status</c>, <c>formatted_address</c>, <c>geometry</c>, <c>icon</c>, <c>icon_mask_base_uri</c>, <c>icon_background_color</c>, <c>name</c>, <c>permanently_closed</c> (<see href="https://developers.google.com/maps/deprecations">deprecated</see>), <c>photo</c>, <c>place_id</c>, <c>plus_code</c>, <c>type</c>, <c>url</c>, <c>utc_offset</c>, <c>vicinity</c>, <c>wheelchair_accessible_entrance</c>.
    /// </para>
    /// <para>
    /// <b>Contact</b>
    /// </para>
    /// <para>
    /// The Contact category includes the following fields: <c>current_opening_hours</c>, <c>formatted_phone_number</c>, <c>international_phone_number</c>, <c>opening_hours</c>, <c>secondary_opening_hours</c>, <c>website</c>
    /// </para>
    /// <para>
    /// <b>Atmosphere</b>
    /// </para>
    /// <para>
    /// The Atmosphere category includes the following fields: <c>curbside_pickup</c>, <c>delivery</c>, <c>dine_in</c>, <c>editorial_summary</c>, <c>price_level</c>, <c>rating</c>, <c>reservable</c>, <c>reviews</c>, <c>serves_beer</c>, <c>serves_breakfast</c>, <c>serves_brunch</c>, <c>serves_dinner</c>, <c>serves_lunch</c>, <c>serves_vegetarian_food</c>, <c>serves_wine</c>, <c>takeout</c>, <c>user_ratings_total</c>.
    /// </para>
    /// </summary>
    [MinLength(1)]
    public IReadOnlyList<string>? Fields { get; init; }

    /// <summary>
    /// Prefer results in a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs representing the points of a rectangle. If this parameter is not specified, the API uses IP address biasing by default.
    /// - IP bias: Instructs the API to use IP address biasing. Pass the string <c>ipbias</c> (this option has no additional parameters).
    /// - Circular: A string specifying radius in meters, plus lat/lng in decimal degrees. Use the following format: <c>circle:radiuslat,lng</c>.
    /// - Rectangular: A string specifying two lat/lng pairs in decimal degrees, representing the south/west and north/east points of a rectangle. Use the following format:<c>rectangle:south,west|north,east</c>. Note that east/west values are wrapped to the range -180, 180, and north/south values are clamped to the range -90, 90.
    /// </summary>
    public string? Locationbias { get; init; }

    /// <summary>
    /// The language in which to return results.
    /// <list type="bullet">
    ///   <item><description>See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive.</description></item>
    ///   <item><description>If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header.</description></item>
    ///   <item><description>The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component.</description></item>
    ///   <item><description>If a name is not available in the preferred language, the API uses the closest match.</description></item>
    ///   <item><description>The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</description></item>
    /// </list>
    /// </summary>
    public Language1? Language { get; init; }
}
