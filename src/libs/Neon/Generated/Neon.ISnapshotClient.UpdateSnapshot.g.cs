#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// Update snapshot<br/>
        /// Update the specified snapshot.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="snapshotId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.UpdateSnapshotResponse> UpdateSnapshotAsync(
            string projectId,
            string snapshotId,

            global::Neon.SnapshotUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update snapshot<br/>
        /// Update the specified snapshot.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshot"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.UpdateSnapshotResponse> UpdateSnapshotAsync(
            string projectId,
            string snapshotId,
            global::Neon.SnapshotUpdateRequestSnapshot snapshot,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}