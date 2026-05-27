#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Add an OAuth provider<br/>
        /// Adds an OAuth provider configuration to the specified branch's Neon Auth integration.<br/>
        /// After adding, users can authenticate using the configured provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOauthProvider> AddBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthAddOAuthProviderRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add an OAuth provider<br/>
        /// Adds an OAuth provider configuration to the specified branch's Neon Auth integration.<br/>
        /// After adding, users can authenticate using the configured provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOauthProvider>> AddBranchNeonAuthOauthProviderAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthAddOAuthProviderRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add an OAuth provider<br/>
        /// Adds an OAuth provider configuration to the specified branch's Neon Auth integration.<br/>
        /// After adding, users can authenticate using the configured provider.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="microsoftTenantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOauthProvider> AddBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,
            global::Neon.NeonAuthOauthProviderId id,
            string? clientId = default,
            string? clientSecret = default,
            string? microsoftTenantId = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}