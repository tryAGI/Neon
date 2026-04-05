#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Enable Neon Auth for the branch<br/>
        /// Enables Neon Auth integrationfor the branch.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthAsync(
            string projectId,
            string branchId,

            global::Neon.EnableNeonAuthIntegrationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable Neon Auth for the branch<br/>
        /// Enables Neon Auth integrationfor the branch.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="authProvider"></param>
        /// <param name="databaseName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateIntegrationResponse> CreateNeonAuthAsync(
            string projectId,
            string branchId,
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string? databaseName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}