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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthProviderSDKKeysAsync(

            global::Neon.NeonAuthCreateAuthProviderSDKKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Auth Provider SDK keys<br/>
        /// Generates SDK or API Keys for the auth provider. These might be called different things depending<br/>
        /// on the auth provider you're using, but are generally used for setting up the frontend and backend SDKs.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="authProvider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthProviderSDKKeysAsync(
            string projectId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}