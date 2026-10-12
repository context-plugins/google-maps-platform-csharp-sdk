using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.PlacesApi;

/// <summary>
/// The inputs of the QueryAutocomplete operation.
/// </summary>
public sealed record QueryAutocompleteRequest
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
    /// The position, in the input term, of the last character that the service uses to match predictions. For example, if the input is <c>Google</c> and the offset is 3, the service will match on <c>Goo</c>. The string determined by the offset is matched against the first word in the input term only. For example, if the input term is <c>Google abc</c> and the offset is 3, the service will attempt to match against <c>Goo abc</c>. If no offset is supplied, the service will use the whole term. The offset should generally be set to the position of the text caret.
    /// </summary>
    public double? Offset { get; init; }

    /// <summary>
    /// The point around which to retrieve place information. This must be specified as <c>latitude,longitude</c>.
    /// <para>
    /// &lt;div class="note"&gt;The &lt;code&gt;location&lt;/code&gt; parameter may be overriden if the &lt;code&gt;query&lt;/code&gt; contains an explicit location such as &lt;code&gt;Market in Barcelona&lt;/code&gt;. Using quotes around the query may also influence the weight given to the &lt;code&gt;location&lt;/code&gt; and &lt;code&gt;radius&lt;/code&gt;.&lt;/div&gt;
    /// </para>
    /// </summary>
    public string? Location { get; init; }

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
