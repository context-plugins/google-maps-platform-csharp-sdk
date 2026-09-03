using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// The total fare for the route.
/// <code>
/// {
///   "currency" : "USD",
///   "value" : 6,
///   "text" : "$6.00"
/// }
/// </code>
/// </summary>
public record Fare
{
    /// <summary>
    /// An <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217 currency code</see> indicating the currency that the amount is expressed in.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The total fare amount, in the currency specified.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    /// <summary>
    /// The total fare amount, formatted in the requested language.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
