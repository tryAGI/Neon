#nullable enable

namespace Neon
{
    public partial interface IDataAPIClient
    {
        /// <summary>
        /// Create Neon Data API<br/>
        /// Creates a new instance of Neon Data API in the specified branch.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DataAPICreateResponse> CreateProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,

            global::Neon.DataAPICreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Neon Data API<br/>
        /// Creates a new instance of Neon Data API in the specified branch.<br/>
        /// You can obtain the `project_id` and `branch_id` by listing the projects and branches for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="authProvider">
        /// The authentication provider to use for the Neon Data API
        /// </param>
        /// <param name="jwksUrl">
        /// The URL that lists the JWKS
        /// </param>
        /// <param name="providerName">
        /// The name of the authentication provider (e.g., Clerk, Stytch, Auth0)
        /// </param>
        /// <param name="jwtAudience">
        /// WARNING - using this setting will only reject tokens with a<br/>
        /// different audience claim. Tokens without audience claim will still<br/>
        /// be accepted.
        /// </param>
        /// <param name="addDefaultGrants">
        /// Grant all permissions to the tables in the public schema to authenticated users<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipAuthSchema">
        /// Skip creating the auth schema and RLS functions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="settings">
        /// Configuration settings for the Neon Data API
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.DataAPICreateResponse> CreateProjectBranchDataAPIAsync(
            string projectId,
            string branchId,
            string databaseName,
            global::Neon.DataAPICreateRequestAuthProvider? authProvider = default,
            string? jwksUrl = default,
            string? providerName = default,
            string? jwtAudience = default,
            bool? addDefaultGrants = default,
            bool? skipAuthSchema = default,
            global::Neon.DataAPISettings? settings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}