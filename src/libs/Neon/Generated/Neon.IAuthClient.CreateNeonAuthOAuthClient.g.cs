#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create an OAuth client<br/>
        /// Registers an OAuth client with the branch's Neon Auth OAuth provider.<br/>
        /// For `confidential` clients the response includes the `client_secret`, which is shown only once.<br/>
        /// Every entry in `resources` must be configured on the OAuth provider plugin.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthClientCreated> CreateNeonAuthOAuthClientAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOAuthClientCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an OAuth client<br/>
        /// Registers an OAuth client with the branch's Neon Auth OAuth provider.<br/>
        /// For `confidential` clients the response includes the `client_secret`, which is shown only once.<br/>
        /// Every entry in `resources` must be configured on the OAuth provider plugin.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOAuthClientCreated>> CreateNeonAuthOAuthClientAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthOAuthClientCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an OAuth client<br/>
        /// Registers an OAuth client with the branch's Neon Auth OAuth provider.<br/>
        /// For `confidential` clients the response includes the `client_secret`, which is shown only once.<br/>
        /// Every entry in `resources` must be configured on the OAuth provider plugin.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="name">
        /// Display name of the client.
        /// </param>
        /// <param name="redirectUris">
        /// Redirect URIs the client may use. Must be https, or http on loopback hosts when localhost is allowed.
        /// </param>
        /// <param name="type">
        /// Confidential clients authenticate with a client secret. Public clients have no secret.
        /// </param>
        /// <param name="resources">
        /// Identifiers of the protected resources to link the client to. Each must be configured on the OAuth provider plugin.
        /// </param>
        /// <param name="skipConsent">
        /// Whether to skip the consent prompt for this client.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthClientCreated> CreateNeonAuthOAuthClientAsync(
            string projectId,
            string branchId,
            string name,
            global::System.Collections.Generic.IList<string> redirectUris,
            global::Neon.NeonAuthOAuthClientType type,
            global::System.Collections.Generic.IList<string> resources,
            bool? skipConsent = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}