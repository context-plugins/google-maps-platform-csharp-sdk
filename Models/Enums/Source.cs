using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Source>))]
public sealed record Source : StringEnum<Source>
{
    private Source(string value) : base(value)
    {
    }

    public static readonly Source Default = new("default");

    public static readonly Source Outdoor = new("outdoor");

    public static Source FromValue(string value) => FromValueCore(value);
}
