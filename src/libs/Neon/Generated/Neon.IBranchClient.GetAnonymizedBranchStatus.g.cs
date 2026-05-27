#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve anonymized branch status<br/>
        /// Retrieves the current status of an anonymized branch, including its state and progress information.<br/>
        /// This endpoint allows you to monitor the anonymization process from initialization through completion.<br/>
        /// Only anonymized branches will have status information available.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AnonymizedBranchStatusResponse> GetAnonymizedBranchStatusAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve anonymized branch status<br/>
        /// Retrieves the current status of an anonymized branch, including its state and progress information.<br/>
        /// This endpoint allows you to monitor the anonymization process from initialization through completion.<br/>
        /// Only anonymized branches will have status information available.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AnonymizedBranchStatusResponse>> GetAnonymizedBranchStatusAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}