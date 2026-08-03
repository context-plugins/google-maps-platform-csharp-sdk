using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GoogleMapsPlatform.Core;
using GoogleMapsPlatform.Core.Exceptions;
using GoogleMapsPlatform.Core.Models;
using GoogleMapsPlatform.Core.Request;
using GoogleMapsPlatform.Core.Response;
using GoogleMapsPlatform.Errors;
using GoogleMapsPlatform.Models;

namespace GoogleMapsPlatform.Api;

public sealed class GeolocationApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GeolocationApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// geolocate
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeolocationV1GeolocateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GeolocateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Geolocation API returns a location and accuracy radius based on information about cell towers and WiFi nodes that the mobile client can detect. This document describes the protocol used to send this data to the server and to return a response to the client.
    /// <para>
    /// Communication is done over HTTPS using POST. Both request and response are formatted as JSON, and the content type of both is <c>application/json</c>.
    /// </para>
    /// <para>
    /// You must specify a key in your request, included as the value of a<c>key</c> parameter. A <c>key</c> is your application's  API key. This key identifies your application for purposes of quota management. Learn how to <see href="https://developers.google.com/maps/documentation/geolocation/get-api-key">get a key</see>.
    /// </para>
    /// </remarks>
    public Task<GeolocationV1GeolocateResponse> Geolocate(GeolocationV1GeolocateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/geolocation/v1/geolocate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GeolocationV1GeolocateResponse>(),
            GeolocateErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
