using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Units>))]
public sealed record Units : StringEnum<Units>
{
    private Units(string value) : base(value)
    {
    }

    public static readonly Units Imperial = new("imperial");

    public static readonly Units Metric = new("metric");

    public static Units FromValue(string value) => FromValueCore(value);
}
