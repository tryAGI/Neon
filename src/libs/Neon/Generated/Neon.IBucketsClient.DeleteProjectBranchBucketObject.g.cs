#nullable enable

namespace Neon
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Delete an object in a bucket<br/>
        /// Deletes the named object from the bucket on the specified branch.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteProjectBranchBucketObjectAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an object in a bucket<br/>
        /// Deletes the named object from the bucket on the specified branch.<br/>
        /// Served by the user's session (no customer S3 credentials required).<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="objectKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> DeleteProjectBranchBucketObjectAsResponseAsync(
            string projectId,
            string branchId,
            string bucketName,
            string objectKey,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}