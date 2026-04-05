#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// List OAuth providers for neon auth for a branch<br/>
        /// Lists the OAuth providers for the specified project and branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ListNeonAuthOauthProvidersResponse> ListBranchNeonAuthOauthProvidersAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}