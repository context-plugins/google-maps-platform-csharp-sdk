using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record GeolocationV1GeolocateRequest
{
    /// <summary>
    /// The cell tower's Mobile Country Code (MCC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homeMobileCountryCode")]
    public int? HomeMobileCountryCode { get; init; }

    /// <summary>
    /// The cell tower's Mobile Network Code. This is the MNC for GSM and WCDMA; CDMA uses the System ID (SID).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homeMobileNetworkCode")]
    public int? HomeMobileNetworkCode { get; init; }

    /// <summary>
    /// The mobile radio type. Supported values are lte, gsm, cdma, and wcdma. While this field is optional, it should be included if a value is available, for more accurate results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("radioType")]
    public string? RadioType { get; init; }

    /// <summary>
    /// The carrier name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrier")]
    public string? Carrier { get; init; }

    /// <summary>
    /// Specifies whether to fall back to IP geolocation if wifi and cell tower signals are not available. Defaults to true. Set considerIp to false to disable fall back.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("considerIp")]
    public string? ConsiderIp { get; init; }

    /// <summary>
    /// The request body's cellTowers array contains zero or more cell tower objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cellTowers")]
    public IReadOnlyList<CellTower>? CellTowers { get; init; }

    /// <summary>
    /// An array of two or more WiFi access point objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wifiAccessPoints")]
    public IReadOnlyList<WiFiAccessPoint>? WifiAccessPoints { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
