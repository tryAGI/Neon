#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// List project snapshots<br/>
        /// List the snapshots for the specified project.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ListSnapshotsResponse> ListSnapshotsAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}