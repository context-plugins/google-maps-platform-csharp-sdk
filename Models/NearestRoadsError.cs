using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record NearestRoadsError
{
    /// <summary>
    /// This is the same as the HTTP status of the response.
    /// </summary>
    [JsonPropertyName("code")]
    public required double Code { get; init; }

    /// <summary>
    /// A short description of the error.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// An error such as <c>INVALID_ARGUMENT</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
