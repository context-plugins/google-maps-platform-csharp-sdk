using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Specifies preferences for transit routes. Using this parameter, you can bias the options returned, rather than accepting the default best route chosen by the API. This parameter may only be specified for transit directions. The parameter supports the following arguments:
/// * <c>less_walking</c> indicates that the calculated route should prefer limited amounts of walking.
/// * <c>fewer_transfers</c> indicates that the calculated route should prefer a limited number of transfers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransitRoutingPreference1>))]
public sealed record TransitRoutingPreference1 : StringEnum<TransitRoutingPreference1>
{
    private TransitRoutingPreference1(string value) : base(value)
    {
    }

    public static readonly TransitRoutingPreference1 LessWalking = new("less_walking");

    public static readonly TransitRoutingPreference1 FewerTransfers = new("fewer_transfers");

    public static TransitRoutingPreference1 FromValue(string value) => FromValueCore(value);
}
