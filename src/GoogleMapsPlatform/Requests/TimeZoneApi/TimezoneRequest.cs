using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.TimeZoneApi;

/// <summary>
/// The inputs of the Timezone operation.
/// </summary>
public sealed record TimezoneRequest
{
    /// <summary>
    /// A comma-separated latitude,longitude tuple, <c>location=39.6034810,-119.6822510</c>, representing the location to look up.
    /// </summary>
    public required string Location { get; init; }

    /// <summary>
    /// The desired time as seconds since midnight, January 1, 1970 UTC. The Time Zone API uses the <c>timestamp</c> to determine whether or not Daylight Savings should be applied, based on the time zone of the <c>location</c>.
    /// <para>
    /// Note that the API does not take historical time zones into account. That is, if you specify a past timestamp, the API does not take into account the possibility that the location was previously in a different time zone.
    /// </para>
    /// </summary>
    public required double Timestamp { get; init; }

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
