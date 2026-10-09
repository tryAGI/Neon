#nullable enable

namespace Neon
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Retrieve the Realtime shared secret<br/>
        /// Retrieves the secret the application backend issues Realtime tokens with. Requires permission to<br/>
        /// read the project's credentials. Returns 404 while Realtime is disabled or before the secret is<br/>
        /// provisioned. After a rotation, this returns the previous secret until `pending` is false.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RealtimeSecret> GetProjectBranchRealtimeSecretAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve the Realtime shared secret<br/>
        /// Retrieves the secret the application backend issues Realtime tokens with. Requires permission to<br/>
        /// read the project's credentials. Returns 404 while Realtime is disabled or before the secret is<br/>
        /// provisioned. After a rotation, this returns the previous secret until `pending` is false.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.RealtimeSecret>> GetProjectBranchRealtimeSecretAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}