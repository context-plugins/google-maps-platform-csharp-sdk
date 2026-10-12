using System;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Language>))]
public sealed record Language : OpenStringEnum<Language>
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
