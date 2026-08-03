using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Inputtype>))]
public sealed record Inputtype : StringEnum<Inputtype>
{
    private Inputtype(string value) : base(value)
    {
    }

    public static readonly Inputtype Textquery = new("textquery");

    public static readonly Inputtype Phonenumber = new("phonenumber");

    public static Inputtype FromValue(string value) => FromValueCore(value);
}
