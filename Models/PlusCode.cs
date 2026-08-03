using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

/// <summary>
/// An encoded location reference, derived from latitude and longitude coordinates, that represents an area, 1/8000th of a degree by 1/8000th of a degree (about 14m x 14m at the equator) or smaller. Plus codes can be used as a replacement for street addresses in places where they do not exist (where buildings are not numbered or streets are not named).
/// </summary>
public record PlusCode
{
    /// <summary>
    /// The <c>compound_code</c> is a 6 character or longer local code with an explicit location (<c>CWC8+R9, Mountain View, CA, USA</c>). Some APIs may return an empty string if the <c>compound_code</c> is not available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compound_code")]
    public string? CompoundCode { get; init; }

    /// <summary>
    /// The <c>global_code</c> is a 4 character area code and 6 character or longer local code (<c>849VCWC8+R9</c>).
    /// </summary>
    [JsonPropertyName("global_code")]
    public required string GlobalCode { get; init; }
}
