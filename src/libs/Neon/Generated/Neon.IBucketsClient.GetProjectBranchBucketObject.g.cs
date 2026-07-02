#nullable enable

namespace Neon
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Download an object's bytes<br/>
        /// Streams the raw bytes of the named object from the bucket on the<br/>
        /// specified branch, including objects inherited from ancestor branches.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// The body is returned as `application/octet-stream` so a browser treats<br/>
        /// it as a download; the `Content-Length` and `ETag` response headers echo<br/>
        /// the stored object metadata.<br/>
        /// BINARY-STREAM EXCEPTION TO THE BUILD-GENERATED-TYPES RULE (#7029): the<br/>
        /// successful 200 body is the raw object stream, proxied verbatim from the<br/>
        /// platform storage admin endpoint. It is modeled as an<br/>
        /// `application/octet-stream` binary body (not a JSON response schema) and<br/>
        /// is streamed without buffering the whole object in memory. Error<br/>
        /// responses still use the generated `GeneralError` shape.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetProjectBranchBucketObjectAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download an object's bytes<br/>
        /// Streams the raw bytes of the named object from the bucket on the<br/>
        /// specified branch, including objects inherited from ancestor branches.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// The body is returned as `application/octet-stream` so a browser treats<br/>
        /// it as a download; the `Content-Length` and `ETag` response headers echo<br/>
        /// the stored object metadata.<br/>
        /// BINARY-STREAM EXCEPTION TO THE BUILD-GENERATED-TYPES RULE (#7029): the<br/>
        /// successful 200 body is the raw object stream, proxied verbatim from the<br/>
        /// platform storage admin endpoint. It is modeled as an<br/>
        /// `application/octet-stream` binary body (not a JSON response schema) and<br/>
        /// is streamed without buffering the whole object in memory. Error<br/>
        /// responses still use the generated `GeneralError` shape.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetProjectBranchBucketObjectAsStreamAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download an object's bytes<br/>
        /// Streams the raw bytes of the named object from the bucket on the<br/>
        /// specified branch, including objects inherited from ancestor branches.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// The body is returned as `application/octet-stream` so a browser treats<br/>
        /// it as a download; the `Content-Length` and `ETag` response headers echo<br/>
        /// the stored object metadata.<br/>
        /// BINARY-STREAM EXCEPTION TO THE BUILD-GENERATED-TYPES RULE (#7029): the<br/>
        /// successful 200 body is the raw object stream, proxied verbatim from the<br/>
        /// platform storage admin endpoint. It is modeled as an<br/>
        /// `application/octet-stream` binary body (not a JSON response schema) and<br/>
        /// is streamed without buffering the whole object in memory. Error<br/>
        /// responses still use the generated `GeneralError` shape.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<byte[]>> GetProjectBranchBucketObjectAsResponseAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}