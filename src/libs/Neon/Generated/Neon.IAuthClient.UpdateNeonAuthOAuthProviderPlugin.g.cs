#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update OAuth provider plugin configuration<br/>
        /// Updates the OAuth provider plugin configuration for Neon Auth.<br/>
        /// Only the fields provided in the request body are updated; omitted fields retain their current values.<br/>
        /// A provided `resources` list replaces the stored list.<br/>
        /// A provided `mcp` object replaces the stored MCP configuration and must include `resource`.<br/>
        /// The plugin can only be enabled on the project's root branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthProviderConfig> UpdateNeonAuthOAuthProviderPluginAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOAuthProviderConfigUpdate request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update OAuth provider plugin configuration<br/>
        /// Updates the OAuth provider plugin configuration for Neon Auth.<br/>
        /// Only the fields provided in the request body are updated; omitted fields retain their current values.<br/>
        /// A provided `resources` list replaces the stored list.<br/>
        /// A provided `mcp` object replaces the stored MCP configuration and must include `resource`.<br/>
        /// The plugin can only be enabled on the project's root branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOAuthProviderConfig>> UpdateNeonAuthOAuthProviderPluginAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOAuthProviderConfigUpdate request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update OAuth provider plugin configuration<br/>
        /// Updates the OAuth provider plugin configuration for Neon Auth.<br/>
        /// Only the fields provided in the request body are updated; omitted fields retain their current values.<br/>
        /// A provided `resources` list replaces the stored list.<br/>
        /// A provided `mcp` object replaces the stored MCP configuration and must include `resource`.<br/>
        /// The plugin can only be enabled on the project's root branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Whether the OAuth provider plugin is enabled.
        /// </param>
        /// <param name="loginPage">
        /// URL of the page that authorization requests redirect to for sign-in.
        /// </param>
        /// <param name="consentPage">
        /// URL of the page that authorization requests redirect to for consent.
        /// </param>
        /// <param name="mcp"></param>
        /// <param name="resources">
        /// Protected resources that clients can be linked to. When provided, replaces the stored list.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthProviderConfig> UpdateNeonAuthOAuthProviderPluginAsync(
            string projectId,
            string branchId,
            bool? enabled = default,
            string? loginPage = default,
            string? consentPage = default,
            global::Neon.NeonAuthOAuthProviderMcpUpdate? mcp = default,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthOAuthProviderResource>? resources = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}