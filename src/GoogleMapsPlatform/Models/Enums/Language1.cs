using System;
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
public sealed record Language1 : OpenStringEnum<Language1>
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

    public TResult Match<TResult>(Func<TResult> onAr,
        Func<TResult> onBg,
        Func<TResult> onBn,
        Func<TResult> onCa,
        Func<TResult> onCs,
        Func<TResult> onDa,
        Func<TResult> onDe,
        Func<TResult> onEl,
        Func<TResult> onEn,
        Func<TResult> onEnAu,
        Func<TResult> onEnGb,
        Func<TResult> onEs,
        Func<TResult> onEu,
        Func<TResult> onFa,
        Func<TResult> onFi,
        Func<TResult> onFil,
        Func<TResult> onFr,
        Func<TResult> onGl,
        Func<TResult> onGu,
        Func<TResult> onHi,
        Func<TResult> onHr,
        Func<TResult> onHu,
        Func<TResult> onId,
        Func<TResult> onIt,
        Func<TResult> onIw,
        Func<TResult> onJa,
        Func<TResult> onKn,
        Func<TResult> onKo,
        Func<TResult> onLt,
        Func<TResult> onLv,
        Func<TResult> onMl,
        Func<TResult> onMr,
        Func<TResult> onNl,
        Func<TResult> onNo,
        Func<TResult> onPl,
        Func<TResult> onPt,
        Func<TResult> onPtBr,
        Func<TResult> onPtPt,
        Func<TResult> onRo,
        Func<TResult> onRu,
        Func<TResult> onSk,
        Func<TResult> onSl,
        Func<TResult> onSr,
        Func<TResult> onSv,
        Func<TResult> onTa,
        Func<TResult> onTe,
        Func<TResult> onTh,
        Func<TResult> onTl,
        Func<TResult> onTr,
        Func<TResult> onUk,
        Func<TResult> onVi,
        Func<TResult> onZhCn,
        Func<TResult> onZhTw,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ar => onAr(),
            _ when this == Bg => onBg(),
            _ when this == Bn => onBn(),
            _ when this == Ca => onCa(),
            _ when this == Cs => onCs(),
            _ when this == Da => onDa(),
            _ when this == De => onDe(),
            _ when this == El => onEl(),
            _ when this == En => onEn(),
            _ when this == EnAu => onEnAu(),
            _ when this == EnGb => onEnGb(),
            _ when this == Es => onEs(),
            _ when this == Eu => onEu(),
            _ when this == Fa => onFa(),
            _ when this == Fi => onFi(),
            _ when this == Fil => onFil(),
            _ when this == Fr => onFr(),
            _ when this == Gl => onGl(),
            _ when this == Gu => onGu(),
            _ when this == Hi => onHi(),
            _ when this == Hr => onHr(),
            _ when this == Hu => onHu(),
            _ when this == Id => onId(),
            _ when this == It => onIt(),
            _ when this == Iw => onIw(),
            _ when this == Ja => onJa(),
            _ when this == Kn => onKn(),
            _ when this == Ko => onKo(),
            _ when this == Lt => onLt(),
            _ when this == Lv => onLv(),
            _ when this == Ml => onMl(),
            _ when this == Mr => onMr(),
            _ when this == Nl => onNl(),
            _ when this == No => onNo(),
            _ when this == Pl => onPl(),
            _ when this == Pt => onPt(),
            _ when this == PtBr => onPtBr(),
            _ when this == PtPt => onPtPt(),
            _ when this == Ro => onRo(),
            _ when this == Ru => onRu(),
            _ when this == Sk => onSk(),
            _ when this == Sl => onSl(),
            _ when this == Sr => onSr(),
            _ when this == Sv => onSv(),
            _ when this == Ta => onTa(),
            _ when this == Te => onTe(),
            _ when this == Th => onTh(),
            _ when this == Tl => onTl(),
            _ when this == Tr => onTr(),
            _ when this == Uk => onUk(),
            _ when this == Vi => onVi(),
            _ when this == ZhCn => onZhCn(),
            _ when this == ZhTw => onZhTw(),
            _ => otherwise(Value)
        };

    public void Match(Action onAr,
        Action onBg,
        Action onBn,
        Action onCa,
        Action onCs,
        Action onDa,
        Action onDe,
        Action onEl,
        Action onEn,
        Action onEnAu,
        Action onEnGb,
        Action onEs,
        Action onEu,
        Action onFa,
        Action onFi,
        Action onFil,
        Action onFr,
        Action onGl,
        Action onGu,
        Action onHi,
        Action onHr,
        Action onHu,
        Action onId,
        Action onIt,
        Action onIw,
        Action onJa,
        Action onKn,
        Action onKo,
        Action onLt,
        Action onLv,
        Action onMl,
        Action onMr,
        Action onNl,
        Action onNo,
        Action onPl,
        Action onPt,
        Action onPtBr,
        Action onPtPt,
        Action onRo,
        Action onRu,
        Action onSk,
        Action onSl,
        Action onSr,
        Action onSv,
        Action onTa,
        Action onTe,
        Action onTh,
        Action onTl,
        Action onTr,
        Action onUk,
        Action onVi,
        Action onZhCn,
        Action onZhTw,
        Action<string> otherwise)
    {
        if (this == Ar) onAr();
        else if (this == Bg) onBg();
        else if (this == Bn) onBn();
        else if (this == Ca) onCa();
        else if (this == Cs) onCs();
        else if (this == Da) onDa();
        else if (this == De) onDe();
        else if (this == El) onEl();
        else if (this == En) onEn();
        else if (this == EnAu) onEnAu();
        else if (this == EnGb) onEnGb();
        else if (this == Es) onEs();
        else if (this == Eu) onEu();
        else if (this == Fa) onFa();
        else if (this == Fi) onFi();
        else if (this == Fil) onFil();
        else if (this == Fr) onFr();
        else if (this == Gl) onGl();
        else if (this == Gu) onGu();
        else if (this == Hi) onHi();
        else if (this == Hr) onHr();
        else if (this == Hu) onHu();
        else if (this == Id) onId();
        else if (this == It) onIt();
        else if (this == Iw) onIw();
        else if (this == Ja) onJa();
        else if (this == Kn) onKn();
        else if (this == Ko) onKo();
        else if (this == Lt) onLt();
        else if (this == Lv) onLv();
        else if (this == Ml) onMl();
        else if (this == Mr) onMr();
        else if (this == Nl) onNl();
        else if (this == No) onNo();
        else if (this == Pl) onPl();
        else if (this == Pt) onPt();
        else if (this == PtBr) onPtBr();
        else if (this == PtPt) onPtPt();
        else if (this == Ro) onRo();
        else if (this == Ru) onRu();
        else if (this == Sk) onSk();
        else if (this == Sl) onSl();
        else if (this == Sr) onSr();
        else if (this == Sv) onSv();
        else if (this == Ta) onTa();
        else if (this == Te) onTe();
        else if (this == Th) onTh();
        else if (this == Tl) onTl();
        else if (this == Tr) onTr();
        else if (this == Uk) onUk();
        else if (this == Vi) onVi();
        else if (this == ZhCn) onZhCn();
        else if (this == ZhTw) onZhTw();
        else otherwise(Value);
    }
}
