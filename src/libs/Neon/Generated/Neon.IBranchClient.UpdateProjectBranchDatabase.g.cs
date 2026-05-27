#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Update database<br/>
        /// Updates the specified database in the branch.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> UpdateProjectBranchDatabaseAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DatabaseUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update database<br/>
        /// Updates the specified database in the branch.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.DatabaseOperations>> UpdateProjectBranchDatabaseAsResponseAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DatabaseUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update database<br/>
        /// Updates the specified database in the branch.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="database"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> UpdateProjectBranchDatabaseAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.DatabaseUpdateRequestDatabase database,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}