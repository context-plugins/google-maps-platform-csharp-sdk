using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// Attributes used to describe a WiFi access point.
/// </summary>
public record WiFiAccessPoint
{
    /// <summary>
    /// The MAC address of the WiFi node. It's typically called a BSS, BSSID or MAC address. Separators must be <c>:</c> (colon).
    /// </summary>
    [JsonPropertyName("macAddress")]
    public required string MacAddress { get; init; }

    /// <summary>
    /// The current signal strength measured in dBm.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signalStrength")]
    public int? SignalStrength { get; init; }

    /// <summary>
    /// The current signal to noise ratio measured in dB.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signalToNoiseRatio")]
    public int? SignalToNoiseRatio { get; init; }

    /// <summary>
    /// The number of milliseconds since this access point was detected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("age")]
    public int? Age { get; init; }

    /// <summary>
    /// The channel over which the client is communication with the access point.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public int? Channel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
