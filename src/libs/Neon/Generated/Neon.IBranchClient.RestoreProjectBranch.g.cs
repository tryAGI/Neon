#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Restore branch to a historical state<br/>
        /// Restores a branch to an earlier state in its own or another branch's history<br/>
        /// by specifying an LSN or timestamp.<br/>
        /// Creates a new branch from the historical state.
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
        /// Restore branch to a historical state<br/>
        /// Restores a branch to an earlier state in its own or another branch's history<br/>
        /// by specifying an LSN or timestamp.<br/>
        /// Creates a new branch from the historical state.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BranchOperations>> RestoreProjectBranchAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.BranchRestoreRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore branch to a historical state<br/>
        /// Restores a branch to an earlier state in its own or another branch's history<br/>
        /// by specifying an LSN or timestamp.<br/>
        /// Creates a new branch from the historical state.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="sourceBranchId">
        /// The `branch_id` of the restore source branch.<br/>
        /// If `source_timestamp` and `source_lsn` are omitted, the branch will be restored to head.<br/>
        /// If `source_branch_id` is equal to the branch's id, `source_timestamp` or `source_lsn` is required.
        /// </param>
        /// <param name="sourceLsn">
        /// A Postgres LSN (for example, `0/1A2B3C4`) on the source branch to restore from.<br/>
        /// Mutually exclusive with `source_timestamp`. Omit both to restore to head.
        /// </param>
        /// <param name="sourceTimestamp">
        /// A point in time on the source branch to restore from, in RFC 3339 format. When omitted alongside `source_lsn`, the branch is restored to the latest available state of the source branch.<br/>
        /// Example: 2024-02-26T12:00:00Z
        /// </param>
        /// <param name="preserveUnderName">
        /// Name under which to save the current branch state before restoring. Required when the branch has children or when `source_branch_id` equals the branch being restored; in those cases all existing child branches are moved to the newly created branch. If omitted and not required, the previous state is not preserved.
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