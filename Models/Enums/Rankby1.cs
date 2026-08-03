using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Specifies the order in which results are listed. Possible values are:
/// - <c>prominence</c> (default). This option sorts results based on their importance. Ranking will favor prominent places within the set radius over nearby places that match but that are less prominent. Prominence can be affected by a place's ranking in Google's index, global popularity, and other factors. When prominence is specified, the <c>radius</c> parameter is required.
/// - <c>distance</c>. This option biases search results in ascending order by their distance from the specified location. When <c>distance</c> is specified, one or more of <c>keyword</c>, <c>name</c>, or <c>type</c> is required and <c>radius</c> is disallowed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Rankby1>))]
public sealed record Rankby1 : StringEnum<Rankby1>
{
    private Rankby1(string value) : base(value)
    {
    }

    public static readonly Rankby1 Prominence = new("prominence");

    public static readonly Rankby1 Distance = new("distance");

    public static Rankby1 FromValue(string value) => FromValueCore(value);
}
