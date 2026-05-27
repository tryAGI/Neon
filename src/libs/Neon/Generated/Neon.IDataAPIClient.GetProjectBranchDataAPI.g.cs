#nullable enable

namespace Neon
{
    public partial interface IDataAPIClient
    {
        /// <summary>
        /// Retrieve Neon Data API configuration<br/>
        /// Retrieves the Neon Data API configuration for the specified branch,<br/>
        /// including endpoint URL, enabled state, and database settings.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DataAPIReponse> GetProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Neon Data API configuration<br/>
        /// Retrieves the Neon Data API configuration for the specified branch,<br/>
        /// including endpoint URL, enabled state, and database settings.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.DataAPIReponse>> GetProjectBranchDataAPIAsResponseAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}