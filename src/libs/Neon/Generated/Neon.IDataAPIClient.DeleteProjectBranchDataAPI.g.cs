#nullable enable

namespace Neon
{
    public partial interface IDataAPIClient
    {
        /// <summary>
        /// Delete Neon Data API<br/>
        /// Deletes the Neon Data API for the specified branch.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> DeleteProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}