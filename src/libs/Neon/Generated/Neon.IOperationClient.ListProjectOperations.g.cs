#nullable enable

namespace Neon
{
    public partial interface IOperationClient
    {
        /// <summary>
        /// List operations<br/>
        /// Retrieves a list of operations for the specified Neon project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// The number of operations returned can be large.<br/>
        /// To paginate the response, issue an initial request with a `limit` value.<br/>
        /// Then, add the `cursor` value that was returned in the response to the next request.<br/>
        /// Operations older than 6 months may be deleted from our systems.<br/>
        /// If you need more history than that, you should store your own history.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.OperationsResponse, global::Neon.PaginationResponse>> ListProjectOperationsAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}