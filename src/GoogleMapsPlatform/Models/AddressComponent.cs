using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record AddressComponent
{
    /// <summary>
    /// The full text description or name of the address component as returned by the Geocoder.
    /// </summary>
    [JsonPropertyName("long_name")]
    public required string LongName { get; init; }

    /// <summary>
    /// An abbreviated textual name for the address component, if available. For example, an address component for the state of Alaska may have a long_name of "Alaska" and a short_name of "AK" using the 2-letter postal abbreviation.
    /// </summary>
    [JsonPropertyName("short_name")]
    public required string ShortName { get; init; }

    /// <summary>
    /// An array indicating the type of the address component. See the list of <see href="https://developers.google.com/maps/documentation/places/web-service/supported_types">supported types</see>.
    /// </summary>
    [JsonPropertyName("types")]
    public required IReadOnlyList<string> Types { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
