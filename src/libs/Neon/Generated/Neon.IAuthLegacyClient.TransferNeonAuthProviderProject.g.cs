#nullable enable

namespace Neon
{
    public partial interface IAuthLegacyClient
    {
        /// <summary>
        /// Transfer Neon-managed auth project to your own account<br/>
        /// Transfer ownership of your Neon-managed auth project to your own auth provider account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthTransferAuthProviderProjectResponse> TransferNeonAuthProviderProjectAsync(

            global::Neon.NeonAuthTransferAuthProviderProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Neon-managed auth project to your own account<br/>
        /// Transfer ownership of your Neon-managed auth project to your own auth provider account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="authProvider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthTransferAuthProviderProjectResponse> TransferNeonAuthProviderProjectAsync(
            string projectId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}