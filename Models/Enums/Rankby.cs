using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Rankby>))]
public sealed record Rankby : StringEnum<Rankby>
{
    private Rankby(string value) : base(value)
    {
    }

    public static readonly Rankby Prominence = new("prominence");

    public static readonly Rankby Distance = new("distance");

    public static Rankby FromValue(string value) => FromValueCore(value);
}
