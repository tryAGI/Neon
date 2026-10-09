#nullable enable

namespace Neon
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Enable Realtime<br/>
        /// Enables Realtime for the branch, or applies new options to an enabled branch. Provisioning is<br/>
        /// asynchronous; poll the Realtime state until it is no longer pending.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task EnableProjectBranchRealtimeAsync(
            string projectId,
            string branchId,

            global::Neon.RealtimeOptions request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Realtime<br/>
        /// Enables Realtime for the branch, or applies new options to an enabled branch. Provisioning is<br/>
        /// asynchronous; poll the Realtime state until it is no longer pending.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> EnableProjectBranchRealtimeAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.RealtimeOptions request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Realtime<br/>
        /// Enables Realtime for the branch, or applies new options to an enabled branch. Provisioning is<br/>
        /// asynchronous; poll the Realtime state until it is no longer pending.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="allowedOrigins">
        /// The browser origins allowed to connect, each `http` or `https` with a host and optional port<br/>
        /// and no path. An empty list, or `*` alone, allows any origin. Omitted keeps the current or<br/>
        /// inherited value.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EnableProjectBranchRealtimeAsync(
            string projectId,
            string branchId,
            global::System.Collections.Generic.IList<string>? allowedOrigins = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}