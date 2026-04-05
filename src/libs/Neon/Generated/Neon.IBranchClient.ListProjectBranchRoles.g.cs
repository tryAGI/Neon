#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// List roles<br/>
        /// Retrieves a list of Postgres roles from the specified branch.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// For related information, see [Manage roles](https://neon.tech/docs/manage/roles/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RolesResponse> ListProjectBranchRolesAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}