using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.PlacesApi;

/// <summary>
/// The inputs of the TextSearch operation.
/// </summary>
public sealed record TextSearchRequest
{
    /// <summary>
    /// The text string on which to search, for example: "restaurant" or "123 Main Street". This must a place name, address, or category of establishments. Any other types
    /// of input can generate errors and are not guaranteed to return valid results. The Google Places service will return candidate matches based on this string and order
    /// the results based on their perceived relevance.
    /// </summary>
    public required string Query { get; init; }

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
    /// The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>.
    /// <para>
    /// &lt;div class="note"&gt;The &lt;code&gt;location&lt;/code&gt; parameter may be overriden if the &lt;code&gt;query&lt;/code&gt; contains an explicit location such as &lt;code&gt;Market in Barcelona&lt;/code&gt;. Using quotes around the query may also influence the weight given to the &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt;.&lt;/div&gt;
    /// </para>
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.
    /// </summary>
    public Maxprice1? Maxprice { get; init; }

    /// <summary>
    /// Restricts results to only those places within the specified range. Valid values range between 0 (most affordable) to 4 (most expensive), inclusive. The exact amount indicated by a specific value will vary from region to region.
    /// </summary>
    public Minprice1? Minprice { get; init; }

    /// <summary>
    /// Returns only those places that are open for business at the time the query is sent. Places that do not specify opening hours in the Google Places database will not be returned if you include this parameter in your query.
    /// </summary>
    public bool? Opennow { get; init; }

    /// <summary>
    /// Returns up to 20 results from a previously run search. Setting a <c>pagetoken</c> parameter will execute a search with the same parameters used previously — all parameters other than pagetoken will be ignored.
    /// </summary>
    public string? Pagetoken { get; init; }

    /// <summary>
    /// Restricts the results to places matching the specified type. Only one type may be specified. If more than one type is provided, all types following the first entry are ignored.
    /// <list type="bullet">
    ///   <item><description><c>type=hospital|pharmacy|doctor</c> becomes <c>type=hospital</c></description></item>
    ///   <item><description><c>type=hospital,pharmacy,doctor</c> is ignored entirely</description></item>
    /// </list>
    /// <para>
    /// See the list of <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">supported types</see>.
    /// &lt;div class="note"&gt;Note: Adding both <c>keyword</c> and <c>type</c> with the same value (<c>keyword=cafe&amp;type=cafe</c> or <c>keyword=parking&amp;type=parking</c>) can yield <c>ZERO_RESULTS</c>.&lt;/div&gt;
    /// </para>
    /// </summary>
    public string? Type { get; init; }

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
