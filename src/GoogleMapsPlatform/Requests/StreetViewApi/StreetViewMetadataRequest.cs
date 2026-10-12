using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Requests.StreetViewApi;

/// <summary>
/// The inputs of the StreetViewMetadata operation.
/// </summary>
public sealed record StreetViewMetadataRequest
{
    /// <summary>
    /// Indicates the compass heading of the camera. Accepted values are from 0 to 360 (both values indicating North, with 90 indicating East, and 180 South). If no heading is specified, a value will be calculated that directs the camera towards the specified location, from the point at which the closest photograph was taken.
    /// </summary>
    public double? Heading { get; init; }

    /// <summary>
    /// The point around which to retrieve place information. The Street View Static API will snap to the panorama photographed closest to this location. When an address text string is provided, the API may use a different camera location to better display the specified location. When a lat/lng is provided, the API searches a 50 meter radius for a photograph closest to this location. Because Street View imagery is periodically refreshed, and photographs may be taken from slightly different positions each time, it's possible that your <c>location</c> may snap to a different panorama when imagery is updated.
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// A specific panorama ID. These are generally stable, though panoramas may change ID over time as imagery is refreshed.
    /// </summary>
    public string? Pano { get; init; }

    /// <summary>
    /// Specifies the up or down angle of the camera relative to the Street View vehicle. This is often, but not always, flat horizontal. Positive values angle the camera up (with 90 degrees indicating straight up); negative values angle the camera down (with -90 indicating straight down). Default is 0.
    /// </summary>
    public double? Pitch { get; init; }

    /// <summary>
    /// Sets a radius, specified in meters, in which to search for a panorama, centered on the given latitude and longitude. Valid values are non-negative integers. Default is 50 meters.
    /// </summary>
    public double? Radius { get; init; }

    /// <summary>
    /// Indicates whether the API should return a non <c>200 Ok</c> HTTP status when no image is found (<c>404 NOT FOUND</c>), or in response to an invalid request (400 BAD REQUEST). Valid values are <c>true</c> and <c>false</c>. If set to <c>true</c>, an error message is returned in place of the generic gray image. This eliminates the need to make a separate call to check for image availability.
    /// </summary>
    public bool? ReturnErrorCode { get; init; }

    /// <summary>
    /// A digital signature used to verify that any site generating requests using your API key is authorized to do so. Requests that do not include a digital signature might fail. For more information, see <see href="https://developers.google.com/maps/documentation/streetview/get-api-key">Get a Key and Signature</see>.
    /// </summary>
    public string? Signature { get; init; }

    /// <summary>
    /// Specifies the output size of the image in pixels. Size is specified as <c>{width}x{height}</c> - for example, <c>size=600x400</c> returns an image 600 pixels wide, and 400 high.
    /// </summary>
    public string? Size { get; init; }

    /// <summary>
    /// Limits Street View searches to selected sources. Valid values are:
    /// * <c>default</c> uses the default sources for Street View; searches are not limited to specific sources.
    /// * <c>outdoor</c> limits searches to outdoor collections. Indoor collections are not included in search results. Note that outdoor panoramas may not exist for the specified location. Also note that the search only returns panoramas where it's possible to determine whether they're indoors or outdoors. For example, PhotoSpheres are not returned because it's unknown whether they are indoors or outdoors.
    /// </summary>
    public Source1? Source { get; init; }
}
