using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AreaType>))]
public sealed record AreaType : OpenStringEnum<AreaType>
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

    public TResult Match<TResult>(Func<TResult> onAdministrativeAreaLevel1,
        Func<TResult> onAdministrativeAreaLevel2,
        Func<TResult> onAdministrativeAreaLevel3,
        Func<TResult> onAdministrativeAreaLevel4,
        Func<TResult> onAdministrativeAreaLevel5,
        Func<TResult> onAmusementPark,
        Func<TResult> onAirport,
        Func<TResult> onColloquialArea,
        Func<TResult> onCountry,
        Func<TResult> onEstablishment,
        Func<TResult> onIntersection,
        Func<TResult> onLocality,
        Func<TResult> onNaturalFeature,
        Func<TResult> onNeighborhood,
        Func<TResult> onPark,
        Func<TResult> onPlusCode,
        Func<TResult> onPointOfInterest,
        Func<TResult> onPolitical,
        Func<TResult> onPostalCode,
        Func<TResult> onPremise,
        Func<TResult> onRoute,
        Func<TResult> onStreetAddress,
        Func<TResult> onSublocality,
        Func<TResult> onSublocalityLevel1,
        Func<TResult> onSubpremise,
        Func<TResult> onTouristAttraction,
        Func<TResult> onTrainStation,
        Func<TResult> onTransitStation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AdministrativeAreaLevel1 => onAdministrativeAreaLevel1(),
            _ when this == AdministrativeAreaLevel2 => onAdministrativeAreaLevel2(),
            _ when this == AdministrativeAreaLevel3 => onAdministrativeAreaLevel3(),
            _ when this == AdministrativeAreaLevel4 => onAdministrativeAreaLevel4(),
            _ when this == AdministrativeAreaLevel5 => onAdministrativeAreaLevel5(),
            _ when this == AmusementPark => onAmusementPark(),
            _ when this == Airport => onAirport(),
            _ when this == ColloquialArea => onColloquialArea(),
            _ when this == Country => onCountry(),
            _ when this == Establishment => onEstablishment(),
            _ when this == Intersection => onIntersection(),
            _ when this == Locality => onLocality(),
            _ when this == NaturalFeature => onNaturalFeature(),
            _ when this == Neighborhood => onNeighborhood(),
            _ when this == Park => onPark(),
            _ when this == PlusCode => onPlusCode(),
            _ when this == PointOfInterest => onPointOfInterest(),
            _ when this == Political => onPolitical(),
            _ when this == PostalCode => onPostalCode(),
            _ when this == Premise => onPremise(),
            _ when this == Route => onRoute(),
            _ when this == StreetAddress => onStreetAddress(),
            _ when this == Sublocality => onSublocality(),
            _ when this == SublocalityLevel1 => onSublocalityLevel1(),
            _ when this == Subpremise => onSubpremise(),
            _ when this == TouristAttraction => onTouristAttraction(),
            _ when this == TrainStation => onTrainStation(),
            _ when this == TransitStation => onTransitStation(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdministrativeAreaLevel1,
        Action onAdministrativeAreaLevel2,
        Action onAdministrativeAreaLevel3,
        Action onAdministrativeAreaLevel4,
        Action onAdministrativeAreaLevel5,
        Action onAmusementPark,
        Action onAirport,
        Action onColloquialArea,
        Action onCountry,
        Action onEstablishment,
        Action onIntersection,
        Action onLocality,
        Action onNaturalFeature,
        Action onNeighborhood,
        Action onPark,
        Action onPlusCode,
        Action onPointOfInterest,
        Action onPolitical,
        Action onPostalCode,
        Action onPremise,
        Action onRoute,
        Action onStreetAddress,
        Action onSublocality,
        Action onSublocalityLevel1,
        Action onSubpremise,
        Action onTouristAttraction,
        Action onTrainStation,
        Action onTransitStation,
        Action<string> otherwise)
    {
        if (this == AdministrativeAreaLevel1) onAdministrativeAreaLevel1();
        else if (this == AdministrativeAreaLevel2) onAdministrativeAreaLevel2();
        else if (this == AdministrativeAreaLevel3) onAdministrativeAreaLevel3();
        else if (this == AdministrativeAreaLevel4) onAdministrativeAreaLevel4();
        else if (this == AdministrativeAreaLevel5) onAdministrativeAreaLevel5();
        else if (this == AmusementPark) onAmusementPark();
        else if (this == Airport) onAirport();
        else if (this == ColloquialArea) onColloquialArea();
        else if (this == Country) onCountry();
        else if (this == Establishment) onEstablishment();
        else if (this == Intersection) onIntersection();
        else if (this == Locality) onLocality();
        else if (this == NaturalFeature) onNaturalFeature();
        else if (this == Neighborhood) onNeighborhood();
        else if (this == Park) onPark();
        else if (this == PlusCode) onPlusCode();
        else if (this == PointOfInterest) onPointOfInterest();
        else if (this == Political) onPolitical();
        else if (this == PostalCode) onPostalCode();
        else if (this == Premise) onPremise();
        else if (this == Route) onRoute();
        else if (this == StreetAddress) onStreetAddress();
        else if (this == Sublocality) onSublocality();
        else if (this == SublocalityLevel1) onSublocalityLevel1();
        else if (this == Subpremise) onSubpremise();
        else if (this == TouristAttraction) onTouristAttraction();
        else if (this == TrainStation) onTrainStation();
        else if (this == TransitStation) onTransitStation();
        else otherwise(Value);
    }
}
