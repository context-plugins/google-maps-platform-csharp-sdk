using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record GeocodingResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plus_code")]
    public PlusCode1? PlusCode { get; init; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<GeocodingResult> Results { get; init; }

    [JsonPropertyName("status")]
    public required GeocodingStatus Status { get; init; }

    /// <summary>
    /// A short description of the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }
}
