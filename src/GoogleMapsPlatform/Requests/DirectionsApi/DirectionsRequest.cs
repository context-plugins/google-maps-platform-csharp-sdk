using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.DirectionsApi;

/// <summary>
/// The inputs of the Directions operation.
/// </summary>
public sealed record DirectionsRequest
{
    /// <summary>
    /// The place ID, address, or textual latitude/longitude value to which you wish to calculate directions. The options for the destination parameter are the same as for the origin parameter.
    /// </summary>
    public required string Destination { get; init; }

    /// <summary>
    /// The place ID, address, or textual latitude/longitude value from which you wish to calculate directions.
    /// * Place IDs must be prefixed with <c>place_id:</c>. You can retrieve place IDs from the Geocoding API and the Places API (including Place Autocomplete). For an example using place IDs from Place Autocomplete, see <see href="https://developers.google.com/maps/documentation/javascript/examples/places-autocomplete-directions">Place Autocomplete and Directions</see>. For more about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">Place ID overview</see>.
    ///
    ///   ```
    ///   origin=place_id:ChIJ3S-JXmauEmsRUcIaWtf4MzE
    ///   ```
    ///
    /// * If you pass an address, the Directions service geocodes the string and converts it to a latitude/longitude coordinate to calculate directions. This coordinate may be different from that returned by the Geocoding API, for example a building entrance rather than its center.
    ///
    ///   ```
    ///   origin=24+Sussex+Drive+Ottawa+ON
    ///   ```
    ///
    ///   Using place IDs is preferred over using addresses or latitude/longitude coordinates. Using coordinates will always result in the point being snapped to the road nearest to those coordinates - which may not be an access point to the property, or even a road that will quickly or safely lead to the destination.
    /// * If you pass coordinates, the point will snap to the nearest road. Passing a place ID is preferred. If you do pass coordinates, ensure that no space exists between the latitude and longitude values.
    ///
    ///   ```
    ///   origin=41.43206,-81.38992
    ///   ```
    /// <list type="bullet">
    ///   <item><description>Plus codes must be formatted as a global code or a compound code. Format plus codes as shown here (plus signs are url-escaped to <c>%2B</c> and spaces are url-escaped to <c>%20</c>).
    ///     <list type="bullet">
    ///       <item><description><b>Global code</b> is a 4 character area code and 6 character or longer local code (849VCWC8+R9 is <c>849VCWC8%2BR9</c>).</description></item>
    ///       <item><description><b>Compound code</b> is a 6 character or longer local code with an explicit location (CWC8+R9 Mountain View, CA, USA is <c>CWC8%2BR9%20Mountain%20View%20CA%20USA</c>).</description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// <para>
    /// &lt;div class="note"&gt;Note: For efficiency and accuracy, use place ID's when possible. These ID's are uniquely explicit like a lat/lng value pair and provide geocoding benefits for routing such as access points and traffic variables. Unlike an address, ID's do not require the service to perform a search or an intermediate request for place details; therefore, performance is better.&lt;/div&gt;
    /// </para>
    /// </summary>
    public required string Origin { get; init; }

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
    /// If set to <c>true</c>, specifies that the Directions service may provide more than one route alternative in the response. Note that providing route alternatives may increase the response time from the server. This is only available for requests without intermediate waypoints. For more information, see the <see href="https://developers.google.com/maps/documentation/directions/get-directions#Waypoints">guide to waypoints</see>.
    /// </summary>
    public bool? Alternatives { get; init; }

    /// <summary>
    /// Indicates that the calculated route(s) should avoid the indicated features. This parameter supports the following arguments:
    /// * <c>tolls</c> indicates that the calculated route should avoid toll roads/bridges.
    /// * <c>highways</c> indicates that the calculated route should avoid highways.
    /// * <c>ferries</c> indicates that the calculated route should avoid ferries.
    /// * <c>indoor</c> indicates that the calculated route should avoid indoor steps for walking and transit directions.
    /// <para>
    /// It's possible to request a route that avoids any combination of tolls, highways and ferries by passing multiple restrictions to the avoid parameter. For example:
    /// </para>
    /// <code>
    /// avoid=tolls|highways|ferries.
    /// </code>
    /// </summary>
    public string? Avoid { get; init; }

    /// <summary>
    /// Specifies the unit system to use when displaying results.
    /// <para>
    /// Directions results contain text within distance fields that may be displayed to the user to indicate the distance of a particular "step" of the route. By default, this text uses the unit system of the origin's country or region.
    /// </para>
    /// <para>
    /// For example, a route from "Chicago, IL" to "Toronto, ONT" will display results in miles, while the reverse route will display results in kilometers. You may override this unit system by setting one explicitly within the request's units parameter, passing one of the following values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>metric</c> specifies usage of the metric system. Textual distances are returned using kilometers and meters.</description></item>
    ///   <item><description><c>imperial</c> specifies usage of the Imperial (English) system. Textual distances are returned using miles and feet.</description></item>
    /// </list>
    /// <para>
    /// &lt;div class="note"&gt;Note: this unit system setting only affects the text displayed within distance fields. The distance fields also contain values which are always expressed in meters.&lt;/div&gt;
    /// </para>
    /// </summary>
    public Units1? Units { get; init; }

    /// <summary>
    /// &lt;div class="caution"&gt;Caution: Requests using more than 10 waypoints (between 11 and 25), or waypoint optimization, are billed at a higher rate. &lt;a href="https://developers.google.com/maps/billing-and-pricing/pricing#directions-advanced"&gt;Learn more about billing&lt;/a&gt; for Google Maps Platform products.&lt;/div&gt;
    /// <para>
    /// Specifies an array of intermediate locations to include along the route between the origin and destination points as pass through or stopover locations. Waypoints alter a route by directing it through the specified location(s). The API supports waypoints for these travel modes: driving, walking and bicycling; not transit.   You can supply one or more locations separated by the pipe character (<c>|</c> or <c>%7C</c>), in the form of a place ID, an address, or latitude/longitude coordinates. By default, the Directions service calculates a route using the waypoints in the order they are given. The precedence for parsing the value of the waypoint is place ID, latitude/longitude coordinates, then address.
    /// * If you pass a place ID, you must prefix it with <c>place_id:</c>. You can retrieve place IDs from the Geocoding API and the Places API (including Place Autocomplete). For an example using place IDs from Place Autocomplete, see <see href="https://developers.google.com/maps/documentation/javascript/examples/places-autocomplete-directions">Place Autocomplete and Directions</see>. For more about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">Place ID overview</see>.
    ///   &lt;div class="note"&gt;For efficiency and accuracy, use place ID's when possible. These ID's are uniquely explicit like a lat/lng value pair and provide geocoding benefits for routing such as access points and traffic variables. Unlike an address, ID's do not require the service to perform a search or an intermediate request for place details; therefore, performance is better.&lt;/div&gt;
    /// * If you pass latitude/longitude coordinates, the values go directly to the front-end server to calculate directions without geocoding. The points are snapped to roads and might not provide the accuracy your app needs. Use coordinates when you are confident the values truly specify the points your app needs for routing without regard to possible access points or additional geocoding details. Ensure that a comma (<c>%2C</c>) and not a space (<c>%20</c>) separates the latitude and longitude values.
    /// * If you pass an address, the Directions service will geocode the string and convert it into latitude/longitude coordinates to calculate directions. If the address value is ambiguous, the value might evoke a search to disambiguate from similar addresses. For example, "1st Street" could be a complete value or a partial value for "1st street NE" or "1st St SE". This result may be different from that returned by the Geocoding API. You can avoid possible misinterpretations using place IDs.
    /// * Alternatively, you can supply an encoded set of points using the <see href="https://developers.google.com/maps/documentation/utilities/polylinealgorithm">Encoded Polyline Algorithm</see>. You will find an encoded set is useful for a large number of waypoints, because the URL is significantly shorter. All web services have a URL limit of 8192 characters.
    ///   * Encoded polylines must be prefixed with <c>enc:</c> and followed by a colon (<c>:</c>). For example: <c>waypoints=enc:gfo}EtohhU:</c>.
    ///   * You can also include multiple encoded polylines, separated by the pipe character (<c>|</c>). For example, <c>waypoints=via:enc:wc~oAwquwMdlTxiKtqLyiK:|enc:c~vnAamswMvlTortjGi}L:| via:enc:udymA{~bxM:</c>
    /// </para>
    /// <para>
    /// ##### Influence routes with stopover and pass through points
    /// </para>
    /// <para>
    /// For each waypoint in the request, the directions response appends an entry to the <c>legs</c> array to provide the details for stopovers on that leg of the journey.
    /// </para>
    /// <para>
    /// If you'd like to influence the route using waypoints without adding a stopover, add the prefix <c>via:</c> to the waypoint. Waypoints prefixed with <c>via:</c> will not add an entry to the <c>legs</c> array, but will route the journey through the waypoint.
    /// </para>
    /// <para>
    /// The following URL modifies the previous request such that the journey is routed through Lexington without stopping:
    /// </para>
    /// <code>
    /// https://maps.googleapis.com/maps/api/directions/json?
    /// origin=Boston,MA&amp;destination=Concord,MA
    /// &amp;waypoints=Charlestown,MA|via:Lexington,MA
    /// </code>
    /// <para>
    /// The <c>via:</c> prefix is most effective when creating routes in response to the user dragging the waypoints on the map. Doing so allows the user to see how the final route may look in real-time and helps ensure that waypoints are placed in locations that are accessible to the Directions API.
    /// </para>
    /// <para>
    /// &lt;div class="caution"&gt;Caution: Using the <c>via:</c> prefix to avoid stopovers results in directions that are strict in their interpretation of the waypoint. This interpretation may result in severe detours on the route or <c>ZERO_RESULTS</c> in the response status code if the Directions API is unable to create directions through that point.&lt;/div&gt;
    /// </para>
    /// <para>
    ///
    /// ##### Optimize your waypoints
    /// </para>
    /// <para>
    /// By default, the Directions service calculates a route through the provided waypoints in their given order. Optionally, you may pass <c>optimize:true</c> as the first argument within the waypoints parameter to allow the Directions service to optimize the provided route by rearranging the waypoints in a more efficient order. (This optimization is an application of the traveling salesperson problem.) Travel time is the primary factor which is optimized, but other factors such as distance, number of turns and many more may be taken into account when deciding which route is the most efficient. All waypoints must be stopovers for the Directions service to optimize their route.
    /// </para>
    /// <para>
    /// If you instruct the Directions service to optimize the order of its waypoints, their order will be returned in the <c>waypoint_order</c> field within the routes object. The <c>waypoint_order</c> field returns values which are zero-based.
    /// </para>
    /// <para>
    /// The following example calculates a road journey from Adelaide, South Australia to each of South Australia's main wine regions using route optimization.
    /// </para>
    /// <code>
    /// https://maps.googleapis.com/maps/api/directions/json?
    /// origin=Adelaide,SA&amp;destination=Adelaide,SA
    /// &amp;waypoints=optimize:true|Barossa+Valley,SA|Clare,SA|Connawarra,SA|McLaren+Vale,SA
    /// </code>
    /// <para>
    /// Inspection of the calculated route will indicate that calculation uses waypoints in the following waypoint order:
    /// </para>
    /// <code>
    /// "waypoint_order": [ 3, 2, 0, 1 ]
    /// </code>
    /// <para>
    /// &lt;div class="caution"&gt;Caution: Requests using waypoint optimization are billed at a higher rate. &lt;a href="https://developers.google.com/maps/billing-and-pricing/pricing#directions-advanced"&gt;Learn more about how Google Maps Platform products are billed.&lt;/a&gt;&lt;/div&gt;
    /// </para>
    /// </summary>
    public string? Waypoints { get; init; }

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
