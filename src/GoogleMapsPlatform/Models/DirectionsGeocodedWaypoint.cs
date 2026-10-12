using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record DirectionsGeocodedWaypoint
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geocoder_status")]
    public GeocoderStatus? GeocoderStatus { get; init; }

    /// <summary>
    /// Indicates that the geocoder did not return an exact match for the original request, though it was able to match part of the requested address. You may wish to examine the original request for misspellings and/or an incomplete address.
    /// <para>
    /// Partial matches most often occur for street addresses that do not exist within the locality you pass in the request. Partial matches may also be returned when a request matches two or more locations in the same locality. For example, "21 Henr St, Bristol, UK" will return a partial match for both Henry Street and Henrietta Street. Note that if a request includes a misspelled address component, the geocoding service may suggest an alternative address. Suggestions triggered in this way will also be marked as a partial match.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partial_match")]
    public object? PartialMatch { get; init; }

    /// <summary>
    /// A unique identifier that can be used with other Google APIs. See the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">Place ID overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("place_id")]
    public string? PlaceId { get; init; }

    /// <summary>
    /// Indicates the address type of the geocoding result used for calculating directions.
    /// <list type="bullet">
    ///   <item><description><c>administrative_area_level_1</c> indicates a first-order civil entity below the country level. Within the United States, these administrative levels are states. Not all nations exhibit these administrative levels. In most cases, administrative_area_level_1 short names will closely match ISO 3166-2 subdivisions and other widely circulated lists; however this is not guaranteed as our geocoding results are based on a variety of signals and location data.</description></item>
    ///   <item><description><c>administrative_area_level_2</c> indicates a second-order civil entity below the country level. Within the United States, these administrative levels are counties. Not all nations exhibit these administrative levels.</description></item>
    ///   <item><description><c>administrative_area_level_3</c> indicates a third-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.</description></item>
    ///   <item><description><c>administrative_area_level_4</c> indicates a fourth-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.</description></item>
    ///   <item><description><c>administrative_area_level_5</c> indicates a fifth-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.</description></item>
    ///   <item><description><c>airport</c> indicates an airport.</description></item>
    ///   <item><description><c>colloquial_area</c> indicates a commonly-used alternative name for the entity.</description></item>
    ///   <item><description><c>country</c> indicates the national political entity, and is typically the highest order type returned by the Geocoder.</description></item>
    ///   <item><description><c>intersection</c> indicates a major intersection, usually of two major roads.</description></item>
    ///   <item><description><c>locality</c> indicates an incorporated city or town political entity.</description></item>
    ///   <item><description><c>natural_feature</c> indicates a prominent natural feature.</description></item>
    ///   <item><description><c>neighborhood</c> indicates a named neighborhood</description></item>
    ///   <item><description><c>park</c> indicates a named park.</description></item>
    ///   <item><description><c>plus_code</c> indicates an encoded location reference, derived from latitude and longitude. Plus codes can be used as a replacement for street addresses in places where they do not exist (where buildings are not numbered or streets are not named). See <see href="https://plus.codes/">https://plus.codes</see> for details.</description></item>
    ///   <item><description><c>point_of_interest</c> indicates a named point of interest. Typically, these "POI"s are prominent local entities that don't easily fit in another category, such as "Empire State Building" or "Eiffel Tower".</description></item>
    ///   <item><description><c>political</c> indicates a political entity. Usually, this type indicates a polygon of some civil administration.</description></item>
    ///   <item><description><c>postal_code</c> indicates a postal code as used to address postal mail within the country.</description></item>
    ///   <item><description><c>premise</c> indicates a named location, usually a building or collection of buildings with a common name</description></item>
    ///   <item><description><c>route</c> indicates a named route (such as "US 101").</description></item>
    ///   <item><description><c>street_address</c> indicates a precise street address.</description></item>
    ///   <item><description><c>sublocality</c> indicates a first-order civil entity below a locality. For some locations may receive one of the additional types: sublocality_level_1 to sublocality_level_5. Each sublocality level is a civil entity. Larger numbers indicate a smaller geographic area.</description></item>
    ///   <item><description><c>subpremise</c> indicates a first-order entity below a named location, usually a singular building within a collection of buildings with a common name</description></item>
    ///   <item><description><c>tourist_attraction</c> indicates a tourist attraction.</description></item>
    ///   <item><description><c>train_station</c> indicates a train station.</description></item>
    ///   <item><description><c>transit_station</c> indicates a transit station.</description></item>
    /// </list>
    /// <para>
    /// An empty list of types indicates there are no known types for the particular address component, for example, Lieu-dit in France.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("area_type")]
    public IReadOnlyList<AreaType>? AreaType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
