#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Finalize branch restore from snapshot<br/>
        /// Finalize the restore operation for a branch created from a snapshot.<br/>
        /// This operation updates the branch so it functions as the original branch it replaced.<br/>
        /// This includes:<br/>
        ///   - Reassigning any computes from the original branch to the restored branch (this will restart the computes)<br/>
        ///   - Renaming the restored branch to the original branch's name<br/>
        ///   - Renaming the original branch so it no longer uses the original name<br/>
        /// This operation only applies to branches created using the `restoreSnapshot` endpoint with `finalize_restore: false`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OperationsResponse> FinalizeRestoreBranchAsync(
            string projectId,
            string branchId,

            global::Neon.FinalizeRestoreBranchRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Finalize branch restore from snapshot<br/>
        /// Finalize the restore operation for a branch created from a snapshot.<br/>
        /// This operation updates the branch so it functions as the original branch it replaced.<br/>
        /// This includes:<br/>
        ///   - Reassigning any computes from the original branch to the restored branch (this will restart the computes)<br/>
        ///   - Renaming the restored branch to the original branch's name<br/>
        ///   - Renaming the original branch so it no longer uses the original name<br/>
        /// This operation only applies to branches created using the `restoreSnapshot` endpoint with `finalize_restore: false`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.OperationsResponse>> FinalizeRestoreBranchAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.FinalizeRestoreBranchRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Finalize branch restore from snapshot<br/>
        /// Finalize the restore operation for a branch created from a snapshot.<br/>
        /// This operation updates the branch so it functions as the original branch it replaced.<br/>
        /// This includes:<br/>
        ///   - Reassigning any computes from the original branch to the restored branch (this will restart the computes)<br/>
        ///   - Renaming the restored branch to the original branch's name<br/>
        ///   - Renaming the original branch so it no longer uses the original name<br/>
        /// This operation only applies to branches created using the `restoreSnapshot` endpoint with `finalize_restore: false`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="name">
        /// Name for the replaced branch. If omitted, a unique name is generated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OperationsResponse> FinalizeRestoreBranchAsync(
            string projectId,
            string branchId,
            string? name = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}