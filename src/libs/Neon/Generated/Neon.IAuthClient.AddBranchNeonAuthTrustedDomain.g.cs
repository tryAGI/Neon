#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Add domain to redirect_uri whitelist<br/>
        /// Adds a domain to the redirect URI whitelist for the specified branch.<br/>
        /// Only domains in this list are permitted as redirect targets after authentication.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task AddBranchNeonAuthTrustedDomainAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthAddDomainToRedirectURIWhitelistRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add domain to redirect_uri whitelist<br/>
        /// Adds a domain to the redirect URI whitelist for the specified branch.<br/>
        /// Only domains in this list are permitted as redirect targets after authentication.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> AddBranchNeonAuthTrustedDomainAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthAddDomainToRedirectURIWhitelistRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add domain to redirect_uri whitelist<br/>
        /// Adds a domain to the redirect URI whitelist for the specified branch.<br/>
        /// Only domains in this list are permitted as redirect targets after authentication.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="domain">
        /// URI to add to the redirect URI allowlist for the auth provider.
        /// </param>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddBranchNeonAuthTrustedDomainAsync(
            string projectId,
            string branchId,
            string domain,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}