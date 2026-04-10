#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// List branch endpoints<br/>
        /// Retrieves a list of compute endpoints for the specified branch.<br/>
        /// Neon permits only one read-write compute endpoint per branch.<br/>
        /// A branch can have multiple read-only compute endpoints.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointsResponse> ListProjectBranchEndpointsAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}