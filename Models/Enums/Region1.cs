using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// The region code, specified as a <see href="https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains#Country_code_top-level_domains">ccTLD ("top-level domain")</see> two-character value. Most ccTLD codes are identical to ISO 3166-1 codes, with some notable exceptions. For example, the United Kingdom's ccTLD is "uk" (.co.uk) while its ISO 3166-1 code is "gb" (technically for the entity of "The United Kingdom of Great Britain and Northern Ireland").
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region1>))]
public sealed record Region1 : StringEnum<Region1>
{
    private Region1(string value) : base(value)
    {
    }

    public static readonly Region1 Ac = new("ac");

    public static readonly Region1 Ad = new("ad");

    public static readonly Region1 Ae = new("ae");

    public static readonly Region1 Af = new("af");

    public static readonly Region1 Ag = new("ag");

    public static readonly Region1 Ai = new("ai");

    public static readonly Region1 Al = new("al");

    public static readonly Region1 Am = new("am");

    public static readonly Region1 An = new("an");

    public static readonly Region1 Ao = new("ao");

    public static readonly Region1 Aq = new("aq");

    public static readonly Region1 Ar = new("ar");

    public static readonly Region1 As = new("as");

    public static readonly Region1 At = new("at");

    public static readonly Region1 Au = new("au");

    public static readonly Region1 Aw = new("aw");

    public static readonly Region1 Ax = new("ax");

    public static readonly Region1 Az = new("az");

    public static readonly Region1 Ba = new("ba");

    public static readonly Region1 Bb = new("bb");

    public static readonly Region1 Bd = new("bd");

    public static readonly Region1 Be = new("be");

    public static readonly Region1 Bf = new("bf");

    public static readonly Region1 Bg = new("bg");

    public static readonly Region1 Bh = new("bh");

    public static readonly Region1 Bi = new("bi");

    public static readonly Region1 Bj = new("bj");

    public static readonly Region1 Bl = new("bl");

    public static readonly Region1 Bm = new("bm");

    public static readonly Region1 Bn = new("bn");

    public static readonly Region1 Bo = new("bo");

    public static readonly Region1 Bq = new("bq");

    public static readonly Region1 Br = new("br");

    public static readonly Region1 Bs = new("bs");

    public static readonly Region1 Bt = new("bt");

    public static readonly Region1 Bv = new("bv");

    public static readonly Region1 Bw = new("bw");

    public static readonly Region1 By = new("by");

    public static readonly Region1 Bz = new("bz");

    public static readonly Region1 Ca = new("ca");

    public static readonly Region1 Cc = new("cc");

    public static readonly Region1 Cd = new("cd");

    public static readonly Region1 Cf = new("cf");

    public static readonly Region1 Cg = new("cg");

    public static readonly Region1 Ch = new("ch");

    public static readonly Region1 Ci = new("ci");

    public static readonly Region1 Ck = new("ck");

    public static readonly Region1 Cl = new("cl");

    public static readonly Region1 Cm = new("cm");

    public static readonly Region1 Cn = new("cn");

    public static readonly Region1 Co = new("co");

    public static readonly Region1 Cr = new("cr");

    public static readonly Region1 Cu = new("cu");

    public static readonly Region1 Cv = new("cv");

    public static readonly Region1 Cw = new("cw");

    public static readonly Region1 Cx = new("cx");

    public static readonly Region1 Cy = new("cy");

    public static readonly Region1 Cz = new("cz");

    public static readonly Region1 De = new("de");

    public static readonly Region1 Dj = new("dj");

    public static readonly Region1 Dk = new("dk");

    public static readonly Region1 Dm = new("dm");

    public static readonly Region1 Do = new("do");

    public static readonly Region1 Dz = new("dz");

    public static readonly Region1 Ec = new("ec");

    public static readonly Region1 Ee = new("ee");

    public static readonly Region1 Eg = new("eg");

    public static readonly Region1 Eh = new("eh");

    public static readonly Region1 En = new("en");

    public static readonly Region1 Er = new("er");

    public static readonly Region1 Es = new("es");

    public static readonly Region1 Et = new("et");

    public static readonly Region1 Eu = new("eu");

    public static readonly Region1 Fi = new("fi");

    public static readonly Region1 Fj = new("fj");

    public static readonly Region1 Fk = new("fk");

    public static readonly Region1 Fm = new("fm");

    public static readonly Region1 Fo = new("fo");

    public static readonly Region1 Fr = new("fr");

    public static readonly Region1 Ga = new("ga");

    public static readonly Region1 Gb = new("gb");

    public static readonly Region1 Gd = new("gd");

    public static readonly Region1 Ge = new("ge");

    public static readonly Region1 Gf = new("gf");

    public static readonly Region1 Gg = new("gg");

    public static readonly Region1 Gh = new("gh");

    public static readonly Region1 Gi = new("gi");

    public static readonly Region1 Gl = new("gl");

    public static readonly Region1 Gm = new("gm");

    public static readonly Region1 Gn = new("gn");

    public static readonly Region1 Gp = new("gp");

    public static readonly Region1 Gq = new("gq");

    public static readonly Region1 Gr = new("gr");

    public static readonly Region1 Gs = new("gs");

    public static readonly Region1 Gt = new("gt");

    public static readonly Region1 Gu = new("gu");

    public static readonly Region1 Gw = new("gw");

    public static readonly Region1 Gy = new("gy");

    public static readonly Region1 Hk = new("hk");

    public static readonly Region1 Hm = new("hm");

    public static readonly Region1 Hn = new("hn");

    public static readonly Region1 Hr = new("hr");

    public static readonly Region1 Ht = new("ht");

    public static readonly Region1 Hu = new("hu");

    public static readonly Region1 Id = new("id");

    public static readonly Region1 Ie = new("ie");

    public static readonly Region1 Il = new("il");

    public static readonly Region1 Im = new("im");

    public static readonly Region1 In = new("in");

    public static readonly Region1 Io = new("io");

    public static readonly Region1 Iq = new("iq");

    public static readonly Region1 Ir = new("ir");

    public static readonly Region1 Is = new("is");

    public static readonly Region1 It = new("it");

    public static readonly Region1 Je = new("je");

    public static readonly Region1 Jm = new("jm");

    public static readonly Region1 Jo = new("jo");

    public static readonly Region1 Jp = new("jp");

    public static readonly Region1 Ke = new("ke");

    public static readonly Region1 Kg = new("kg");

    public static readonly Region1 Kh = new("kh");

    public static readonly Region1 Ki = new("ki");

    public static readonly Region1 Km = new("km");

    public static readonly Region1 Kn = new("kn");

    public static readonly Region1 Kp = new("kp");

    public static readonly Region1 Kr = new("kr");

    public static readonly Region1 Kw = new("kw");

    public static readonly Region1 Ky = new("ky");

    public static readonly Region1 Kz = new("kz");

    public static readonly Region1 La = new("la");

    public static readonly Region1 Lb = new("lb");

    public static readonly Region1 Lc = new("lc");

    public static readonly Region1 Li = new("li");

    public static readonly Region1 Lk = new("lk");

    public static readonly Region1 Lr = new("lr");

    public static readonly Region1 Ls = new("ls");

    public static readonly Region1 Lt = new("lt");

    public static readonly Region1 Lu = new("lu");

    public static readonly Region1 Lv = new("lv");

    public static readonly Region1 Ly = new("ly");

    public static readonly Region1 Ma = new("ma");

    public static readonly Region1 Mc = new("mc");

    public static readonly Region1 Md = new("md");

    public static readonly Region1 Me = new("me");

    public static readonly Region1 Mf = new("mf");

    public static readonly Region1 Mg = new("mg");

    public static readonly Region1 Mh = new("mh");

    public static readonly Region1 Mk = new("mk");

    public static readonly Region1 Ml = new("ml");

    public static readonly Region1 Mm = new("mm");

    public static readonly Region1 Mn = new("mn");

    public static readonly Region1 Mo = new("mo");

    public static readonly Region1 Mp = new("mp");

    public static readonly Region1 Mq = new("mq");

    public static readonly Region1 Mr = new("mr");

    public static readonly Region1 Ms = new("ms");

    public static readonly Region1 Mt = new("mt");

    public static readonly Region1 Mu = new("mu");

    public static readonly Region1 Mv = new("mv");

    public static readonly Region1 Mw = new("mw");

    public static readonly Region1 Mx = new("mx");

    public static readonly Region1 My = new("my");

    public static readonly Region1 Mz = new("mz");

    public static readonly Region1 Na = new("na");

    public static readonly Region1 Nc = new("nc");

    public static readonly Region1 Ne = new("ne");

    public static readonly Region1 Nf = new("nf");

    public static readonly Region1 Ng = new("ng");

    public static readonly Region1 Ni = new("ni");

    public static readonly Region1 Nl = new("nl");

    public static readonly Region1 No = new("no");

    public static readonly Region1 Np = new("np");

    public static readonly Region1 Nr = new("nr");

    public static readonly Region1 Nu = new("nu");

    public static readonly Region1 Nz = new("nz");

    public static readonly Region1 Om = new("om");

    public static readonly Region1 Pa = new("pa");

    public static readonly Region1 Pe = new("pe");

    public static readonly Region1 Pf = new("pf");

    public static readonly Region1 Pg = new("pg");

    public static readonly Region1 Ph = new("ph");

    public static readonly Region1 Pk = new("pk");

    public static readonly Region1 Pl = new("pl");

    public static readonly Region1 Pm = new("pm");

    public static readonly Region1 Pn = new("pn");

    public static readonly Region1 Pr = new("pr");

    public static readonly Region1 Ps = new("ps");

    public static readonly Region1 Pt = new("pt");

    public static readonly Region1 Pw = new("pw");

    public static readonly Region1 Py = new("py");

    public static readonly Region1 Qa = new("qa");

    public static readonly Region1 Re = new("re");

    public static readonly Region1 Ro = new("ro");

    public static readonly Region1 Rs = new("rs");

    public static readonly Region1 Ru = new("ru");

    public static readonly Region1 Rw = new("rw");

    public static readonly Region1 Sa = new("sa");

    public static readonly Region1 Sb = new("sb");

    public static readonly Region1 Sc = new("sc");

    public static readonly Region1 Sd = new("sd");

    public static readonly Region1 Se = new("se");

    public static readonly Region1 Sg = new("sg");

    public static readonly Region1 Sh = new("sh");

    public static readonly Region1 Si = new("si");

    public static readonly Region1 Sj = new("sj");

    public static readonly Region1 Sk = new("sk");

    public static readonly Region1 Sl = new("sl");

    public static readonly Region1 Sm = new("sm");

    public static readonly Region1 Sn = new("sn");

    public static readonly Region1 So = new("so");

    public static readonly Region1 Sr = new("sr");

    public static readonly Region1 Ss = new("ss");

    public static readonly Region1 St = new("st");

    public static readonly Region1 Su = new("su");

    public static readonly Region1 Sv = new("sv");

    public static readonly Region1 Sx = new("sx");

    public static readonly Region1 Sy = new("sy");

    public static readonly Region1 Sz = new("sz");

    public static readonly Region1 Tc = new("tc");

    public static readonly Region1 Td = new("td");

    public static readonly Region1 Tf = new("tf");

    public static readonly Region1 Tg = new("tg");

    public static readonly Region1 Th = new("th");

    public static readonly Region1 Tj = new("tj");

    public static readonly Region1 Tk = new("tk");

    public static readonly Region1 Tl = new("tl");

    public static readonly Region1 Tm = new("tm");

    public static readonly Region1 Tn = new("tn");

    public static readonly Region1 To = new("to");

    public static readonly Region1 Tp = new("tp");

    public static readonly Region1 Tr = new("tr");

    public static readonly Region1 Tt = new("tt");

    public static readonly Region1 Tv = new("tv");

    public static readonly Region1 Tw = new("tw");

    public static readonly Region1 Tz = new("tz");

    public static readonly Region1 Ua = new("ua");

    public static readonly Region1 Ug = new("ug");

    public static readonly Region1 Uk = new("uk");

    public static readonly Region1 Um = new("um");

    public static readonly Region1 Us = new("us");

    public static readonly Region1 Uy = new("uy");

    public static readonly Region1 Uz = new("uz");

    public static readonly Region1 Va = new("va");

    public static readonly Region1 Vc = new("vc");

    public static readonly Region1 Ve = new("ve");

    public static readonly Region1 Vg = new("vg");

    public static readonly Region1 Vi = new("vi");

    public static readonly Region1 Vn = new("vn");

    public static readonly Region1 Vu = new("vu");

    public static readonly Region1 Wf = new("wf");

    public static readonly Region1 Ws = new("ws");

    public static readonly Region1 Ye = new("ye");

    public static readonly Region1 Yt = new("yt");

    public static readonly Region1 Za = new("za");

    public static readonly Region1 Zm = new("zm");

    public static readonly Region1 Zw = new("zw");

    public static Region1 FromValue(string value) => FromValueCore(value);
}
