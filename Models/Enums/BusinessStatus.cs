using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Enum;

namespace GoogleMapsPlatform.Models.Enums;

/// <summary>
/// Indicates the operational status of the place, if it is a business. If no data exists, <c>business_status</c> is not returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessStatus>))]
public sealed record BusinessStatus : StringEnum<BusinessStatus>
{
    private BusinessStatus(string value) : base(value)
    {
    }

    public static readonly BusinessStatus Operational = new("OPERATIONAL");

    public static readonly BusinessStatus ClosedTemporarily = new("CLOSED_TEMPORARILY");

    public static readonly BusinessStatus ClosedPermanently = new("CLOSED_PERMANENTLY");

    public static BusinessStatus FromValue(string value) => FromValueCore(value);
}
