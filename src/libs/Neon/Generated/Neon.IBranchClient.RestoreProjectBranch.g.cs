#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Restore branch<br/>
        /// Restores a branch to an earlier state in its own or another branch's history
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchOperations> RestoreProjectBranchAsync(
            string projectId,
            string branchId,

            global::Neon.BranchRestoreRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore branch<br/>
        /// Restores a branch to an earlier state in its own or another branch's history
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="sourceBranchId">
        /// The `branch_id` of the restore source branch.<br/>
        /// If `source_timestamp` and `source_lsn` are omitted, the branch will be restored to head.<br/>
        /// If `source_branch_id` is equal to the branch's id, `source_timestamp` or `source_lsn` is required.
        /// </param>
        /// <param name="sourceLsn">
        /// A Log Sequence Number (LSN) on the source branch. The branch will be restored with data from this LSN.
        /// </param>
        /// <param name="sourceTimestamp">
        /// A timestamp identifying a point in time on the source branch. The branch will be restored with data starting from this point in time.<br/>
        /// The timestamp must be provided in ISO 8601 format; for example: `2024-02-26T12:00:00Z`.
        /// </param>
        /// <param name="preserveUnderName">
        /// If not empty, the previous state of the branch will be saved to a branch with this name.<br/>
        /// If the branch has children or the `source_branch_id` is equal to the branch id, this field is required. All existing child branches will be moved to the newly created branch under the name `preserve_under_name`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchOperations> RestoreProjectBranchAsync(
            string projectId,
            string branchId,
            string sourceBranchId,
            string? sourceLsn = default,
            global::System.DateTime? sourceTimestamp = default,
            string? preserveUnderName = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}