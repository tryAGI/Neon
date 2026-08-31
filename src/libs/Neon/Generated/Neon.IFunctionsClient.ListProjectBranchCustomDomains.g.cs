#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// List the custom domains on a branch<br/>
        /// Lists all custom domains registered on the branch, across every target<br/>
        /// entity.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>> ListProjectBranchCustomDomainsAsync(
            string projectId,
            string branchId,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the custom domains on a branch<br/>
        /// Lists all custom domains registered on the branch, across every target<br/>
        /// entity.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.CustomDomainsListResponse, global::Neon.CursorPaginationResponse>>> ListProjectBranchCustomDomainsAsResponseAsync(
            string projectId,
            string branchId,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}