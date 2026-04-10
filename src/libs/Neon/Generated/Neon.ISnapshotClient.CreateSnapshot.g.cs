#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// Create snapshot<br/>
        /// Create a snapshot from the specified branch using the provided parameters.<br/>
        /// This endpoint may initiate an asynchronous operation.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="lsn"></param>
        /// <param name="timestamp"></param>
        /// <param name="name"></param>
        /// <param name="expiresAt"></param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CreateSnapshotResponse> CreateSnapshotAsync(
            string projectId,
            string branchId,
            string? lsn = default,
            string? timestamp = default,
            string? name = default,
            string? expiresAt = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}