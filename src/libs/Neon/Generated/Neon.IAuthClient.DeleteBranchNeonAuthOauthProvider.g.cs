#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Delete OAuth provider<br/>
        /// Deletes a OAuth provider from the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteBranchNeonAuthOauthProviderAsync(
            string projectId,
            string branchId,
            string oauthProviderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}