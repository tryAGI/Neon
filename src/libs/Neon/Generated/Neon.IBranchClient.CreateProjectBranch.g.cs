#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Create branch<br/>
        /// Creates a branch in the specified project.<br/>
        /// No request body is required, but you can specify one to create a compute endpoint or select a non-default parent branch.<br/>
        /// By default, the branch is created from the project's default branch with no compute endpoint, and the branch name is auto-generated.<br/>
        /// To access the branch, add a `read_write` endpoint.<br/>
        /// Each branch supports one read-write endpoint and multiple read-only endpoints.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>> CreateProjectBranchAsync(
            string projectId,

            global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest> request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create branch<br/>
        /// Creates a branch in the specified project.<br/>
        /// No request body is required, but you can specify one to create a compute endpoint or select a non-default parent branch.<br/>
        /// By default, the branch is created from the project's default branch with no compute endpoint, and the branch name is auto-generated.<br/>
        /// To access the branch, add a `read_write` endpoint.<br/>
        /// Each branch supports one read-write endpoint and multiple read-only endpoints.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>>> CreateProjectBranchAsResponseAsync(
            string projectId,

            global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest> request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create branch<br/>
        /// Creates a branch in the specified project.<br/>
        /// No request body is required, but you can specify one to create a compute endpoint or select a non-default parent branch.<br/>
        /// By default, the branch is created from the project's default branch with no compute endpoint, and the branch name is auto-generated.<br/>
        /// To access the branch, add a `read_write` endpoint.<br/>
        /// Each branch supports one read-write endpoint and multiple read-only endpoints.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>> CreateProjectBranchAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}