#nullable enable

namespace Neon
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// List branch log fields<br/>
        /// Lists the low-cardinality log fields observed on this branch whose<br/>
        /// distinct values can be discovered with the log field-values endpoint.<br/>
        /// The set is computed per branch and grows as new fields are observed, so<br/>
        /// treat it as data rather than a fixed list: discover a field here, then<br/>
        /// pass it as `field_name` to the field-values endpoint.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogFieldsResponse> ListProjectBranchLogFieldsAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List branch log fields<br/>
        /// Lists the low-cardinality log fields observed on this branch whose<br/>
        /// distinct values can be discovered with the log field-values endpoint.<br/>
        /// The set is computed per branch and grows as new fields are observed, so<br/>
        /// treat it as data rather than a fixed list: discover a field here, then<br/>
        /// pass it as `field_name` to the field-values endpoint.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogFieldsResponse>> ListProjectBranchLogFieldsAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}