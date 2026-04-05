#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// Restore snapshot<br/>
        /// Restore the specified snapshot to a new branch and optionally finalize the restore operation.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="snapshotId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>> RestoreSnapshotAsync(
            string projectId,
            string snapshotId,

            global::Neon.RestoreSnapshotRequest request,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore snapshot<br/>
        /// Restore the specified snapshot to a new branch and optionally finalize the restore operation.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="snapshotId"></param>
        /// <param name="requestName">
        /// A name for the newly restored branch.<br/>
        /// If omitted, a default name will be generated.
        /// </param>
        /// <param name="targetBranchId">
        /// The ID of the branch to restore the snapshot into.<br/>
        /// If not specified, the branch from which the snapshot was originally<br/>
        /// created (`snapshot.source_branch_id`) will be used.
        /// </param>
        /// <param name="finalizeRestore">
        /// Set to `true` to finalize the restore operation immediately.<br/>
        /// This will complete the restore and move any associated computes to the new branch,<br/>
        /// similar to the `finalizeRestoreBranch` operation.<br/>
        /// Defaults to `false` to allow previewing the restored snapshot data first.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsOptionalResponse, global::Neon.OperationsResponse>> RestoreSnapshotAsync(
            string projectId,
            string snapshotId,
            string? name = default,
            string? requestName = default,
            string? targetBranchId = default,
            bool? finalizeRestore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}