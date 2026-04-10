#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Reset role password<br/>
        /// Resets the password for the specified Postgres role.<br/>
        /// Returns a new password and operations. The new password is ready to use when the last operation finishes.<br/>
        /// The old password remains valid until last operation finishes.<br/>
        /// Connections to the compute endpoint are dropped. If idle,<br/>
        /// the compute endpoint becomes active for a short period of time.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `branch_id` by listing the project's branches.<br/>
        /// You can obtain the `role_name` by listing the roles for a branch.<br/>
        /// For related information, see [Manage roles](https://neon.tech/docs/manage/roles/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="roleName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RoleOperations> ResetProjectBranchRolePasswordAsync(
            string projectId,
            string branchId,
            string roleName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}