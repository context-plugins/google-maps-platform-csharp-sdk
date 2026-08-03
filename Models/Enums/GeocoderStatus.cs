using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Indicates the status code resulting from the geocoding operation. This field may contain the following values.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GeocoderStatus>))]
public sealed record GeocoderStatus : StringEnum<GeocoderStatus>
{
    private GeocoderStatus(string value) : base(value)
    {
    }

    public static readonly GeocoderStatus Ok = new("OK");

    public static readonly GeocoderStatus ZeroResults = new("ZERO_RESULTS");

    public static GeocoderStatus FromValue(string value) => FromValueCore(value);
}
