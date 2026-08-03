using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LocationType>))]
public sealed record LocationType : StringEnum<LocationType>
{
    private LocationType(string value) : base(value)
    {
    }

    public static readonly LocationType Approximate = new("APPROXIMATE");

    public static readonly LocationType GeometricCenter = new("GEOMETRIC_CENTER");

    public static readonly LocationType RangeInterpolated = new("RANGE_INTERPOLATED");

    public static readonly LocationType Rooftop = new("ROOFTOP");

    public static LocationType FromValue(string value) => FromValueCore(value);
}
