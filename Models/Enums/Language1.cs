using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The language in which to return results.
/// <list type="bullet">
///   <item><description>See the <see href="https://developers.google.com/maps/faq#languagesupport">list of supported languages</see>. Google often updates the supported languages, so this list may not be exhaustive.</description></item>
///   <item><description>If <c>language</c> is not supplied, the API attempts to use the preferred language as specified in the <c>Accept-Language</c> header.</description></item>
///   <item><description>The API does its best to provide a street address that is readable for both the user and locals. To achieve that goal, it returns street addresses in the local language, transliterated to a script readable by the user if necessary, observing the preferred language. All other addresses are returned in the preferred language. Address components are all returned in the same language, which is chosen from the first component.</description></item>
///   <item><description>If a name is not available in the preferred language, the API uses the closest match.</description></item>
///   <item><description>The preferred language has a small influence on the set of results that the API chooses to return, and the order in which they are returned. The geocoder interprets abbreviations differently depending on language, such as the abbreviations for street types, or synonyms that may be valid in one language but not in another. For example, _utca_ and _tér_ are synonyms for street in Hungarian.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Language1>))]
public sealed record Language1 : StringEnum<Language1>
{
    private Language1(string value) : base(value)
    {
    }

    public static readonly Language1 Ar = new("ar");

    public static readonly Language1 Bg = new("bg");

    public static readonly Language1 Bn = new("bn");

    public static readonly Language1 Ca = new("ca");

    public static readonly Language1 Cs = new("cs");

    public static readonly Language1 Da = new("da");

    public static readonly Language1 De = new("de");

    public static readonly Language1 El = new("el");

    public static readonly Language1 En = new("en");

    public static readonly Language1 EnAu = new("en-AU");

    public static readonly Language1 EnGb = new("en-GB");

    public static readonly Language1 Es = new("es");

    public static readonly Language1 Eu = new("eu");

    public static readonly Language1 Fa = new("fa");

    public static readonly Language1 Fi = new("fi");

    public static readonly Language1 Fil = new("fil");

    public static readonly Language1 Fr = new("fr");

    public static readonly Language1 Gl = new("gl");

    public static readonly Language1 Gu = new("gu");

    public static readonly Language1 Hi = new("hi");

    public static readonly Language1 Hr = new("hr");

    public static readonly Language1 Hu = new("hu");

    public static readonly Language1 Id = new("id");

    public static readonly Language1 It = new("it");

    public static readonly Language1 Iw = new("iw");

    public static readonly Language1 Ja = new("ja");

    public static readonly Language1 Kn = new("kn");

    public static readonly Language1 Ko = new("ko");

    public static readonly Language1 Lt = new("lt");

    public static readonly Language1 Lv = new("lv");

    public static readonly Language1 Ml = new("ml");

    public static readonly Language1 Mr = new("mr");

    public static readonly Language1 Nl = new("nl");

    public static readonly Language1 No = new("no");

    public static readonly Language1 Pl = new("pl");

    public static readonly Language1 Pt = new("pt");

    public static readonly Language1 PtBr = new("pt-BR");

    public static readonly Language1 PtPt = new("pt-PT");

    public static readonly Language1 Ro = new("ro");

    public static readonly Language1 Ru = new("ru");

    public static readonly Language1 Sk = new("sk");

    public static readonly Language1 Sl = new("sl");

    public static readonly Language1 Sr = new("sr");

    public static readonly Language1 Sv = new("sv");

    public static readonly Language1 Ta = new("ta");

    public static readonly Language1 Te = new("te");

    public static readonly Language1 Th = new("th");

    public static readonly Language1 Tl = new("tl");

    public static readonly Language1 Tr = new("tr");

    public static readonly Language1 Uk = new("uk");

    public static readonly Language1 Vi = new("vi");

    public static readonly Language1 ZhCn = new("zh-CN");

    public static readonly Language1 ZhTw = new("zh-TW");

    public static Language1 FromValue(string value) => FromValueCore(value);
}
