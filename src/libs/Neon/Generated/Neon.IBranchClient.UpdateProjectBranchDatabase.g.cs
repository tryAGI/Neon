#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Update database<br/>
        /// Updates the specified database in the branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` and `database_name` by listing the branch's databases.<br/>
        /// For related information, see [Manage databases](https://neon.tech/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> UpdateProjectBranchDatabaseAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DatabaseUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update database<br/>
        /// Updates the specified database in the branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` and `database_name` by listing the branch's databases.<br/>
        /// For related information, see [Manage databases](https://neon.tech/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="database"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> UpdateProjectBranchDatabaseAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.DatabaseUpdateRequestDatabase database,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}