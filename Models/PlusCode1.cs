using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record PlusCode1
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
