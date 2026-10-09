#nullable enable

namespace Neon
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Rotate the Realtime shared secret<br/>
        /// Replaces the branch's Realtime shared secret. Rotation is asynchronous: once the Realtime state is<br/>
        /// no longer pending, the previous secret stops working and<br/>
        /// `GET /projects/{project_id}/branches/{branch_id}/realtime/secret` returns the new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task RotateProjectBranchRealtimeSecretAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate the Realtime shared secret<br/>
        /// Replaces the branch's Realtime shared secret. Rotation is asynchronous: once the Realtime state is<br/>
        /// no longer pending, the previous secret stops working and<br/>
        /// `GET /projects/{project_id}/branches/{branch_id}/realtime/secret` returns the new one.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> RotateProjectBranchRealtimeSecretAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}