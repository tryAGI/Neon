#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Create database<br/>
        /// Creates a database in the specified branch.<br/>
        /// A branch can have multiple databases.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> CreateProjectBranchDatabaseAsync(
            string projectId,
            string branchId,

            global::Neon.DatabaseCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create database<br/>
        /// Creates a database in the specified branch.<br/>
        /// A branch can have multiple databases.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.DatabaseOperations>> CreateProjectBranchDatabaseAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.DatabaseCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create database<br/>
        /// Creates a database in the specified branch.<br/>
        /// A branch can have multiple databases.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="database"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabaseOperations> CreateProjectBranchDatabaseAsync(
            string projectId,
            string branchId,
            global::Neon.DatabaseCreateRequestDatabase database,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}