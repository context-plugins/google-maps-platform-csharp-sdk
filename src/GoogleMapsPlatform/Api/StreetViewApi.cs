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
using GoogleMapsPlatform.Requests.StreetViewApi;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Street View Static API lets you embed a static (non-interactive) Street View panorama or thumbnail into your web page, without the use of JavaScript. The viewport is defined with URL parameters sent through a standard HTTP request, and is returned as a static image.
    /// </remarks>
    public Task StreetView(StreetViewRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/streetview"),
            [],
            [
                new Param("size", request.Size),
                new Param("fov", request.Fov),
                new Param("heading", request.Heading),
                new Param("location", request.Location),
                new Param("pano", request.Pano),
                new Param("pitch", request.Pitch),
                new Param("radius", request.Radius),
                new Param("return_error_code", request.ReturnErrorCode),
                new Param("signature", request.Signature),
                new Param("source", request.Source),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// streetViewMetadata
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StreetViewResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The Street View Static API metadata requests provide data about Street View panoramas. Using the metadata, you can find out if a Street View image is available at a given location, as well as getting programmatic access to the latitude and longitude, the panorama ID, the date the photo was taken, and the copyright information for the image. Accessing this metadata allows you to customize error behavior in your application.
    /// </remarks>
    public Task<StreetViewResponse> StreetViewMetadata(StreetViewMetadataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/maps/api/streetview/metadata"),
            [],
            [
                new Param("heading", request.Heading),
                new Param("location", request.Location),
                new Param("pano", request.Pano),
                new Param("pitch", request.Pitch),
                new Param("radius", request.Radius),
                new Param("return_error_code", request.ReturnErrorCode),
                new Param("signature", request.Signature),
                new Param("size", request.Size),
                new Param("source", request.Source),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StreetViewResponse>(),
            RawErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
