using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Limits Street View searches to selected sources. Valid values are:
/// * <c>default</c> uses the default sources for Street View; searches are not limited to specific sources.
/// * <c>outdoor</c> limits searches to outdoor collections. Indoor collections are not included in search results. Note that outdoor panoramas may not exist for the specified location. Also note that the search only returns panoramas where it's possible to determine whether they're indoors or outdoors. For example, PhotoSpheres are not returned because it's unknown whether they are indoors or outdoors.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Source1>))]
public sealed record Source1 : StringEnum<Source1>
{
    private Source1(string value) : base(value)
    {
    }

    public static readonly Source1 Default = new("default");

    public static readonly Source1 Outdoor = new("outdoor");

    public static Source1 FromValue(string value) => FromValueCore(value);
}
