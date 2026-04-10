#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Delete domain from redirect_uri whitelist<br/>
        /// Deletes a domain from the redirect_uri whitelist for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteBranchNeonAuthTrustedDomainAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete domain from redirect_uri whitelist<br/>
        /// Deletes a domain from the redirect_uri whitelist for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="authProvider"></param>
        /// <param name="domains"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteBranchNeonAuthTrustedDomainAsync(
            string projectId,
            string branchId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem> domains,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}