using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// Attributes describing a place. Not all attributes will be available for all place types.
/// </summary>
public record Place
{
    /// <summary>
    /// An array containing the separate components applicable to this address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_components")]
    public IReadOnlyList<AddressComponent>? AddressComponents { get; init; }

    /// <summary>
    /// A representation of the place's address in the <see href="http://microformats.org/wiki/adr">adr microformat</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adr_address")]
    public string? AdrAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_status")]
    public BusinessStatus? BusinessStatus { get; init; }

    /// <summary>
    /// Specifies if the business supports curbside pickup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("curbside_pickup")]
    public bool? CurbsidePickup { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_opening_hours")]
    public CurrentOpeningHours? CurrentOpeningHours { get; init; }

    /// <summary>
    /// Specifies if the business supports delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivery")]
    public bool? Delivery { get; init; }

    /// <summary>
    /// Specifies if the business supports indoor or outdoor seating options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dine_in")]
    public bool? DineIn { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editorial_summary")]
    public EditorialSummary? EditorialSummary { get; init; }

    /// <summary>
    /// A string containing the human-readable address of this place.
    /// <para>
    /// Often this address is equivalent to the postal address. Note that some countries, such as the United Kingdom, do not allow distribution of true postal addresses due to licensing restrictions.
    /// </para>
    /// <para>
    /// The formatted address is logically composed of one or more address components. For example, the address "111 8th Avenue, New York, NY" consists of the following components: "111" (the street number), "8th Avenue" (the route), "New York" (the city) and "NY" (the US state).
    /// </para>
    /// <para>
    /// Do not parse the formatted address programmatically. Instead you should use the individual address components, which the API response includes in addition to the formatted address field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formatted_address")]
    public string? FormattedAddress { get; init; }

    /// <summary>
    /// Contains the place's phone number in its <see href="http://en.wikipedia.org/wiki/Local_conventions_for_writing_telephone_numbers">local format</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formatted_phone_number")]
    public string? FormattedPhoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public Geometry2? Geometry { get; init; }

    /// <summary>
    /// Contains the URL of a suggested icon which may be displayed to the user when indicating this result on a map.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    /// <summary>
    /// Contains the default HEX color code for the place's category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon_background_color")]
    public string? IconBackgroundColor { get; init; }

    /// <summary>
    /// Contains the URL of a recommended icon, minus the <c>.svg</c> or <c>.png</c> file type extension.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon_mask_base_uri")]
    public string? IconMaskBaseUri { get; init; }

    /// <summary>
    /// Contains the place's phone number in international format. International format includes the country code, and is prefixed with the plus, +, sign. For example, the international_phone_number for Google's Sydney, Australia office is <c>+61 2 9374 4000</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international_phone_number")]
    public string? InternationalPhoneNumber { get; init; }

    /// <summary>
    /// Contains the human-readable name for the returned result. For <c>establishment</c> results, this is usually the canonicalized business name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opening_hours")]
    public OpeningHours? OpeningHours { get; init; }

    /// <summary>
    /// Use <c>business_status</c> to get the operational status of businesses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("permanently_closed")]
    public bool? PermanentlyClosed { get; init; }

    /// <summary>
    /// An array of photo objects, each containing a reference to an image. A request may return up to ten photos. More information about place photos and how you can use the images in your application can be found in the <see href="https://developers.google.com/maps/documentation/places/web-service/photos">Place Photos</see> documentation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("photos")]
    public IReadOnlyList<PlacePhoto>? Photos { get; init; }

    /// <summary>
    /// A textual identifier that uniquely identifies a place. To retrieve information about the place, pass this identifier in the <c>place_id</c> field of a Places API request. For more information about place IDs, see the <see href="https://developers.google.com/maps/documentation/places/web-service/place-id">place ID overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("place_id")]
    public string? PlaceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plus_code")]
    public PlusCode1? PlusCode { get; init; }

    /// <summary>
    /// The price level of the place, on a scale of 0 to 4. The exact amount indicated by a specific value will vary from region to region. Price levels are interpreted as follows:
    /// - 0 Free
    /// - 1 Inexpensive
    /// - 2 Moderate
    /// - 3 Expensive
    /// - 4 Very Expensive
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_level")]
    public double? PriceLevel { get; init; }

    /// <summary>
    /// Contains the place's rating, from 1.0 to 5.0, based on aggregated user reviews.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rating")]
    public double? Rating { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// Specifies if the place supports reservations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservable")]
    public bool? Reservable { get; init; }

    /// <summary>
    /// A JSON array of up to five reviews. By default, the reviews are sorted in order of relevance. Use the <c>reviews_sort</c> request parameter to control sorting.
    /// <para>
    /// - For <c>most_relevant</c> (default), reviews are sorted by relevance; the service will bias the results to return reviews originally written in the preferred language.
    /// - For <c>newest</c>, reviews are sorted in chronological order; the preferred language does not affect the sort order.
    /// Google recommends indicating to users whether results are ordered by <c>most_relevant</c> or <c>newest</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reviews")]
    public IReadOnlyList<PlaceReview>? Reviews { get; init; }

    /// <summary>
    /// Specifies if the place serves beer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_beer")]
    public bool? ServesBeer { get; init; }

    /// <summary>
    /// Specifies if the place serves breakfast.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_breakfast")]
    public bool? ServesBreakfast { get; init; }

    /// <summary>
    /// Specifies if the place serves brunch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_brunch")]
    public bool? ServesBrunch { get; init; }

    /// <summary>
    /// Specifies if the place serves dinner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_dinner")]
    public bool? ServesDinner { get; init; }

    /// <summary>
    /// Specifies if the place serves lunch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_lunch")]
    public bool? ServesLunch { get; init; }

    /// <summary>
    /// Specifies if the place serves vegetarian food.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_vegetarian_food")]
    public bool? ServesVegetarianFood { get; init; }

    /// <summary>
    /// Specifies if the place serves wine.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serves_wine")]
    public bool? ServesWine { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    /// <summary>
    /// Contains an array of entries for the next seven days including information about secondary hours of a business. Secondary hours are different from a business's main hours. For example, a restaurant can specify drive through hours or delivery hours as its secondary hours. This field populates the <c>type</c> subfield, which draws from a predefined list of opening hours types (such as <c>DRIVE_THROUGH</c>, <c>PICKUP</c>, or <c>TAKEOUT</c>) based on the types of the place. This field includes the <c>special_days</c> subfield of all hours, set for dates that have exceptional hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_opening_hours")]
    public IReadOnlyList<PlaceOpeningHours>? SecondaryOpeningHours { get; init; }

    /// <summary>
    /// Specifies if the business supports takeout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("takeout")]
    public bool? Takeout { get; init; }

    /// <summary>
    /// Contains an array of feature types describing the given result. See the list of <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types#table2">supported types</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("types")]
    public IReadOnlyList<string>? Types { get; init; }

    /// <summary>
    /// Contains the URL of the official Google page for this place. This will be the Google-owned page that contains the best available information about the place. Applications must link to or embed this page on any screen that shows detailed results about the place to the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// The total number of reviews, with or without text, for this place.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_ratings_total")]
    public double? UserRatingsTotal { get; init; }

    /// <summary>
    /// Contains the number of minutes this place’s current timezone is offset from UTC. For example, for places in Sydney, Australia during daylight saving time this would be 660 (+11 hours from UTC), and for places in California outside of daylight saving time this would be -480 (-8 hours from UTC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("utc_offset")]
    public double? UtcOffset { get; init; }

    /// <summary>
    /// For establishment (<c>types:["establishment", ...])</c> results only, the <c>vicinity</c> field contains a simplified address for the place, including the street name, street number, and locality, but not the province/state, postal code, or country.
    /// <para>
    /// For all other results, the <c>vicinity</c> field contains the name of the narrowest political (<c>types:["political", ...]</c>) feature that is present in the address of the result.
    /// </para>
    /// <para>
    /// This content is meant to be read as-is. Do not programmatically parse the formatted address.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vicinity")]
    public string? Vicinity { get; init; }

    /// <summary>
    /// The authoritative website for this place, such as a business' homepage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website")]
    public string? Website { get; init; }

    /// <summary>
    /// Specifies if the place has an entrance that is wheelchair-accessible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wheelchair_accessible_entrance")]
    public bool? WheelchairAccessibleEntrance { get; init; }
}
