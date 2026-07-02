#nullable enable

namespace Neon
{
    public partial interface IAiGatewayClient
    {
        /// <summary>
        /// Get branch AI Gateway endpoint<br/>
        /// Returns the AI Gateway endpoint host for the specified branch, used to<br/>
        /// render code-snippet base URLs. A 200 response means the branch is<br/>
        /// registered and this region serves the AI gateway. A 404 response<br/>
        /// includes a `reason` field indicating why the gateway is unavailable.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchAiGateway> GetProjectBranchAiGatewayAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get branch AI Gateway endpoint<br/>
        /// Returns the AI Gateway endpoint host for the specified branch, used to<br/>
        /// render code-snippet base URLs. A 200 response means the branch is<br/>
        /// registered and this region serves the AI gateway. A 404 response<br/>
        /// includes a `reason` field indicating why the gateway is unavailable.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BranchAiGateway>> GetProjectBranchAiGatewayAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}