namespace GoogleMapsPlatform.Requests.PlacesApi;

/// <summary>
/// The inputs of the PlacePhoto operation.
/// </summary>
public sealed record PlacePhotoRequest
{
    /// <summary>
    /// A string identifier that uniquely identifies a photo. Photo references are returned from either a Place Search or Place Details request.
    /// </summary>
    public required string PhotoReference { get; init; }

    /// <summary>
    /// Specifies the maximum desired height, in pixels, of the image. If the image is smaller than the values specified, the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the two dimensions, restricted to its original aspect ratio. Both the <c>maxheight</c> and <c>maxwidth</c> properties accept an integer between <c>1</c> and <c>1600</c>.
    /// </summary>
    public double? Maxheight { get; init; }

    /// <summary>
    /// Specifies the maximum desired width, in pixels, of the image. If the image is smaller than the values specified, the original image will be returned. If the image is larger in either dimension, it will be scaled to match the smaller of the two dimensions, restricted to its original aspect ratio. Both the <c>maxheight</c> and <c>maxwidth</c> properties accept an integer between <c>1</c> and <c>1600</c>.
    /// </summary>
    public double? Maxwidth { get; init; }
}
