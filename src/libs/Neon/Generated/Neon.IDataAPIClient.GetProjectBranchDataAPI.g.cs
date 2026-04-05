#nullable enable

namespace Neon
{
    public partial interface IDataAPIClient
    {
        /// <summary>
        /// Get Neon Data API<br/>
        /// Retrieves the Neon Data API for the specified branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DataAPIReponse> GetProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}