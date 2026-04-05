#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update OAuth provider<br/>
        /// Updates a OAuth provider for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOauthProvider> UpdateBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,
            string oauthProviderId,

            global::Neon.NeonAuthUpdateOAuthProviderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update OAuth provider<br/>
        /// Updates a OAuth provider for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="microsoftTenantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOauthProvider> UpdateBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,
            string oauthProviderId,
            string? clientId = default,
            string? clientSecret = default,
            string? microsoftTenantId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}