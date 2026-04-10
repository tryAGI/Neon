#nullable enable

namespace Neon
{
    public partial interface IDataAPIClient
    {
        /// <summary>
        /// Update Neon Data API<br/>
        /// Updates the Neon Data API configuration for the specified branch.<br/>
        /// You can optionally provide settings to update the Data API configuration.<br/>
        /// The schema cache is always refreshed as part of this operation.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> UpdateProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DataAPIUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Neon Data API<br/>
        /// Updates the Neon Data API configuration for the specified branch.<br/>
        /// You can optionally provide settings to update the Data API configuration.<br/>
        /// The schema cache is always refreshed as part of this operation.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="settings">
        /// Configuration settings for the Neon Data API
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> UpdateProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.DataAPISettings? settings = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}