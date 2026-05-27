#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// List databases<br/>
        /// Retrieves a list of databases for the specified branch.<br/>
        /// A branch can have multiple databases.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DatabasesResponse> ListProjectBranchDatabasesAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List databases<br/>
        /// Retrieves a list of databases for the specified branch.<br/>
        /// A branch can have multiple databases.<br/>
        /// For related information, see [Manage databases](https://neon.com/docs/manage/databases/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.DatabasesResponse>> ListProjectBranchDatabasesAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}