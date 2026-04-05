#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// List domains in redirect_uri whitelist<br/>
        /// Lists the domains in the redirect_uri whitelist for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthRedirectURIWhitelistResponse> ListBranchNeonAuthTrustedDomainsAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}