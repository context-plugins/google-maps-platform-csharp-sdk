using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record DistanceMatrixResponse
{
    /// <summary>
    /// An array of addresses as returned by the API from your original request. These are formatted by the geocoder and localized according to the language parameter passed with the request. This content is meant to be read as-is. Do not programatically parse the formatted addresses.
    /// </summary>
    [JsonPropertyName("origin_addresses")]
    public required IReadOnlyList<string> OriginAddresses { get; init; }

    /// <summary>
    /// An array of addresses as returned by the API from your original request. As with <c>origin_addresses</c>, these are localized if appropriate. This content is meant to be read as-is. Do not programatically parse the formatted addresses.
    /// </summary>
    [JsonPropertyName("destination_addresses")]
    public required IReadOnlyList<string> DestinationAddresses { get; init; }

    /// <summary>
    /// An array of elements, which in turn each contain a <c>status</c>, <c>duration</c>, and <c>distance</c> element.
    /// </summary>
    [JsonPropertyName("rows")]
    public required IReadOnlyList<DistanceMatrixRow> Rows { get; init; }

    [JsonPropertyName("status")]
    public required DistanceMatrixStatus Status { get; init; }

    /// <summary>
    /// A string containing the human-readable text of any errors encountered while the request was being processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }
}
