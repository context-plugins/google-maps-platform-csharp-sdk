using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TransitRoutingPreference>))]
public sealed record TransitRoutingPreference : StringEnum<TransitRoutingPreference>
{
    private TransitRoutingPreference(string value) : base(value)
    {
    }

    public static readonly TransitRoutingPreference LessWalking = new("less_walking");

    public static readonly TransitRoutingPreference FewerTransfers = new("fewer_transfers");

    public static TransitRoutingPreference FromValue(string value) => FromValueCore(value);
}
