using System.Collections.Generic;
using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;

namespace GoogleMapsPlatform.Models;

public record ErrorObject
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
    /// A list of errors which occurred. Each error contains an identifier for the type of error and a short description.
    /// </summary>
    [JsonPropertyName("errors")]
    public required IReadOnlyList<ErrorDetail> Errors { get; init; }

    /// <summary>
    /// A status code that indicates the error type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Additional details about the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<ErrorDetail>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
