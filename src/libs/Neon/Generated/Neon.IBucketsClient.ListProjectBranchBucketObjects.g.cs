#nullable enable

namespace Neon
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// List objects in a bucket<br/>
        /// Lists objects visible in the named bucket on the specified branch,<br/>
        /// including those inherited from ancestor branches. Listing is served by<br/>
        /// the user's session (no customer S3 credentials required).<br/>
        /// When `delimiter` is supplied (typically `/`), keys are collapsed into<br/>
        /// common prefixes (`folders`) so callers can render a folder-style<br/>
        /// browser; keys that do not contain the delimiter after `prefix` are<br/>
        /// returned as `objects`.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="delimiter"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BucketObjectsListResponse> ListProjectBranchBucketObjectsAsync(
            string projectId,
            string branchId,
            string bucketName,
            string? prefix = default,
            string? delimiter = default,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List objects in a bucket<br/>
        /// Lists objects visible in the named bucket on the specified branch,<br/>
        /// including those inherited from ancestor branches. Listing is served by<br/>
        /// the user's session (no customer S3 credentials required).<br/>
        /// When `delimiter` is supplied (typically `/`), keys are collapsed into<br/>
        /// common prefixes (`folders`) so callers can render a folder-style<br/>
        /// browser; keys that do not contain the delimiter after `prefix` are<br/>
        /// returned as `objects`.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="delimiter"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BucketObjectsListResponse>> ListProjectBranchBucketObjectsAsResponseAsync(
            string projectId,
            string branchId,
            string bucketName,
            string? prefix = default,
            string? delimiter = default,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}