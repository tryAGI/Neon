#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Retrieve OAuth provider plugin configuration<br/>
        /// Returns the OAuth provider plugin configuration for Neon Auth.<br/>
        /// The OAuth provider plugin lets Neon Auth act as an OAuth 2.1 authorization server for your own clients, such as MCP clients.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthProviderConfig> GetNeonAuthOAuthProviderPluginAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve OAuth provider plugin configuration<br/>
        /// Returns the OAuth provider plugin configuration for Neon Auth.<br/>
        /// The OAuth provider plugin lets Neon Auth act as an OAuth 2.1 authorization server for your own clients, such as MCP clients.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOAuthProviderConfig>> GetNeonAuthOAuthProviderPluginAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}