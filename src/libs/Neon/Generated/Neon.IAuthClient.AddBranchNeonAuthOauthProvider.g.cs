#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Add a OAuth provider<br/>
        /// Adds a OAuth provider to the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOauthProvider> AddBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthAddOAuthProviderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a OAuth provider<br/>
        /// Adds a OAuth provider to the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="microsoftTenantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOauthProvider> AddBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,
            global::Neon.NeonAuthOauthProviderId id,
            string? clientId = default,
            string? clientSecret = default,
            string? microsoftTenantId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}