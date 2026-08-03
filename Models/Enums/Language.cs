using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Language>))]
public sealed record Language : StringEnum<Language>
{
    private Language(string value) : base(value)
    {
    }

    public static readonly Language Ar = new("ar");

    public static readonly Language Bg = new("bg");

    public static readonly Language Bn = new("bn");

    public static readonly Language Ca = new("ca");

    public static readonly Language Cs = new("cs");

    public static readonly Language Da = new("da");

    public static readonly Language De = new("de");

    public static readonly Language El = new("el");

    public static readonly Language En = new("en");

    public static readonly Language EnAu = new("en-AU");

    public static readonly Language EnGb = new("en-GB");

    public static readonly Language Es = new("es");

    public static readonly Language Eu = new("eu");

    public static readonly Language Fa = new("fa");

    public static readonly Language Fi = new("fi");

    public static readonly Language Fil = new("fil");

    public static readonly Language Fr = new("fr");

    public static readonly Language Gl = new("gl");

    public static readonly Language Gu = new("gu");

    public static readonly Language Hi = new("hi");

    public static readonly Language Hr = new("hr");

    public static readonly Language Hu = new("hu");

    public static readonly Language Id = new("id");

    public static readonly Language It = new("it");

    public static readonly Language Iw = new("iw");

    public static readonly Language Ja = new("ja");

    public static readonly Language Kn = new("kn");

    public static readonly Language Ko = new("ko");

    public static readonly Language Lt = new("lt");

    public static readonly Language Lv = new("lv");

    public static readonly Language Ml = new("ml");

    public static readonly Language Mr = new("mr");

    public static readonly Language Nl = new("nl");

    public static readonly Language No = new("no");

    public static readonly Language Pl = new("pl");

    public static readonly Language Pt = new("pt");

    public static readonly Language PtBr = new("pt-BR");

    public static readonly Language PtPt = new("pt-PT");

    public static readonly Language Ro = new("ro");

    public static readonly Language Ru = new("ru");

    public static readonly Language Sk = new("sk");

    public static readonly Language Sl = new("sl");

    public static readonly Language Sr = new("sr");

    public static readonly Language Sv = new("sv");

    public static readonly Language Ta = new("ta");

    public static readonly Language Te = new("te");

    public static readonly Language Th = new("th");

    public static readonly Language Tl = new("tl");

    public static readonly Language Tr = new("tr");

    public static readonly Language Uk = new("uk");

    public static readonly Language Vi = new("vi");

    public static readonly Language ZhCn = new("zh-CN");

    public static readonly Language ZhTw = new("zh-TW");

    public static Language FromValue(string value) => FromValueCore(value);
}
