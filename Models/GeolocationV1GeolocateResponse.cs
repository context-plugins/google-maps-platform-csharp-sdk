using System.Text.Json.Serialization;

namespace GoogleMapsPlatform.Models;

public record GeolocationV1GeolocateResponse
{
    [JsonPropertyName("location")]
    public required Location Location { get; init; }

    /// <summary>
    /// The accuracy of the estimated location, in meters. This represents the radius of a circle around the given <c>location</c>. If your Geolocation response shows a very high value in the <c>accuracy</c> field, the service may be geolocating based on the  request IP, instead of WiFi points or cell towers. This can happen if no cell towers or access points are valid or recognized. To confirm that this is the issue, set <c>considerIp</c> to <c>false</c> in your request. If the response is a <c>404</c>, you've confirmed that your <c>wifiAccessPoints</c> and <c>cellTowers</c> objects could not be geolocated.
    /// </summary>
    [JsonPropertyName("accuracy")]
    public required double Accuracy { get; init; }
}
