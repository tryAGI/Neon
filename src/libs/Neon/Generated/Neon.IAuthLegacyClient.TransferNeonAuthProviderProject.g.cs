#nullable enable

namespace Neon
{
    public partial interface IAuthLegacyClient
    {
        /// <summary>
        /// Transfer Neon-managed auth project to your own account<br/>
        /// Transfers ownership of your Neon-managed auth project to your own auth provider account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthTransferAuthProviderProjectResponse> TransferNeonAuthProviderProjectAsync(

            global::Neon.NeonAuthTransferAuthProviderProjectRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Neon-managed auth project to your own account<br/>
        /// Transfers ownership of your Neon-managed auth project to your own auth provider account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthTransferAuthProviderProjectResponse>> TransferNeonAuthProviderProjectAsResponseAsync(

            global::Neon.NeonAuthTransferAuthProviderProjectRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Neon-managed auth project to your own account<br/>
        /// Transfers ownership of your Neon-managed auth project to your own auth provider account.
        /// </summary>
        /// <param name="projectId">
        /// The Neon project ID. Returned as `id` from `GET /projects`.
        /// </param>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthTransferAuthProviderProjectResponse> TransferNeonAuthProviderProjectAsync(
            string projectId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}