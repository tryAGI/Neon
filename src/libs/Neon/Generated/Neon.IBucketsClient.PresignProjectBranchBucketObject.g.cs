#nullable enable

namespace Neon
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Presign an upload or download for an object in a bucket<br/>
        /// Returns a presigned URL that transfers bytes directly to or from the<br/>
        /// object's bucket on the specified branch, without the caller ever<br/>
        /// handling S3 credentials. The `operation` field selects the direction:<br/>
        /// - `upload` returns a presigned `PUT` URL (the caller `PUT`s the file<br/>
        ///   bytes straight to `url` with the returned `headers`). Authorized with<br/>
        ///   project write access.<br/>
        /// - `download` returns a presigned `GET` URL (the caller `GET`s the<br/>
        ///   bytes straight from `url`). Authorized with project read access.<br/>
        /// The platform mints a short-lived credential and builds the SigV4-signed<br/>
        /// URL against the branch's S3 data-plane host, returning it together with<br/>
        /// the HTTP method, any headers the caller must echo, and the URL's expiry.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.PresignResponse> PresignProjectBranchBucketObjectAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,

            global::Neon.PresignRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Presign an upload or download for an object in a bucket<br/>
        /// Returns a presigned URL that transfers bytes directly to or from the<br/>
        /// object's bucket on the specified branch, without the caller ever<br/>
        /// handling S3 credentials. The `operation` field selects the direction:<br/>
        /// - `upload` returns a presigned `PUT` URL (the caller `PUT`s the file<br/>
        ///   bytes straight to `url` with the returned `headers`). Authorized with<br/>
        ///   project write access.<br/>
        /// - `download` returns a presigned `GET` URL (the caller `GET`s the<br/>
        ///   bytes straight from `url`). Authorized with project read access.<br/>
        /// The platform mints a short-lived credential and builds the SigV4-signed<br/>
        /// URL against the branch's S3 data-plane host, returning it together with<br/>
        /// the HTTP method, any headers the caller must echo, and the URL's expiry.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.PresignResponse>> PresignProjectBranchBucketObjectAsResponseAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,

            global::Neon.PresignRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Presign an upload or download for an object in a bucket<br/>
        /// Returns a presigned URL that transfers bytes directly to or from the<br/>
        /// object's bucket on the specified branch, without the caller ever<br/>
        /// handling S3 credentials. The `operation` field selects the direction:<br/>
        /// - `upload` returns a presigned `PUT` URL (the caller `PUT`s the file<br/>
        ///   bytes straight to `url` with the returned `headers`). Authorized with<br/>
        ///   project write access.<br/>
        /// - `download` returns a presigned `GET` URL (the caller `GET`s the<br/>
        ///   bytes straight from `url`). Authorized with project read access.<br/>
        /// The platform mints a short-lived credential and builds the SigV4-signed<br/>
        /// URL against the branch's S3 data-plane host, returning it together with<br/>
        /// the HTTP method, any headers the caller must echo, and the URL's expiry.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="operation">
        /// The transfer direction. `upload` returns a presigned `PUT` URL;<br/>
        /// `download` returns a presigned `GET` URL.
        /// </param>
        /// <param name="contentType">
        /// The `Content-Type` to bind into the signed request. Only meaningful<br/>
        /// for `upload`: when set, the caller MUST send the same `Content-Type`<br/>
        /// header on the `PUT`, and the value is echoed back in the response<br/>
        /// `headers`. Ignored for `download`.
        /// </param>
        /// <param name="expiresInSeconds">
        /// How long the presigned URL stays valid, in seconds. Defaults to 900<br/>
        /// (15 minutes); capped at 604800 (7 days).<br/>
        /// Default Value: 900
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.PresignResponse> PresignProjectBranchBucketObjectAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,
            global::Neon.PresignRequestOperation operation,
            string? contentType = default,
            long? expiresInSeconds = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}