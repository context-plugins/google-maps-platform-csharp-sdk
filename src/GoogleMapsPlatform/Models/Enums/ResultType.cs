using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ResultType>))]
public sealed record ResultType : OpenStringEnum<ResultType>
{
    private ResultType(string value) : base(value)
    {
    }

    public static readonly ResultType AdministrativeAreaLevel1 = new("administrative_area_level_1");

    public static readonly ResultType AdministrativeAreaLevel2 = new("administrative_area_level_2");

    public static readonly ResultType AdministrativeAreaLevel3 = new("administrative_area_level_3");

    public static readonly ResultType AdministrativeAreaLevel4 = new("administrative_area_level_4");

    public static readonly ResultType AdministrativeAreaLevel5 = new("administrative_area_level_5");

    public static readonly ResultType Airport = new("airport");

    public static readonly ResultType ColloquialArea = new("colloquial_area");

    public static readonly ResultType Country = new("country");

    public static readonly ResultType Intersection = new("intersection");

    public static readonly ResultType Locality = new("locality");

    public static readonly ResultType NaturalFeature = new("natural_feature");

    public static readonly ResultType Neighborhood = new("neighborhood");

    public static readonly ResultType Park = new("park");

    public static readonly ResultType PlusCode = new("plus_code");

    public static readonly ResultType Political = new("political");

    public static readonly ResultType PostalCode = new("postal_code");

    public static readonly ResultType Premise = new("premise");

    public static readonly ResultType Route = new("route");

    public static readonly ResultType StreetAddress = new("street_address");

    public static readonly ResultType Sublocality = new("sublocality");

    public static readonly ResultType Subpremise = new("subpremise");

    public TResult Match<TResult>(Func<TResult> onAdministrativeAreaLevel1,
        Func<TResult> onAdministrativeAreaLevel2,
        Func<TResult> onAdministrativeAreaLevel3,
        Func<TResult> onAdministrativeAreaLevel4,
        Func<TResult> onAdministrativeAreaLevel5,
        Func<TResult> onAirport,
        Func<TResult> onColloquialArea,
        Func<TResult> onCountry,
        Func<TResult> onIntersection,
        Func<TResult> onLocality,
        Func<TResult> onNaturalFeature,
        Func<TResult> onNeighborhood,
        Func<TResult> onPark,
        Func<TResult> onPlusCode,
        Func<TResult> onPolitical,
        Func<TResult> onPostalCode,
        Func<TResult> onPremise,
        Func<TResult> onRoute,
        Func<TResult> onStreetAddress,
        Func<TResult> onSublocality,
        Func<TResult> onSubpremise,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AdministrativeAreaLevel1 => onAdministrativeAreaLevel1(),
            _ when this == AdministrativeAreaLevel2 => onAdministrativeAreaLevel2(),
            _ when this == AdministrativeAreaLevel3 => onAdministrativeAreaLevel3(),
            _ when this == AdministrativeAreaLevel4 => onAdministrativeAreaLevel4(),
            _ when this == AdministrativeAreaLevel5 => onAdministrativeAreaLevel5(),
            _ when this == Airport => onAirport(),
            _ when this == ColloquialArea => onColloquialArea(),
            _ when this == Country => onCountry(),
            _ when this == Intersection => onIntersection(),
            _ when this == Locality => onLocality(),
            _ when this == NaturalFeature => onNaturalFeature(),
            _ when this == Neighborhood => onNeighborhood(),
            _ when this == Park => onPark(),
            _ when this == PlusCode => onPlusCode(),
            _ when this == Political => onPolitical(),
            _ when this == PostalCode => onPostalCode(),
            _ when this == Premise => onPremise(),
            _ when this == Route => onRoute(),
            _ when this == StreetAddress => onStreetAddress(),
            _ when this == Sublocality => onSublocality(),
            _ when this == Subpremise => onSubpremise(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdministrativeAreaLevel1,
        Action onAdministrativeAreaLevel2,
        Action onAdministrativeAreaLevel3,
        Action onAdministrativeAreaLevel4,
        Action onAdministrativeAreaLevel5,
        Action onAirport,
        Action onColloquialArea,
        Action onCountry,
        Action onIntersection,
        Action onLocality,
        Action onNaturalFeature,
        Action onNeighborhood,
        Action onPark,
        Action onPlusCode,
        Action onPolitical,
        Action onPostalCode,
        Action onPremise,
        Action onRoute,
        Action onStreetAddress,
        Action onSublocality,
        Action onSubpremise,
        Action<string> otherwise)
    {
        if (this == AdministrativeAreaLevel1) onAdministrativeAreaLevel1();
        else if (this == AdministrativeAreaLevel2) onAdministrativeAreaLevel2();
        else if (this == AdministrativeAreaLevel3) onAdministrativeAreaLevel3();
        else if (this == AdministrativeAreaLevel4) onAdministrativeAreaLevel4();
        else if (this == AdministrativeAreaLevel5) onAdministrativeAreaLevel5();
        else if (this == Airport) onAirport();
        else if (this == ColloquialArea) onColloquialArea();
        else if (this == Country) onCountry();
        else if (this == Intersection) onIntersection();
        else if (this == Locality) onLocality();
        else if (this == NaturalFeature) onNaturalFeature();
        else if (this == Neighborhood) onNeighborhood();
        else if (this == Park) onPark();
        else if (this == PlusCode) onPlusCode();
        else if (this == Political) onPolitical();
        else if (this == PostalCode) onPostalCode();
        else if (this == Premise) onPremise();
        else if (this == Route) onRoute();
        else if (this == StreetAddress) onStreetAddress();
        else if (this == Sublocality) onSublocality();
        else if (this == Subpremise) onSubpremise();
        else otherwise(Value);
    }
}
