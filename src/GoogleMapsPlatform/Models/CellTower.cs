using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// Attributes used to describe a cell tower. The following optional fields are not currently used, but may be included if values are available: <c>age</c>, <c>signalStrength</c>, <c>timingAdvance</c>.
/// </summary>
public record CellTower
{
    /// <summary>
    /// Unique identifier of the cell. On GSM, this is the Cell ID (CID); CDMA networks use the Base Station ID (BID). WCDMA networks use the UTRAN/GERAN Cell Identity (UC-Id), which is a 32-bit value concatenating the Radio Network Controller (RNC) and Cell ID. Specifying only the 16-bit Cell ID value in WCDMA networks may return inaccurate results.
    /// </summary>
    [JsonPropertyName("cellId")]
    public required int CellId { get; init; }

    /// <summary>
    /// The Location Area Code (LAC) for GSM and WCDMA networks. The Network ID (NID) for CDMA networks.
    /// </summary>
    [JsonPropertyName("locationAreaCode")]
    public required int LocationAreaCode { get; init; }

    /// <summary>
    /// The cell tower's Mobile Country Code (MCC).
    /// </summary>
    [JsonPropertyName("mobileCountryCode")]
    public required int MobileCountryCode { get; init; }

    /// <summary>
    /// The cell tower's Mobile Network Code. This is the MNC for GSM and WCDMA; CDMA uses the System ID (SID).
    /// </summary>
    [JsonPropertyName("mobileNetworkCode")]
    public required int MobileNetworkCode { get; init; }

    /// <summary>
    /// The number of milliseconds since this cell was primary. If age is 0, the cellId represents a current measurement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("age")]
    public int? Age { get; init; }

    /// <summary>
    /// Radio signal strength measured in dBm.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signalStrength")]
    public double? SignalStrength { get; init; }

    /// <summary>
    /// The timing advance value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timingAdvance")]
    public double? TimingAdvance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
