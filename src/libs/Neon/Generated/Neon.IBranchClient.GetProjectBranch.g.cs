#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve branch details<br/>
        /// Retrieves information about the specified branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain a `branch_id` by listing the project's branches.<br/>
        /// A `branch_id` value has a `br-` prefix.<br/>
        /// Each Neon project is initially created with a root and default branch named `main`.<br/>
        /// A project can contain one or more branches.<br/>
        /// A parent branch is identified by a `parent_id` value, which is the `id` of the parent branch.<br/>
        /// For related information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchResponse, global::Neon.AnnotationResponse>> GetProjectBranchAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}