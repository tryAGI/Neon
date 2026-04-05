#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Update branch<br/>
        /// Updates the specified branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// For more information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchOperations> UpdateProjectBranchAsync(
            string projectId,
            string branchId,

            global::Neon.BranchUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update branch<br/>
        /// Updates the specified branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// For more information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="branch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchOperations> UpdateProjectBranchAsync(
            string projectId,
            string branchId,
            global::Neon.BranchUpdateRequestBranch branch,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}