#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Create project<br/>
        /// Creates a Neon project within an organization.<br/>
        /// If using a personal API key, include the `org_id` parameter to specify which organization to create the project in.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.<br/>
        /// Plan limits define how many projects you can create.<br/>
        /// For more information, see [Manage projects](https://neon.com/docs/manage/projects/).<br/>
        /// You can specify a region and Postgres version in the request body.<br/>
        /// Neon currently supports PostgreSQL 14, 15, 16, 17, and 18.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.com/docs/introduction/regions/).
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
        /// If using a personal API key, include the `org_id` parameter to specify which organization to create the project in.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.<br/>
        /// Plan limits define how many projects you can create.<br/>
        /// For more information, see [Manage projects](https://neon.com/docs/manage/projects/).<br/>
        /// You can specify a region and Postgres version in the request body.<br/>
        /// Neon currently supports PostgreSQL 14, 15, 16, 17, and 18.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.com/docs/introduction/regions/).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.ConnectionURIsResponse, global::Neon.RolesResponse, global::Neon.DatabasesResponse, global::Neon.OperationsResponse, global::Neon.BranchResponse, global::Neon.EndpointsResponse>>> CreateProjectAsResponseAsync(

            global::Neon.ProjectCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Creates a Neon project within an organization.<br/>
        /// If using a personal API key, include the `org_id` parameter to specify which organization to create the project in.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.<br/>
        /// Plan limits define how many projects you can create.<br/>
        /// For more information, see [Manage projects](https://neon.com/docs/manage/projects/).<br/>
        /// You can specify a region and Postgres version in the request body.<br/>
        /// Neon currently supports PostgreSQL 14, 15, 16, 17, and 18.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.com/docs/introduction/regions/).
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