#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// List triggers on the branch<br/>
        /// Lists the complete project-bounded set of triggers visible on the branch,<br/>
        /// ordered by `trigger_id`. An inherited trigger keeps its project-wide ID<br/>
        /// and source branch, and is disabled on the child until explicitly enabled<br/>
        /// there.<br/>
        /// The supported trigger types are `schedule` and<br/>
        /// `storage_object_created`. A storage-object-created trigger watches one<br/>
        /// exact bucket and fires only after an object upload succeeds.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.TriggersListResponse> ListProjectBranchTriggersAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List triggers on the branch<br/>
        /// Lists the complete project-bounded set of triggers visible on the branch,<br/>
        /// ordered by `trigger_id`. An inherited trigger keeps its project-wide ID<br/>
        /// and source branch, and is disabled on the child until explicitly enabled<br/>
        /// there.<br/>
        /// The supported trigger types are `schedule` and<br/>
        /// `storage_object_created`. A storage-object-created trigger watches one<br/>
        /// exact bucket and fires only after an object upload succeeds.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.TriggersListResponse>> ListProjectBranchTriggersAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}