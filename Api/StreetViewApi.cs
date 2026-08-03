using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core;
using GoogleMapsPlatform.Core.ErrorResponse;
using GoogleMapsPlatform.Core.Exceptions;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Core.Request;
using GoogleMapsPlatform.Core.Response;
using GoogleMapsPlatform.Models;
using GoogleMapsPlatform.Models.Enums;

namespace GoogleMapsPlatform.Api;

public sealed class StreetViewApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal StreetViewApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// streetView
    /// </summary>
    /// <param name="size">Specifies the output size of the image in pixels. Must not exceed 640 pixels wide or high, anything over will default to 640 pixels. Size is specified as <c>{width}x{height}</c> - for example, <c>size=600x400</c> returns an image 600 pixels wide, and 400 high.</param>
    /// <param name="fov">Determines the horizontal field of view of the image. The field of view is expressed in degrees, with a maximum allowed value of 120. When dealing with a fixed-size viewport, as with a Street View image of a set size, field of view in essence represents zoom, with smaller numbers indicating a higher level of zoom. Default is 90.</param>
    /// <param name="heading">Indicates the compass heading of the camera. Accepted values are from 0 to 360 (both values indicating North, with 90 indicating East, and 180 South). If no heading is specified, a value will be calculated that directs the camera towards the specified location, from the point at which the closest photograph was taken.</param>
    /// <param name="location">The point around which to retrieve place information. The Street View Static API will snap to the panorama photographed closest to this location. When an address text string is provided, the API may use a different camera location to better display the specified location. When a lat/lng is provided, the API searches a 50 meter radius for a photograph closest to this location. Because Street View imagery is periodically refreshed, and photographs may be taken from slightly different positions each time, it's possible that your <c>location</c> may snap to a different panorama when imagery is updated.</param>
    /// <param name="pano">A specific panorama ID. These are generally stable, though panoramas may change ID over time as imagery is refreshed.</param>
    /// <param name="pitch">Specifies the up or down angle of the camera relative to the Street View vehicle. This is often, but not always, flat horizontal. Positive values angle the camera up (with 90 degrees indicating straight up); negative values angle the camera down (with -90 indicating straight down). Default is 0.</param>
    /// <param name="radius">Sets a radius, specified in meters, in which to search for a panorama, centered on the given latitude and longitude. Valid values are non-negative integers. Default is 50 meters.</param>
    /// <param name="returnErrorCode">Indicates whether the API should return a non <c>200 Ok</c> HTTP status when no image is found (<c>404 NOT FOUND</c>), or in response to an invalid request (400 BAD REQUEST). Valid values are <c>true</c> and <c>false</c>. If set to <c>true</c>, an error message is returned in place of the generic gray image. This eliminates the need to make a separate call to check for image availability.</param>
    /// <param name="signature">A digital signature used to verify that any site generating requests using your API key is authorized to do so. Requests that do not include a digital signature might fail. For more information, see <see href="https://developers.google.com/maps/documentation/streetview/get-api-key">Get a Key and Signature</see>.</param>
    /// <param name="source">Limits Street View searches to selected sources. Valid values are: * <c>default</c> uses the default sources for Street View; searches are not limited to specific sources. * <c>outdoor</c> limits searches to outdoor collections. Indoor collections are not included in search results. Note that outdoor panoramas may not exist for the specified location. Also note that the search only returns panoramas where it's possible to determine whether they're indoors or outdoors. For example, PhotoSpheres are not returned because it's unknown whether they are indoors or outdoors.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Street View Static API lets you embed a static (non-interactive) Street View panorama or thumbnail into your web page, without the use of JavaScript. The viewport is defined with URL parameters sent through a standard HTTP request, and is returned as a static image.
    /// </remarks>
    public Task StreetView(string size,
        double? fov,
        double? heading,
        string? location,
        string? pano,
        double? pitch,
        double? radius,
        bool? returnErrorCode,
        string? signature,
        Source1? source,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/streetview"),
            [],
            [new Param("size", size),
                new Param("fov", fov),
                new Param("heading", heading),
                new Param("location", location),
                new Param("pano", pano),
                new Param("pitch", pitch),
                new Param("radius", radius),
                new Param("return_error_code", returnErrorCode),
                new Param("signature", signature),
                new Param("source", source)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// streetViewMetadata
    /// </summary>
    /// <param name="heading">Indicates the compass heading of the camera. Accepted values are from 0 to 360 (both values indicating North, with 90 indicating East, and 180 South). If no heading is specified, a value will be calculated that directs the camera towards the specified location, from the point at which the closest photograph was taken.</param>
    /// <param name="location">The point around which to retrieve place information. The Street View Static API will snap to the panorama photographed closest to this location. When an address text string is provided, the API may use a different camera location to better display the specified location. When a lat/lng is provided, the API searches a 50 meter radius for a photograph closest to this location. Because Street View imagery is periodically refreshed, and photographs may be taken from slightly different positions each time, it's possible that your <c>location</c> may snap to a different panorama when imagery is updated.</param>
    /// <param name="pano">A specific panorama ID. These are generally stable, though panoramas may change ID over time as imagery is refreshed.</param>
    /// <param name="pitch">Specifies the up or down angle of the camera relative to the Street View vehicle. This is often, but not always, flat horizontal. Positive values angle the camera up (with 90 degrees indicating straight up); negative values angle the camera down (with -90 indicating straight down). Default is 0.</param>
    /// <param name="radius">Sets a radius, specified in meters, in which to search for a panorama, centered on the given latitude and longitude. Valid values are non-negative integers. Default is 50 meters.</param>
    /// <param name="returnErrorCode">Indicates whether the API should return a non <c>200 Ok</c> HTTP status when no image is found (<c>404 NOT FOUND</c>), or in response to an invalid request (400 BAD REQUEST). Valid values are <c>true</c> and <c>false</c>. If set to <c>true</c>, an error message is returned in place of the generic gray image. This eliminates the need to make a separate call to check for image availability.</param>
    /// <param name="signature">A digital signature used to verify that any site generating requests using your API key is authorized to do so. Requests that do not include a digital signature might fail. For more information, see <see href="https://developers.google.com/maps/documentation/streetview/get-api-key">Get a Key and Signature</see>.</param>
    /// <param name="size">Specifies the output size of the image in pixels. Size is specified as <c>{width}x{height}</c> - for example, <c>size=600x400</c> returns an image 600 pixels wide, and 400 high.</param>
    /// <param name="source">Limits Street View searches to selected sources. Valid values are: * <c>default</c> uses the default sources for Street View; searches are not limited to specific sources. * <c>outdoor</c> limits searches to outdoor collections. Indoor collections are not included in search results. Note that outdoor panoramas may not exist for the specified location. Also note that the search only returns panoramas where it's possible to determine whether they're indoors or outdoors. For example, PhotoSpheres are not returned because it's unknown whether they are indoors or outdoors.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StreetViewResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Street View Static API metadata requests provide data about Street View panoramas. Using the metadata, you can find out if a Street View image is available at a given location, as well as getting programmatic access to the latitude and longitude, the panorama ID, the date the photo was taken, and the copyright information for the image. Accessing this metadata allows you to customize error behavior in your application.
    /// </remarks>
    public Task<StreetViewResponse> StreetViewMetadata(double? heading,
        string? location,
        string? pano,
        double? pitch,
        double? radius,
        bool? returnErrorCode,
        string? signature,
        string? size,
        Source1? source,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/maps/api/streetview/metadata"),
            [],
            [new Param("heading", heading),
                new Param("location", location),
                new Param("pano", pano),
                new Param("pitch", pitch),
                new Param("radius", radius),
                new Param("return_error_code", returnErrorCode),
                new Param("signature", signature),
                new Param("size", size),
                new Param("source", source)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StreetViewResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
