#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Delete database<br/>
        /// Deletes the specified database from the branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` and `database_name` by listing the branch's databases.<br/>
        /// For related information, see [Manage databases](https://neon.tech/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> DeleteProjectBranchDatabaseAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}