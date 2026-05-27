#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Recover a deleted branch<br/>
        /// Recovers a deleted branch within the 7-day deletion recovery period.<br/>
        /// The branch must have been soft deleted and not yet permanently deleted.<br/>
        /// Recovery restores the branch and its endpoints to an idle state.<br/>
        /// Connection strings remain valid after recovery.<br/>
        /// TTL branches become non-TTL branches after recovery.<br/>
        /// To list deleted branches available for recovery, use `GET /projects/{project_id}/branches?include_deleted=true`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchRecoverResponse> RecoverProjectBranchAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recover a deleted branch<br/>
        /// Recovers a deleted branch within the 7-day deletion recovery period.<br/>
        /// The branch must have been soft deleted and not yet permanently deleted.<br/>
        /// Recovery restores the branch and its endpoints to an idle state.<br/>
        /// Connection strings remain valid after recovery.<br/>
        /// TTL branches become non-TTL branches after recovery.<br/>
        /// To list deleted branches available for recovery, use `GET /projects/{project_id}/branches?include_deleted=true`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BranchRecoverResponse>> RecoverProjectBranchAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}