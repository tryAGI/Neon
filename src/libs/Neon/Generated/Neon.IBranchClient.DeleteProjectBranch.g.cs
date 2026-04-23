#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Delete branch<br/>
        /// Deletes the specified branch from a project, and places<br/>
        /// all compute endpoints into an idle state, breaking existing client connections.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain a `branch_id` by listing the project's branches.<br/>
        /// For related information, see [Manage branches](https://neon.tech/docs/manage/branches/).<br/>
        /// When a successful response status is received, the compute endpoints are still active,<br/>
        /// and the branch is not yet deleted from storage.<br/>
        /// The deletion occurs after all operations finish.<br/>
        /// You cannot delete a project's root or default branch, and you cannot delete a branch that has a child branch.<br/>
        /// A project must have at least one branch.<br/>
        /// By default, deleted branches can be recovered within a 7-day grace period.<br/>
        /// Use the `hard_delete` parameter to permanently delete the branch immediately without a recovery window.<br/>
        /// Soft delete and branch recovery are in preview and not available to all users.
        /// </summary>
        /// <param name="hardDelete">
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchOperations> DeleteProjectBranchAsync(
            string projectId,
            string branchId,
            bool? hardDelete = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}