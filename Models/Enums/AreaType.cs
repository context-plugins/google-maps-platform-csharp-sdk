using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AreaType>))]
public sealed record AreaType : StringEnum<AreaType>
{
    private AreaType(string value) : base(value)
    {
    }

    public static readonly AreaType AdministrativeAreaLevel1 = new("administrative_area_level_1");

    public static readonly AreaType AdministrativeAreaLevel2 = new("administrative_area_level_2");

    public static readonly AreaType AdministrativeAreaLevel3 = new("administrative_area_level_3");

    public static readonly AreaType AdministrativeAreaLevel4 = new("administrative_area_level_4");

    public static readonly AreaType AdministrativeAreaLevel5 = new("administrative_area_level_5");

    public static readonly AreaType AmusementPark = new("amusement_park");

    public static readonly AreaType Airport = new("airport");

    public static readonly AreaType ColloquialArea = new("colloquial_area");

    public static readonly AreaType Country = new("country");

    public static readonly AreaType Establishment = new("establishment");

    public static readonly AreaType Intersection = new("intersection");

    public static readonly AreaType Locality = new("locality");

    public static readonly AreaType NaturalFeature = new("natural_feature");

    public static readonly AreaType Neighborhood = new("neighborhood");

    public static readonly AreaType Park = new("park");

    public static readonly AreaType PlusCode = new("plus_code");

    public static readonly AreaType PointOfInterest = new("point_of_interest");

    public static readonly AreaType Political = new("political");

    public static readonly AreaType PostalCode = new("postal_code");

    public static readonly AreaType Premise = new("premise");

    public static readonly AreaType Route = new("route");

    public static readonly AreaType StreetAddress = new("street_address");

    public static readonly AreaType Sublocality = new("sublocality");

    public static readonly AreaType SublocalityLevel1 = new("sublocality_level_1");

    public static readonly AreaType Subpremise = new("subpremise");

    public static readonly AreaType TouristAttraction = new("tourist_attraction");

    public static readonly AreaType TrainStation = new("train_station");

    public static readonly AreaType TransitStation = new("transit_station");

    public static AreaType FromValue(string value) => FromValueCore(value);
}
