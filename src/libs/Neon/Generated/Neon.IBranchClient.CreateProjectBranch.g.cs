#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Create branch<br/>
        /// Creates a branch in the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// This method does not require a request body, but you can specify one to create a compute endpoint for the branch or to select a non-default parent branch.<br/>
        /// By default, the branch is created from the project's default branch with no compute endpoint, and the branch name is auto-generated.<br/>
        /// To access the branch, you must add an endpoint object. A `read_write` endpoint allows you to perform read and write operations on the branch.<br/>
        /// Each branch supports one read-write endpoint and multiple read-only endpoints.<br/>
        /// For related information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>> CreateProjectBranchAsync(
            string projectId,

            global::Neon.AllOf<global::Neon.BranchCreateRequest, global::Neon.AnnotationCreateValueRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create branch<br/>
        /// Creates a branch in the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// This method does not require a request body, but you can specify one to create a compute endpoint for the branch or to select a non-default parent branch.<br/>
        /// By default, the branch is created from the project's default branch with no compute endpoint, and the branch name is auto-generated.<br/>
        /// To access the branch, you must add an endpoint object. A `read_write` endpoint allows you to perform read and write operations on the branch.<br/>
        /// Each branch supports one read-write endpoint and multiple read-only endpoints.<br/>
        /// For related information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.EndpointsResponse, global::Neon.OperationsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.ConnectionURIsOptionalResponse>> CreateProjectBranchAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}