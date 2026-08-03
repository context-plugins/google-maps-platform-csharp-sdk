using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Specifies the unit system to use when displaying results.
/// <para>
/// Directions results contain text within distance fields that may be displayed to the user to indicate the distance of a particular "step" of the route. By default, this text uses the unit system of the origin's country or region.
/// </para>
/// <para>
/// For example, a route from "Chicago, IL" to "Toronto, ONT" will display results in miles, while the reverse route will display results in kilometers. You may override this unit system by setting one explicitly within the request's units parameter, passing one of the following values:
/// </para>
/// <list type="bullet">
///   <item><description><c>metric</c> specifies usage of the metric system. Textual distances are returned using kilometers and meters.</description></item>
///   <item><description><c>imperial</c> specifies usage of the Imperial (English) system. Textual distances are returned using miles and feet.</description></item>
/// </list>
/// <para>
/// &lt;div class="note"&gt;Note: this unit system setting only affects the text displayed within distance fields. The distance fields also contain values which are always expressed in meters.&lt;/div&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Units1>))]
public sealed record Units1 : StringEnum<Units1>
{
    private Units1(string value) : base(value)
    {
    }

    public static readonly Units1 Imperial = new("imperial");

    public static readonly Units1 Metric = new("metric");

    public static Units1 FromValue(string value) => FromValueCore(value);
}
