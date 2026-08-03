using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Region>))]
public sealed record Region : StringEnum<Region>
{
    private Region(string value) : base(value)
    {
    }

    public static readonly Region Ac = new("ac");

    public static readonly Region Ad = new("ad");

    public static readonly Region Ae = new("ae");

    public static readonly Region Af = new("af");

    public static readonly Region Ag = new("ag");

    public static readonly Region Ai = new("ai");

    public static readonly Region Al = new("al");

    public static readonly Region Am = new("am");

    public static readonly Region An = new("an");

    public static readonly Region Ao = new("ao");

    public static readonly Region Aq = new("aq");

    public static readonly Region Ar = new("ar");

    public static readonly Region As = new("as");

    public static readonly Region At = new("at");

    public static readonly Region Au = new("au");

    public static readonly Region Aw = new("aw");

    public static readonly Region Ax = new("ax");

    public static readonly Region Az = new("az");

    public static readonly Region Ba = new("ba");

    public static readonly Region Bb = new("bb");

    public static readonly Region Bd = new("bd");

    public static readonly Region Be = new("be");

    public static readonly Region Bf = new("bf");

    public static readonly Region Bg = new("bg");

    public static readonly Region Bh = new("bh");

    public static readonly Region Bi = new("bi");

    public static readonly Region Bj = new("bj");

    public static readonly Region Bl = new("bl");

    public static readonly Region Bm = new("bm");

    public static readonly Region Bn = new("bn");

    public static readonly Region Bo = new("bo");

    public static readonly Region Bq = new("bq");

    public static readonly Region Br = new("br");

    public static readonly Region Bs = new("bs");

    public static readonly Region Bt = new("bt");

    public static readonly Region Bv = new("bv");

    public static readonly Region Bw = new("bw");

    public static readonly Region By = new("by");

    public static readonly Region Bz = new("bz");

    public static readonly Region Ca = new("ca");

    public static readonly Region Cc = new("cc");

    public static readonly Region Cd = new("cd");

    public static readonly Region Cf = new("cf");

    public static readonly Region Cg = new("cg");

    public static readonly Region Ch = new("ch");

    public static readonly Region Ci = new("ci");

    public static readonly Region Ck = new("ck");

    public static readonly Region Cl = new("cl");

    public static readonly Region Cm = new("cm");

    public static readonly Region Cn = new("cn");

    public static readonly Region Co = new("co");

    public static readonly Region Cr = new("cr");

    public static readonly Region Cu = new("cu");

    public static readonly Region Cv = new("cv");

    public static readonly Region Cw = new("cw");

    public static readonly Region Cx = new("cx");

    public static readonly Region Cy = new("cy");

    public static readonly Region Cz = new("cz");

    public static readonly Region De = new("de");

    public static readonly Region Dj = new("dj");

    public static readonly Region Dk = new("dk");

    public static readonly Region Dm = new("dm");

    public static readonly Region Do = new("do");

    public static readonly Region Dz = new("dz");

    public static readonly Region Ec = new("ec");

    public static readonly Region Ee = new("ee");

    public static readonly Region Eg = new("eg");

    public static readonly Region Eh = new("eh");

    public static readonly Region En = new("en");

    public static readonly Region Er = new("er");

    public static readonly Region Es = new("es");

    public static readonly Region Et = new("et");

    public static readonly Region Eu = new("eu");

    public static readonly Region Fi = new("fi");

    public static readonly Region Fj = new("fj");

    public static readonly Region Fk = new("fk");

    public static readonly Region Fm = new("fm");

    public static readonly Region Fo = new("fo");

    public static readonly Region Fr = new("fr");

    public static readonly Region Ga = new("ga");

    public static readonly Region Gb = new("gb");

    public static readonly Region Gd = new("gd");

    public static readonly Region Ge = new("ge");

    public static readonly Region Gf = new("gf");

    public static readonly Region Gg = new("gg");

    public static readonly Region Gh = new("gh");

    public static readonly Region Gi = new("gi");

    public static readonly Region Gl = new("gl");

    public static readonly Region Gm = new("gm");

    public static readonly Region Gn = new("gn");

    public static readonly Region Gp = new("gp");

    public static readonly Region Gq = new("gq");

    public static readonly Region Gr = new("gr");

    public static readonly Region Gs = new("gs");

    public static readonly Region Gt = new("gt");

    public static readonly Region Gu = new("gu");

    public static readonly Region Gw = new("gw");

    public static readonly Region Gy = new("gy");

    public static readonly Region Hk = new("hk");

    public static readonly Region Hm = new("hm");

    public static readonly Region Hn = new("hn");

    public static readonly Region Hr = new("hr");

    public static readonly Region Ht = new("ht");

    public static readonly Region Hu = new("hu");

    public static readonly Region Id = new("id");

    public static readonly Region Ie = new("ie");

    public static readonly Region Il = new("il");

    public static readonly Region Im = new("im");

    public static readonly Region In = new("in");

    public static readonly Region Io = new("io");

    public static readonly Region Iq = new("iq");

    public static readonly Region Ir = new("ir");

    public static readonly Region Is = new("is");

    public static readonly Region It = new("it");

    public static readonly Region Je = new("je");

    public static readonly Region Jm = new("jm");

    public static readonly Region Jo = new("jo");

    public static readonly Region Jp = new("jp");

    public static readonly Region Ke = new("ke");

    public static readonly Region Kg = new("kg");

    public static readonly Region Kh = new("kh");

    public static readonly Region Ki = new("ki");

    public static readonly Region Km = new("km");

    public static readonly Region Kn = new("kn");

    public static readonly Region Kp = new("kp");

    public static readonly Region Kr = new("kr");

    public static readonly Region Kw = new("kw");

    public static readonly Region Ky = new("ky");

    public static readonly Region Kz = new("kz");

    public static readonly Region La = new("la");

    public static readonly Region Lb = new("lb");

    public static readonly Region Lc = new("lc");

    public static readonly Region Li = new("li");

    public static readonly Region Lk = new("lk");

    public static readonly Region Lr = new("lr");

    public static readonly Region Ls = new("ls");

    public static readonly Region Lt = new("lt");

    public static readonly Region Lu = new("lu");

    public static readonly Region Lv = new("lv");

    public static readonly Region Ly = new("ly");

    public static readonly Region Ma = new("ma");

    public static readonly Region Mc = new("mc");

    public static readonly Region Md = new("md");

    public static readonly Region Me = new("me");

    public static readonly Region Mf = new("mf");

    public static readonly Region Mg = new("mg");

    public static readonly Region Mh = new("mh");

    public static readonly Region Mk = new("mk");

    public static readonly Region Ml = new("ml");

    public static readonly Region Mm = new("mm");

    public static readonly Region Mn = new("mn");

    public static readonly Region Mo = new("mo");

    public static readonly Region Mp = new("mp");

    public static readonly Region Mq = new("mq");

    public static readonly Region Mr = new("mr");

    public static readonly Region Ms = new("ms");

    public static readonly Region Mt = new("mt");

    public static readonly Region Mu = new("mu");

    public static readonly Region Mv = new("mv");

    public static readonly Region Mw = new("mw");

    public static readonly Region Mx = new("mx");

    public static readonly Region My = new("my");

    public static readonly Region Mz = new("mz");

    public static readonly Region Na = new("na");

    public static readonly Region Nc = new("nc");

    public static readonly Region Ne = new("ne");

    public static readonly Region Nf = new("nf");

    public static readonly Region Ng = new("ng");

    public static readonly Region Ni = new("ni");

    public static readonly Region Nl = new("nl");

    public static readonly Region No = new("no");

    public static readonly Region Np = new("np");

    public static readonly Region Nr = new("nr");

    public static readonly Region Nu = new("nu");

    public static readonly Region Nz = new("nz");

    public static readonly Region Om = new("om");

    public static readonly Region Pa = new("pa");

    public static readonly Region Pe = new("pe");

    public static readonly Region Pf = new("pf");

    public static readonly Region Pg = new("pg");

    public static readonly Region Ph = new("ph");

    public static readonly Region Pk = new("pk");

    public static readonly Region Pl = new("pl");

    public static readonly Region Pm = new("pm");

    public static readonly Region Pn = new("pn");

    public static readonly Region Pr = new("pr");

    public static readonly Region Ps = new("ps");

    public static readonly Region Pt = new("pt");

    public static readonly Region Pw = new("pw");

    public static readonly Region Py = new("py");

    public static readonly Region Qa = new("qa");

    public static readonly Region Re = new("re");

    public static readonly Region Ro = new("ro");

    public static readonly Region Rs = new("rs");

    public static readonly Region Ru = new("ru");

    public static readonly Region Rw = new("rw");

    public static readonly Region Sa = new("sa");

    public static readonly Region Sb = new("sb");

    public static readonly Region Sc = new("sc");

    public static readonly Region Sd = new("sd");

    public static readonly Region Se = new("se");

    public static readonly Region Sg = new("sg");

    public static readonly Region Sh = new("sh");

    public static readonly Region Si = new("si");

    public static readonly Region Sj = new("sj");

    public static readonly Region Sk = new("sk");

    public static readonly Region Sl = new("sl");

    public static readonly Region Sm = new("sm");

    public static readonly Region Sn = new("sn");

    public static readonly Region So = new("so");

    public static readonly Region Sr = new("sr");

    public static readonly Region Ss = new("ss");

    public static readonly Region St = new("st");

    public static readonly Region Su = new("su");

    public static readonly Region Sv = new("sv");

    public static readonly Region Sx = new("sx");

    public static readonly Region Sy = new("sy");

    public static readonly Region Sz = new("sz");

    public static readonly Region Tc = new("tc");

    public static readonly Region Td = new("td");

    public static readonly Region Tf = new("tf");

    public static readonly Region Tg = new("tg");

    public static readonly Region Th = new("th");

    public static readonly Region Tj = new("tj");

    public static readonly Region Tk = new("tk");

    public static readonly Region Tl = new("tl");

    public static readonly Region Tm = new("tm");

    public static readonly Region Tn = new("tn");

    public static readonly Region To = new("to");

    public static readonly Region Tp = new("tp");

    public static readonly Region Tr = new("tr");

    public static readonly Region Tt = new("tt");

    public static readonly Region Tv = new("tv");

    public static readonly Region Tw = new("tw");

    public static readonly Region Tz = new("tz");

    public static readonly Region Ua = new("ua");

    public static readonly Region Ug = new("ug");

    public static readonly Region Uk = new("uk");

    public static readonly Region Um = new("um");

    public static readonly Region Us = new("us");

    public static readonly Region Uy = new("uy");

    public static readonly Region Uz = new("uz");

    public static readonly Region Va = new("va");

    public static readonly Region Vc = new("vc");

    public static readonly Region Ve = new("ve");

    public static readonly Region Vg = new("vg");

    public static readonly Region Vi = new("vi");

    public static readonly Region Vn = new("vn");

    public static readonly Region Vu = new("vu");

    public static readonly Region Wf = new("wf");

    public static readonly Region Ws = new("ws");

    public static readonly Region Ye = new("ye");

    public static readonly Region Yt = new("yt");

    public static readonly Region Za = new("za");

    public static readonly Region Zm = new("zm");

    public static readonly Region Zw = new("zw");

    public static Region FromValue(string value) => FromValueCore(value);
}
