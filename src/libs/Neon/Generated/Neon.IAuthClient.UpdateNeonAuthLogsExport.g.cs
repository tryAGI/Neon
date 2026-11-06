#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update Neon Auth logs export setting<br/>
        /// Enables or disables exporting Neon Auth events for the branch to Neon Platform logs.<br/>
        /// Only supported for Neon Auth (`better_auth`) integrations.<br/>
        /// When logs export is not available for the project, only disabling is accepted.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthLogsExportConfig> UpdateNeonAuthLogsExportAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthLogsExportConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Neon Auth logs export setting<br/>
        /// Enables or disables exporting Neon Auth events for the branch to Neon Platform logs.<br/>
        /// Only supported for Neon Auth (`better_auth`) integrations.<br/>
        /// When logs export is not available for the project, only disabling is accepted.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthLogsExportConfig>> UpdateNeonAuthLogsExportAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthLogsExportConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Neon Auth logs export setting<br/>
        /// Enables or disables exporting Neon Auth events for the branch to Neon Platform logs.<br/>
        /// Only supported for Neon Auth (`better_auth`) integrations.<br/>
        /// When logs export is not available for the project, only disabling is accepted.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Whether Neon Auth events are exported to Neon Platform logs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthLogsExportConfig> UpdateNeonAuthLogsExportAsync(
            string projectId,
            string branchId,
            bool enabled,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}