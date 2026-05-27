#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Delete branch<br/>
        /// Deletes the specified branch from a project and places all compute endpoints into an idle state, breaking existing client connections.<br/>
        /// The deletion completes after all operations finish.<br/>
        /// You cannot delete a project's root or default branch, or a branch that has a child branch.<br/>
        /// A project must have at least one branch.<br/>
        /// By default, deleted branches can be recovered within a 7-day grace period.<br/>
        /// Use the `hard_delete` parameter to permanently delete the branch immediately.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
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
        /// <summary>
        /// Delete branch<br/>
        /// Deletes the specified branch from a project and places all compute endpoints into an idle state, breaking existing client connections.<br/>
        /// The deletion completes after all operations finish.<br/>
        /// You cannot delete a project's root or default branch, or a branch that has a child branch.<br/>
        /// A project must have at least one branch.<br/>
        /// By default, deleted branches can be recovered within a 7-day grace period.<br/>
        /// Use the `hard_delete` parameter to permanently delete the branch immediately.<br/>
        /// For related information, see [Manage branches](https://neon.com/docs/manage/branches/).
        /// </summary>
        /// <param name="hardDelete">
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.BranchOperations>> DeleteProjectBranchAsResponseAsync(
            string projectId,
            string branchId,
            bool? hardDelete = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}