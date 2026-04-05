#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve role details<br/>
        /// Retrieves details about the specified role.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// You can obtain the `role_name` by listing the roles for a branch.<br/>
        /// In Neon, the terms "role" and "user" are synonymous.<br/>
        /// For related information, see [Manage roles](https://neon.tech/docs/manage/roles/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="roleName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RoleResponse> GetProjectBranchRoleAsync(
            string projectId,
            string branchId,
            string roleName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}