using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Exceptions;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Core.Request;
using GoogleMapsPlatform.Core.Response;
using GoogleMapsPlatform.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Api;

public sealed class GeocodingApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GeocodingApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// geocode
    /// </summary>
    /// <param name="address">The street address or plus code that you want to geocode. Specify addresses in accordance with the format used by the national postal service of the country concerned. Additional address elements such as business names and unit, suite or floor numbers should be avoided. Street address elements should be delimited by spaces (shown here as url-escaped to <c>%20</c>):  ``` address=24%20Sussex%20Drive%20Ottawa%20ON ```  Format plus codes as shown here (plus signs are url-escaped to `%2B` and spaces are url-escaped to `%20`): - global code is a 4 character area code and 6 character or longer local code (`849VCWC8+R9` is `849VCWC8%2BR9`). - compound code is a 6 character or longer local code with an explicit location (`CWC8+R9 Mountain View, CA, USA` is `CWC8%2BR9%20Mountain%20View%20CA%20USA`).  &lt;div class="note"&gt;Note: At least one of `address` or `components` is required.&lt;/div&gt;</param>
    /// <param name="bounds">The bounding box of the viewport within which to bias geocode results more prominently. This parameter will only influence, not fully restrict, results from the geocoder.</param>
    /// <param name="components">A components filter with elements separated by a pipe (|). The components filter is also accepted as an optional parameter if an address is provided. Each element in the components filter consists of a <c>component:value</c> pair, and fully restricts the results from the geocoder.  The components that can be filtered include:  * <c>postal_code</c> matches <c>postal_code</c> and <c>postal_code_prefix</c>. * <c>country</c> matches a country name or a two letter ISO 3166-1 country code. The API follows the ISO standard for defining countries, and the filtering works best when using the corresponding ISO code of the country.   &lt;aside class="note"&gt;&lt;strong&gt;Note&lt;/strong&gt;: If you receive unexpected results with a country code, verify that you are using a code which includes the countries, dependent territories, and special areas of geographical interest you intend. You can find code information at Wikipedia: List of ISO 3166 country codes or the ISO Online Browsing Platform.&lt;/aside&gt;    The following components may be used to influence results, but will not be enforced:  * <c>route</c> matches the long or short name of a route. * <c>locality</c> matches against <c>locality</c> and <c>sublocality</c> types. * <c>administrative_area</c> matches all the <c>administrative_area</c> levels.    Notes about component filtering:  * Do not repeat these component filters in requests, or the API will return <c>INVALID_REQUEST</c>:    * <c>country</c>   * <c>postal_code</c>   * <c>route</c> * If the request contains repeated component filters, the API evaluates those filters as an AND, not an OR. * Results are consistent with Google Maps, which occasionally yields unexpected <c>ZERO_RESULTS</c> responses. Using Place Autocomplete may provide better results in some use cases. To learn more, see <see href="https://developers..google.com/maps/documentation/geocoding/faq#trbl_component_filtering">this FAQ</see>. * For each address component, either specify it in the address parameter or in a components filter, but not both. Specifying the same values in both may result in <c>ZERO_RESULTS</c>.  &lt;div class="note"&gt;Note: At least one of <c>address</c> or <c>components</c> is required.&lt;/div&gt;</param>
    /// <param name="latlng">The street address that you want to geocode, in the format used by the national postal service of the country concerned. Additional address elements such as business names and unit, suite or floor numbers should be avoided.</param>
    /// <param name="locationType">A filter of one or more location types, separated by a pipe (<c>|</c>). If the parameter contains multiple location types, the API returns all addresses that match any of the types. A note about processing: The <c>location_type</c> parameter does not restrict the search to the specified location type(s). Rather, the <c>location_type</c> acts as a post-search filter: the API fetches all results for the specified latlng, then discards those results that do not match the specified location type(s). The following values are supported: * <c>APPROXIMATE</c> returns only the addresses that are characterized as approximate. * <c>GEOMETRIC_CENTER</c> returns only geometric centers of a location such as a polyline (for example, a street) or polygon (region). * <c>RANGE_INTERPOLATED</c> returns only the addresses that reflect an approximation (usually on a road) interpolated between two precise points (such as intersections). An interpolated range generally indicates that rooftop geocodes are unavailable for a street address. * <c>ROOFTOP</c> returns only the addresses for which Google has location information accurate down to street address precision.</param>
    /// <param name="placeId">A textual identifier that uniquely identifies a place, returned from a <see href="https://developers.google.com/maps/documentation/places/web-service/search">Place Search</see>. For more information about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">place ID overview</see>.</param>
    /// <param name="resultType">A filter of one or more address types, separated by a pipe (|). If the parameter contains multiple address types, the API returns all addresses that match any of the types. A note about processing: The <c>result_type</c> parameter does not restrict the search to the specified address type(s). Rather, the <c>result_type</c> acts as a post-search filter: the API fetches all results for the specified <c>latlng</c>, then discards those results that do not match the specified address type(s).The following values are supported: * <c>administrative_area_level_1</c> indicates a first-order civil entity below the country level. Within the United States, these administrative levels are states. Not all nations exhibit these administrative levels. In most cases, administrative_area_level_1   * <c>short</c> names will closely match ISO 3166-2 subdivisions and other widely circulated lists; however this is not guaranteed as our geocoding results are based on a variety of signals and location data. * <c>administrative_area_level_2</c> indicates a second-order civil entity below the country level. Within the United States, these administrative levels are counties. Not all nations exhibit these administrative levels. * <c>administrative_area_level_3</c> indicates a third-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels. * <c>administrative_area_level_4</c> indicates a fourth-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels. * <c>administrative_area_level_5</c> indicates a fifth-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels. * <c>airport</c> indicates an airport. * <c>colloquial_area</c> indicates a commonly-used alternative name for the entity. * <c>country</c> indicates the national political entity, and is typically the highest order type returned by the Geocoder. * <c>intersection</c> indicates a major intersection, usually of two major roads. * <c>locality</c> indicates an incorporated city or town political entity. * <c>natural_feature</c> indicates a prominent natural feature. * <c>neighborhood</c> indicates a named neighborhood * <c>park</c> indicates a named park. * <c>plus_code</c> indicates an encoded location reference, derived from latitude and longitude. Plus codes can be used as a replacement for street addresses in places where they do not exist (where buildings are not numbered or streets are not named). See <see href="https://plus.codes/">https://plus.codes/</see> for details. * <c>point_of_interest</c> indicates a named point of interest. Typically, these "POI"s are prominent local entities that don't easily fit in another category, such as "Empire State Building" or "Eiffel Tower". * <c>political</c> indicates a political entity. Usually, this type indicates a polygon of some civil administration. * <c>postal_code</c> indicates a postal code as used to address postal mail within the country. * <c>premise</c> indicates a named location, usually a building or collection of buildings with a common name * <c>route</c> indicates a named route (such as "US 101"). * <c>street_address</c> indicates a precise street address. * <c>sublocality</c> indicates a first-order civil entity below a locality. For some locations may receive one of the additional types: <c>sublocality_level_1</c> to <c>sublocality_level_5</c>. Each sublocality level is a civil entity. Larger numbers indicate a smaller geographic area. * <c>subpremise</c> indicates a first-order entity below a named location, usually a singular building within a collection of buildings with a common name</param>
    /// <param name="language">The language in which to return results.  * See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive. * If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header. * The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component. * If a name is not available in the preferred language, the API uses the closest match. * The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</param>
    /// <param name="region">The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeocodingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Geocoding API is a service that provides geocoding and reverse geocoding of addresses.
    /// <para>
    /// <b>Geocoding</b> is the process of converting addresses (like a street address) into geographic coordinates (like latitude and longitude), which you can use to place markers on a map, or position the map.
    /// </para>
    /// <para>
    /// <b>Reverse geocoding</b> is the process of converting geographic coordinates into a human-readable address.
    /// </para>
    /// <para>
    /// You can also use the Geocoding API to find the address for a given place ID.
    /// </para>
    /// <para>
    /// To see countries currently supported by the Google Maps Platform Geocoding API, please consult the <see href="https://developers.google.com/maps/coverage">Google Maps coverage data</see>. The accuracy of geocoded locations may vary per country, so you should consider using the returned <c>location_type</c> field to determine if a good enough match has been found for the purposes of your application. Please note that the availability of geocoding data depends on our contracts with data providers, so it is subject to change.
    /// </para>
    /// </remarks>
    public Task<GeocodingResponse> Geocode(string? address,
        IReadOnlyList<string>? bounds,
        IReadOnlyList<string>? components,
        string? latlng,
        IReadOnlyList<LocationType>? locationType,
        string? placeId,
        IReadOnlyList<ResultType>? resultType,
        Language1? language,
        Region1? region,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/geocode/json"),
            [],
            [new Param("address", address),
                new Param("bounds", bounds),
                new Param("components", components),
                new Param("latlng", latlng),
                new Param("location_type", locationType),
                new Param("place_id", placeId),
                new Param("result_type", resultType),
                new Param("language", language),
                new Param("region", region)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GeocodingResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
