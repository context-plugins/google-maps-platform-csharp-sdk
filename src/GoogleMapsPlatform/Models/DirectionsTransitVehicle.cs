using System.Text.Json.Serialization;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Models;

public record DirectionsTransitVehicle
{
    /// <summary>
    /// Contains the URL for an icon associated with this vehicle type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    /// <summary>
    /// Contains the URL for the icon associated with this vehicle type, based on the local transport signage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("local_icon")]
    public string? LocalIcon { get; init; }

    /// <summary>
    /// The name of this vehicle, capitalized.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicle_type")]
    public VehicleType? VehicleType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
