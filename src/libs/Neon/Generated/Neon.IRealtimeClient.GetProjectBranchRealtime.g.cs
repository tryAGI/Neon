#nullable enable

namespace Neon
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Retrieve Realtime state<br/>
        /// Retrieves whether Realtime is enabled for the branch, whether a change is still being applied,<br/>
        /// and, once provisioned, its invocation URL and allowed origins. The shared secret is returned by<br/>
        /// `GET /projects/{project_id}/branches/{branch_id}/realtime/secret`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Realtime> GetProjectBranchRealtimeAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Realtime state<br/>
        /// Retrieves whether Realtime is enabled for the branch, whether a change is still being applied,<br/>
        /// and, once provisioned, its invocation URL and allowed origins. The shared secret is returned by<br/>
        /// `GET /projects/{project_id}/branches/{branch_id}/realtime/secret`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.Realtime>> GetProjectBranchRealtimeAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}