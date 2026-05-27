#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve branch details<br/>
        /// Retrieves information about the specified branch.<br/>
        /// A `branch_id` value has a `br-` prefix.<br/>
        /// Each Neon project is initially created with a root and default branch named `main`.<br/>
        /// A project can contain one or more branches.<br/>
        /// A parent branch is identified by a `parent_id` value, which is the `id` of the parent branch.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>> GetProjectBranchAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve branch details<br/>
        /// Retrieves information about the specified branch.<br/>
        /// A `branch_id` value has a `br-` prefix.<br/>
        /// Each Neon project is initially created with a root and default branch named `main`.<br/>
        /// A project can contain one or more branches.<br/>
        /// A parent branch is identified by a `parent_id` value, which is the `id` of the parent branch.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>>> GetProjectBranchAsResponseAsync(
            string projectId,
            string branchId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}