#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Delete auth user<br/>
        /// Deletes the auth user for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="authUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteBranchNeonAuthUserAsync(
            string projectId,
            string branchId,
            string authUserId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}