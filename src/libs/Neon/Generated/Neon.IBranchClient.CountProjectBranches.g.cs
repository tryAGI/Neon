#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve number of branches<br/>
        /// Retrieves the total number of branches in the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchesCountResponse> CountProjectBranchesAsync(
            string projectId,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}