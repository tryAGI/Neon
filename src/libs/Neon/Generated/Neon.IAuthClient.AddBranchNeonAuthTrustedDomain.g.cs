#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Add domain to redirect_uri whitelist<br/>
        /// Adds a domain to the redirect_uri whitelist for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task AddBranchNeonAuthTrustedDomainAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthAddDomainToRedirectURIWhitelistRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add domain to redirect_uri whitelist<br/>
        /// Adds a domain to the redirect_uri whitelist for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="domain"></param>
        /// <param name="authProvider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddBranchNeonAuthTrustedDomainAsync(
            string projectId,
            string branchId,
            string domain,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}