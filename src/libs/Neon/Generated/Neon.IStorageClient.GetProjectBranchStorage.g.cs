#nullable enable

namespace Neon
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Get branch storage state<br/>
        /// Returns whether branchable object-storage is usable for the specified<br/>
        /// branch. A 200 response means the branch is registered in the storage<br/>
        /// service and the S3 data plane will accept requests for it. A 404<br/>
        /// response includes a `reason` field indicating why storage is unavailable.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchStorage> GetProjectBranchStorageAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get branch storage state<br/>
        /// Returns whether branchable object-storage is usable for the specified<br/>
        /// branch. A 200 response means the branch is registered in the storage<br/>
        /// service and the S3 data plane will accept requests for it. A 404<br/>
        /// response includes a `reason` field indicating why storage is unavailable.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BranchStorage>> GetProjectBranchStorageAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}