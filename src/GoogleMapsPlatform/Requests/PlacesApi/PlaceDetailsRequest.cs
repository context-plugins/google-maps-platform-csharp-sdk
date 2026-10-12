using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.PlacesApi;

/// <summary>
/// The inputs of the PlaceDetails operation.
/// </summary>
public sealed record PlaceDetailsRequest
{
    /// <summary>
    /// A textual identifier that uniquely identifies a place, returned from a <see href="https://developers.google.com/maps/documentation/places/web-service/search">Place Search</see>.
    /// For more information about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">place ID overview</see>.
    /// </summary>
    public required string PlaceId { get; init; }

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
    /// A random string which identifies an autocomplete <see href="https://developers.google.com/maps/documentation/places/web-service/details#session_tokens">session</see> for billing purposes.
    /// <para>
    /// The session begins when the user starts typing a query, and concludes when they select a place and a call to Place Details is made. Each session can have multiple queries, followed by one place selection. The API key(s) used for each request within a session must belong to the same Google Cloud Console project. Once a session has concluded, the token is no longer valid; your app must generate a fresh token for each session. If the <c>sessiontoken</c> parameter is omitted, or if you reuse a session token, the session is charged as if no session token was provided (each request is billed separately).
    /// </para>
    /// <para>
    /// We recommend the following guidelines:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Use session tokens for all autocomplete sessions.</description></item>
    ///   <item><description>Generate a fresh token for each session. Using a version 4 UUID is recommended.</description></item>
    ///   <item><description>Ensure that the API key(s) used for all Place Autocomplete and Place Details requests within a session belong to the same Cloud Console project.</description></item>
    ///   <item><description>Be sure to pass a unique session token for each new session. Using the same token for more than one session will result in each request being billed individually.</description></item>
    /// </list>
    /// </summary>
    public string? Sessiontoken { get; init; }

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

    /// <summary>
    /// The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").
    /// </summary>
    public Region1? Region { get; init; }

    /// <summary>
    /// The sorting method to use when returning reviews. Can be set to <c>most_relevant</c> (default) or <c>newest</c>.
    /// <list type="bullet">
    ///   <item><description>For <c>most_relevant</c> (default), reviews are sorted by relevance; the service will bias the results to return reviews originally written in the preferred language.</description></item>
    ///   <item><description>For <c>newest</c>, reviews are sorted in chronological order; the preferred language does not affect the sort order.</description></item>
    /// </list>
    /// <para>
    /// Google recommends that you display how the reviews are being sorted to the end user.
    /// </para>
    /// </summary>
    public string? ReviewsSort { get; init; }

    /// <summary>
    /// Specify <c>reviews_no_translations=true</c> to disable translation of reviews; specify <c>reviews_no_translations=false</c> to enable translation of reviews. Reviews are returned in their original language.
    /// <para>
    /// If omitted, or passed with no value, translation of reviews is enabled. If the <c>language</c> parameter was specified in the request, use the specified language as the preferred language for translation. If <c>language</c> is omitted, the API attempts to use the <c>Accept-Language</c> header as the preferred language.
    /// </para>
    /// </summary>
    public bool? ReviewsNoTranslations { get; init; }
}
