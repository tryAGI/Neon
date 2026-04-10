#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Retrieve connection URI<br/>
        /// Retrieves a connection URI for the specified database.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain the `database_name` by listing the databases for a branch.<br/>
        /// You can obtain a `role_name` by listing the roles for a branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="endpointId"></param>
        /// <param name="databaseName"></param>
        /// <param name="roleName"></param>
        /// <param name="pooled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ConnectionURIResponse> GetConnectionURIAsync(
            string projectId,
            string databaseName,
            string roleName,
            string? branchId = default,
            string? endpointId = default,
            bool? pooled = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}