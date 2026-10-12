using System.Collections.Generic;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.DistanceMatrixApi;

/// <summary>
/// The inputs of the DistanceMatrix operation.
/// </summary>
public sealed record DistanceMatrixRequest
{
    /// <summary>
    /// One or more locations to use as the finishing point for calculating travel distance and time. The options for the destinations parameter are the same as for the origins parameter.
    /// </summary>
    public required IReadOnlyList<string> Destinations { get; init; }

    /// <summary>
    /// The starting point for calculating travel distance and time. You can supply one or more locations separated by the pipe character (|), in the form of a place ID, an address, or latitude/longitude coordinates:
    /// - <b>Place ID</b>: If you supply a place ID, you must prefix it with <c>place_id:</c>.
    /// - <b>Address</b>: If you pass an address, the service geocodes the string and converts it to a latitude/longitude coordinate to calculate distance. This coordinate may be different from that returned by the Geocoding API, for example a building entrance rather than its center.
    ///   &lt;div class="note"&gt;Note: using place IDs is preferred over using addresses or latitude/longitude coordinates. Using coordinates will always result in the point being snapped to the road nearest to those coordinates - which may not be an access point to the property, or even a road that will quickly or safely lead to the destination. Using the address will provide the distance to the center of the building, as opposed to an entrance to the building.&lt;/div&gt;
    /// - <b>Coordinates</b>: If you pass latitude/longitude coordinates, they they will snap to the nearest road. Passing a place ID is preferred. If you do pass coordinates, ensure that no space exists between the latitude and longitude values.
    /// - <b>Plus codes</b> must be formatted as a global code or a compound code. Format plus codes as shown here (plus signs are url-escaped to %2B and spaces are url-escaped to %20):
    ///   - <b>global code</b> is a 4 character area code and 6 character or longer local code (<c>849VCWC8+R9</c> is encoded to <c>849VCWC8%2BR9</c>).
    ///   - <b>compound code</b> is a 6 character or longer local code with an explicit location (<c>CWC8+R9 Mountain View, CA, USA</c> is encoded to <c>CWC8%2BR9%20Mountain%20View%20CA%20USA</c>).
    /// - <b>Encoded Polyline</b> Alternatively, you can supply an encoded set of coordinates using the <see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm">Encoded Polyline Algorithm</see>. This is particularly useful if you have a large number of origin points, because the URL is significantly shorter when using an encoded polyline.
    ///   - Encoded polylines must be prefixed with <c>enc:</c> and followed by a colon <c>:</c>. For example: <c>origins=enc:gfo}EtohhU:</c>
    ///   - You can also include multiple encoded polylines, separated by the pipe character <c>|</c>. For example:
    ///     ```
    ///     origins=enc:wc~oAwquwMdlTxiKtqLyiK:|enc:c~vnAamswMvlTortjGi}L:|enc:udymA{~bxM:
    ///     ```
    /// </summary>
    public required IReadOnlyList<string> Origins { get; init; }

    /// <summary>
    /// Specifies the desired time of arrival for transit directions, in seconds since midnight, January 1, 1970 UTC. You can specify either <c>departure_time</c> or <c>arrival_time</c>, but not both. Note that <c>arrival_time</c> must be specified as an integer.
    /// </summary>
    public double? ArrivalTime { get; init; }

    /// <summary>
    /// Specifies the desired time of departure. You can specify the time as an integer in seconds since midnight, January 1, 1970 UTC. If a <c>departure_time</c> later than 9999-12-31T23:59:59.999999999Z is specified, the API will fall back the <c>departure_time</c> to 9999-12-31T23:59:59.999999999Z. Alternatively, you can specify a value of now, which sets the departure time to the current time (correct to the nearest second). The departure time may be specified in two cases:
    /// * For requests where the travel mode is transit: You can optionally specify one of <c>departure_time</c> or <c>arrival_time</c>. If neither time is specified, the <c>departure_time</c> defaults to now (that is, the departure time defaults to the current time).
    /// * For requests where the travel mode is driving: You can specify the <c>departure_time</c> to receive a route and trip duration (response field: duration_in_traffic) that take traffic conditions into account. The <c>departure_time</c> must be set to the current time or some time in the future. It cannot be in the past.
    /// <para>
    /// &lt;div class="note"&gt;Note: If departure time is not specified, choice of route and duration are based on road network and average time-independent traffic conditions. Results for a given request may vary over time due to changes in the road network, updated average traffic conditions, and the distributed nature of the service. Results may also vary between nearly-equivalent routes at any time or frequency.&lt;/div&gt;
    /// &lt;div class="note"&gt;Note: Distance Matrix requests specifying <c>departure_time</c> when <c>mode=driving</c> are limited to a maximum of 100 elements per request. The number of origins times the number of destinations defines the number of elements.&lt;/div&gt;
    /// </para>
    /// </summary>
    public double? DepartureTime { get; init; }

    /// <summary>
    /// Distances may be calculated that adhere to certain restrictions. Restrictions are indicated by use of the avoid parameter, and an argument to that parameter indicating the restriction to avoid. The following restrictions are supported:
    /// <list type="bullet">
    ///   <item><description><c>tolls</c> indicates that the calculated route should avoid toll roads/bridges.</description></item>
    ///   <item><description><c>highways</c> indicates that the calculated route should avoid highways.</description></item>
    ///   <item><description><c>ferries</c> indicates that the calculated route should avoid ferries.</description></item>
    ///   <item><description><c>indoor</c> indicates that the calculated route should avoid indoor steps for walking and transit directions.</description></item>
    /// </list>
    /// <para>
    /// &lt;div class="note"&gt;Note: The addition of restrictions does not preclude routes that include the restricted feature; it biases the result to more favorable routes.&lt;/div&gt;
    /// </para>
    /// </summary>
    public string? Avoid { get; init; }

    /// <summary>
    /// Specifies the unit system to use when displaying results.
    /// <para>
    /// &lt;div class="note"&gt;Note: this unit system setting only affects the text displayed within distance fields. The distance fields also contain values which are always expressed in meters.&lt;/div&gt;
    /// </para>
    /// </summary>
    public Units2? Units { get; init; }

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
    /// For the calculation of distances and directions, you may specify the transportation mode to use. By default, <c>DRIVING</c> mode is used. By default, directions are calculated as driving directions. The following travel modes are supported:
    /// <list type="bullet">
    ///   <item><description><c>driving</c> (default) indicates standard driving directions or distance using the road network.</description></item>
    ///   <item><description><c>walking</c> requests walking directions or distance via pedestrian paths &amp; sidewalks (where available).</description></item>
    ///   <item><description><c>bicycling</c> requests bicycling directions or distance via bicycle paths &amp; preferred streets (where available).</description></item>
    ///   <item><description><c>transit</c> requests directions or distance via public transit routes (where available). Transit trips are available for up to 7 days in the past or 100 days in the future. If you set the mode to transit, you can optionally specify either a <c>departure_time</c> or an <c>arrival_time</c>. If neither time is specified, the <c>departure_time</c> defaults to now (that is, the departure time defaults to the current time). You can also optionally include a <c>transit_mode</c> and/or a <c>transit_routing_preference</c>.</description></item>
    /// </list>
    /// <para>
    /// &lt;div class="note"&gt;Note: Both walking and bicycling directions may sometimes not include clear pedestrian or bicycling paths, so these directions will return warnings in the returned result which you must display to the user.&lt;/div&gt;
    /// </para>
    /// </summary>
    public Mode1? Mode { get; init; }

    /// <summary>
    /// The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").
    /// </summary>
    public Region1? Region { get; init; }

    /// <summary>
    /// Specifies the assumptions to use when calculating time in traffic. This setting affects the value returned in the duration_in_traffic field in the response, which contains the predicted time in traffic based on historical averages. The <c>traffic_model</c> parameter may only be specified for driving directions where the request includes a <c>departure_time</c>. The available values for this parameter are:
    /// * <c>best_guess</c> (default) indicates that the returned duration_in_traffic should be the best estimate of travel time given what is known about both historical traffic conditions and live traffic. Live traffic becomes more important the closer the <c>departure_time</c> is to now.
    /// * <c>pessimistic</c> indicates that the returned duration_in_traffic should be longer than the actual travel time on most days, though occasional days with particularly bad traffic conditions may exceed this value.
    /// * <c>optimistic</c> indicates that the returned duration_in_traffic should be shorter than the actual travel time on most days, though occasional days with particularly good traffic conditions may be faster than this value.
    /// The default value of <c>best_guess</c> will give the most useful predictions for the vast majority of use cases. It is possible the <c>best_guess</c> travel time prediction may be shorter than <c>optimistic</c>, or alternatively, longer than <c>pessimistic</c>, due to the way the <c>best_guess</c> prediction model integrates live traffic information.
    /// </summary>
    public TrafficModel1? TrafficModel { get; init; }

    /// <summary>
    /// Specifies one or more preferred modes of transit. This parameter may only be specified for transit directions. The parameter supports the following arguments:
    /// * <c>bus</c> indicates that the calculated route should prefer travel by bus.
    /// * <c>subway</c> indicates that the calculated route should prefer travel by subway.
    /// * <c>train</c> indicates that the calculated route should prefer travel by train.
    /// * <c>tram</c> indicates that the calculated route should prefer travel by tram and light rail.
    /// * <c>rail</c> indicates that the calculated route should prefer travel by train, tram, light rail, and subway. This is equivalent to <c>transit_mode=train|tram|subway</c>.
    /// </summary>
    public string? TransitMode { get; init; }

    /// <summary>
    /// Specifies preferences for transit routes. Using this parameter, you can bias the options returned, rather than accepting the default best route chosen by the API. This parameter may only be specified for transit directions. The parameter supports the following arguments:
    /// * <c>less_walking</c> indicates that the calculated route should prefer limited amounts of walking.
    /// * <c>fewer_transfers</c> indicates that the calculated route should prefer a limited number of transfers.
    /// </summary>
    public TransitRoutingPreference1? TransitRoutingPreference { get; init; }
}
