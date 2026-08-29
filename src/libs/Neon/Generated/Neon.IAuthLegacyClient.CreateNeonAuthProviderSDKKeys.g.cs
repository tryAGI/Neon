#nullable enable

namespace Neon
{
    public partial interface IAuthLegacyClient
    {
        /// <summary>
        /// Create Auth Provider SDK keys<br/>
        /// Generates SDK or API Keys for the auth provider. These might be called different things depending<br/>
        /// on the auth provider you're using, but are generally used for setting up the frontend and backend SDKs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthProviderSDKKeysAsync(

            global::Neon.NeonAuthCreateAuthProviderSDKKeysRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Auth Provider SDK keys<br/>
        /// Generates SDK or API Keys for the auth provider. These might be called different things depending<br/>
        /// on the auth provider you're using, but are generally used for setting up the frontend and backend SDKs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthCreateIntegrationResponse>> CreateNeonAuthProviderSDKKeysAsResponseAsync(

            global::Neon.NeonAuthCreateAuthProviderSDKKeysRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Auth Provider SDK keys<br/>
        /// Generates SDK or API Keys for the auth provider. These might be called different things depending<br/>
        /// on the auth provider you're using, but are generally used for setting up the frontend and backend SDKs.
        /// </summary>
        /// <param name="projectId">
        /// The Neon project ID. Returned as `id` from `GET /projects`.<br/>
        /// Example: wispy-forest-12345678
        /// </param>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthProviderSDKKeysAsync(
            string projectId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}