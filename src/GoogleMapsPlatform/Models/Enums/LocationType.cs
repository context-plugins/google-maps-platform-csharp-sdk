using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LocationType>))]
public sealed record LocationType : OpenStringEnum<LocationType>
{
    private LocationType(string value) : base(value)
    {
    }

    public static readonly LocationType Approximate = new("APPROXIMATE");

    public static readonly LocationType GeometricCenter = new("GEOMETRIC_CENTER");

    public static readonly LocationType RangeInterpolated = new("RANGE_INTERPOLATED");

    public static readonly LocationType Rooftop = new("ROOFTOP");

    public TResult Match<TResult>(Func<TResult> onApproximate,
        Func<TResult> onGeometricCenter,
        Func<TResult> onRangeInterpolated,
        Func<TResult> onRooftop,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Approximate => onApproximate(),
            _ when this == GeometricCenter => onGeometricCenter(),
            _ when this == RangeInterpolated => onRangeInterpolated(),
            _ when this == Rooftop => onRooftop(),
            _ => otherwise(Value)
        };

    public void Match(Action onApproximate,
        Action onGeometricCenter,
        Action onRangeInterpolated,
        Action onRooftop,
        Action<string> otherwise)
    {
        if (this == Approximate) onApproximate();
        else if (this == GeometricCenter) onGeometricCenter();
        else if (this == RangeInterpolated) onRangeInterpolated();
        else if (this == Rooftop) onRooftop();
        else otherwise(Value);
    }
}
