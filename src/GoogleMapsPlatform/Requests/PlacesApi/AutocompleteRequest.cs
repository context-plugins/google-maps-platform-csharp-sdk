using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.PlacesApi;

/// <summary>
/// The inputs of the Autocomplete operation.
/// </summary>
public sealed record AutocompleteRequest
{
    /// <summary>
    /// The text string on which to search. The Place Autocomplete service will return candidate matches based on this string and order results based on their perceived relevance.
    /// </summary>
    public required string Input { get; init; }

    /// <summary>
    /// Defines the distance (in meters) within which to return place results. You may bias results to a specified circle by passing a <c>location</c> and a <c>radius</c> parameter. Doing so instructs the Places service to _prefer_ showing results within that circle; results outside of the defined area may still be displayed.
    /// <para>
    /// The radius will automatically be clamped to a maximum value depending on the type of search and other parameters.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Autocomplete: 50,000 meters</description></item>
    ///   <item><description>Nearby Search:
    ///     <list type="bullet">
    ///       <item><description>with <c>keyword</c> or <c>name</c>: 50,000 meters</description></item>
    ///       <item><description>without <c>keyword</c> or <c>name</c>
    ///         <list type="bullet">
    ///           <item><description>Up to 50,000 meters, adjusted dynamically based on area density, independent of <c>rankby</c> parameter.</description></item>
    ///           <item><description>When using <c>rankby=distance</c>, the radius parameter will not be accepted, and will result in an <c>INVALID_REQUEST</c>.</description></item>
    ///         </list>
    ///       </description></item>
    ///     </list>
    ///   </description></item>
    ///   <item><description>Query Autocomplete: 50,000 meters</description></item>
    ///   <item><description>Text Search: 50,000 meters</description></item>
    /// </list>
    /// </summary>
    public required double Radius { get; init; }

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
    /// A grouping of places to which you would like to restrict your results. Currently, you can use components to filter by up to 5 countries. Countries must be passed as a two character, ISO 3166-1 Alpha-2 compatible country code. For example: <c>components=country:fr</c> would restrict your results to places within France. Multiple countries must be passed as multiple <c>country:XX</c> filters, with the pipe character <c>|</c> as a separator. For example: <c>components=country:us|country:pr|country:vi|country:gu|country:mp</c> would restrict your results to places within the United States and its unincorporated organized territories.
    /// &lt;div class="note"&gt;&lt;strong&gt;Note:&lt;/strong&gt; If you receive unexpected results with a country code, verify that you are using a code which includes the countries, dependent territories, and special areas of geographical interest you intend.  You can find code information at &lt;a href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes" target="blank" class="external"&gt;Wikipedia: List of ISO 3166 country codes&lt;/a&gt; or the &lt;a href="https://www.iso.org/obp/ui/#search" target="blank" class="external"&gt;ISO Online Browsing Platform&lt;/a&gt;.&lt;/div&gt;
    /// </summary>
    public string? Components { get; init; }

    /// <summary>
    /// Returns only those places that are strictly within the region defined by <c>location</c> and <c>radius</c>. This is a restriction, rather than a bias, meaning that results outside this region will not be returned even if they match the user input.
    /// </summary>
    public bool? Strictbounds { get; init; }

    /// <summary>
    /// The position, in the input term, of the last character that the service uses to match predictions. For example, if the input is <c>Google</c> and the offset is 3, the service will match on <c>Goo</c>. The string determined by the offset is matched against the first word in the input term only. For example, if the input term is <c>Google abc</c> and the offset is 3, the service will attempt to match against <c>Goo abc</c>. If no offset is supplied, the service will use the whole term. The offset should generally be set to the position of the text caret.
    /// </summary>
    public double? Offset { get; init; }

    /// <summary>
    /// The origin point from which to calculate straight-line distance to the destination (returned as <c>distance_meters</c>). If this value is omitted, straight-line distance will not be returned. Must be specified as <c>latitude,longitude</c>.
    /// </summary>
    public string? Origin { get; init; }

    /// <summary>
    /// The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>. The <c>radius</c> parameter must also be provided when specifying a location. If <c>radius</c> is not provided, the <c>location</c> parameter is ignored.
    /// <para>
    /// &lt;div class="note"&gt;When using the Text Search API, the <c>location</c> parameter may be overriden if the <c>query</c> contains an explicit location such as <c>Market in Barcelona</c>.&lt;/div&gt;
    /// </para>
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// Prefer results in a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs representing the points of a rectangle. If this parameter is not specified, the API uses IP address biasing by default.
    /// - IP bias: Instructs the API to use IP address biasing. Pass the string <c>ipbias</c> (this option has no additional parameters).
    /// - Circular: A string specifying radius in meters, plus lat/lng in decimal degrees. Use the following format: <c>circle:radiuslat,lng</c>.
    /// - Rectangular: A string specifying two lat/lng pairs in decimal degrees, representing the south/west and north/east points of a rectangle. Use the following format:<c>rectangle:south,west|north,east</c>. Note that east/west values are wrapped to the range -180, 180, and north/south values are clamped to the range -90, 90.
    /// </summary>
    public string? Locationbias { get; init; }

    /// <summary>
    /// Restrict results to a specified area, by specifying either a radius plus lat/lng, or two lat/lng pairs representing the points of a rectangle.
    /// - Circular: A string specifying radius in meters, plus lat/lng in decimal degrees. Use the following format: <c>circle:radiuslat,lng</c>.
    /// - Rectangular: A string specifying two lat/lng pairs in decimal degrees, representing the south/west and north/east points of a rectangle. Use the following format:<c>rectangle:south,west|north,east</c>. Note that east/west values are wrapped to the range -180, 180, and north/south values are clamped to the range -90, 90.
    /// </summary>
    public string? Locationrestriction { get; init; }

    /// <summary>
    /// You can restrict results from a Place Autocomplete request to be of a certain type by passing the <c>types</c> parameter. This parameter specifies a type or a type collection, as listed in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">Place Types</see>. If nothing is specified, all types are returned.
    /// <para>
    /// For the value of the <c>types</c> parameter you can specify either:
    /// * Up to five values from <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table1">Table 1</see> or <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table2">Table 2</see>. For multiple values, separate each value with a <c>|</c> (vertical bar). For example:
    /// </para>
    /// <para>
    ///   <c>types=book_store|cafe</c>
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Any supported filter in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table3">Table 3</see>. You can safely mix the <c>geocode</c> and <c>establishment</c> types. You cannot mix type collections (<c>address</c>, <c>(cities)</c> or <c>(regions)</c>) with any other type, or an error occurs.</description></item>
    /// </list>
    /// <para>
    /// The request will be rejected with an <c>INVALID_REQUEST</c> error if:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>More than five types are specified.</description></item>
    ///   <item><description>Any unrecognized types are present.</description></item>
    ///   <item><description>Any types from in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table1">Table 1</see> or <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table2">Table 2</see> are mixed with any of the filters in <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table3">Table 3</see>.</description></item>
    /// </list>
    /// </summary>
    public string? Types { get; init; }

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
}
