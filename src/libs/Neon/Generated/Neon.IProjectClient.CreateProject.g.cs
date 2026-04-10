#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Create project<br/>
        /// Creates a Neon project within an organization.<br/>
        /// You may need to specify an org_id parameter depending on your API key type.<br/>
        /// Plan limits define how many projects you can create.<br/>
        /// For more information, see [Manage projects](https://neon.tech/docs/manage/projects/).<br/>
        /// You can specify a region and Postgres version in the request body.<br/>
        /// Neon currently supports PostgreSQL 14, 15, 16, and 17.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.tech/docs/introduction/regions/).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>> CreateProjectAsync(

            global::Neon.ProjectCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Creates a Neon project within an organization.<br/>
        /// You may need to specify an org_id parameter depending on your API key type.<br/>
        /// Plan limits define how many projects you can create.<br/>
        /// For more information, see [Manage projects](https://neon.tech/docs/manage/projects/).<br/>
        /// You can specify a region and Postgres version in the request body.<br/>
        /// Neon currently supports PostgreSQL 14, 15, 16, and 17.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.tech/docs/introduction/regions/).
        /// </summary>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>> CreateProjectAsync(
            global::Neon.ProjectCreateRequestProject project,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}