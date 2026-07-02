#nullable enable

namespace Neon
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Delete every object under a key prefix (folder) in a bucket<br/>
        /// Soft-deletes every object on the specified branch whose key starts with<br/>
        /// `prefix`, in a single call. Intended to back a "delete folder" action in<br/>
        /// an object browser: a `prefix` of `app/avatars/` removes every object<br/>
        /// beneath that folder. Served by the user's session (no customer S3<br/>
        /// credentials required).<br/>
        /// `prefix` must be non-empty, end with `/`, be at most 1024 bytes, and<br/>
        /// contain no control characters - a partial-segment prefix cannot<br/>
        /// accidentally delete sibling keys. Returns the number of objects<br/>
        /// soft-deleted (`deleted`), which may be 0 when no live object matched the<br/>
        /// prefix on this branch.<br/>
        /// Only objects physically present on this branch are tombstoned; objects<br/>
        /// inherited from an ancestor branch via copy-on-write (not materialized on<br/>
        /// this branch) are out of scope.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BucketObjectsDeletePrefixResponse> DeleteProjectBranchBucketObjectsByPrefixAsync(
            string prefix,
            string projectId,
            string branchId,
            string bucketName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete every object under a key prefix (folder) in a bucket<br/>
        /// Soft-deletes every object on the specified branch whose key starts with<br/>
        /// `prefix`, in a single call. Intended to back a "delete folder" action in<br/>
        /// an object browser: a `prefix` of `app/avatars/` removes every object<br/>
        /// beneath that folder. Served by the user's session (no customer S3<br/>
        /// credentials required).<br/>
        /// `prefix` must be non-empty, end with `/`, be at most 1024 bytes, and<br/>
        /// contain no control characters - a partial-segment prefix cannot<br/>
        /// accidentally delete sibling keys. Returns the number of objects<br/>
        /// soft-deleted (`deleted`), which may be 0 when no live object matched the<br/>
        /// prefix on this branch.<br/>
        /// Only objects physically present on this branch are tombstoned; objects<br/>
        /// inherited from an ancestor branch via copy-on-write (not materialized on<br/>
        /// this branch) are out of scope.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="bucketName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BucketObjectsDeletePrefixResponse>> DeleteProjectBranchBucketObjectsByPrefixAsResponseAsync(
            string prefix,
            string projectId,
            string branchId,
            string bucketName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}