#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// List project snapshots<br/>
        /// Lists the snapshots for the specified project.<br/>
        /// Each snapshot represents a point-in-time backup of the project data.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ListSnapshotsResponse> ListSnapshotsAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List project snapshots<br/>
        /// Lists the snapshots for the specified project.<br/>
        /// Each snapshot represents a point-in-time backup of the project data.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ListSnapshotsResponse>> ListSnapshotsAsResponseAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}