using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Specifies the unit system to use when displaying results.
/// <para>
/// &lt;div class="note"&gt;Note: this unit system setting only affects the text displayed within distance fields. The distance fields also contain values which are always expressed in meters.&lt;/div&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Units2>))]
public sealed record Units2 : StringEnum<Units2>
{
    private Units2(string value) : base(value)
    {
    }

    public static readonly Units2 Imperial = new("imperial");

    public static readonly Units2 Metric = new("metric");

    public static Units2 FromValue(string value) => FromValueCore(value);
}
