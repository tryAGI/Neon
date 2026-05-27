#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve role password<br/>
        /// Retrieves the password for the specified Postgres role, if possible.<br/>
        /// For related information, see [Manage roles](https://neon.com/docs/manage/roles/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="roleName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RolePasswordResponse> GetProjectBranchRolePasswordAsync(
            string projectId,
            string branchId,
            string roleName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve role password<br/>
        /// Retrieves the password for the specified Postgres role, if possible.<br/>
        /// For related information, see [Manage roles](https://neon.com/docs/manage/roles/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="roleName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.RolePasswordResponse>> GetProjectBranchRolePasswordAsResponseAsync(
            string projectId,
            string branchId,
            string roleName,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}