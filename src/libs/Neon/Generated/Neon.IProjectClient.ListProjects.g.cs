#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List projects<br/>
        /// Retrieves a list of projects for the specified organization.<br/>
        /// If using a personal API key, include the `org_id` parameter to specify which organization to work with.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.<br/>
        /// For more information, see [Manage organizations using the Neon API](https://neon.com/docs/manage/orgs-api)<br/>
        /// and [Manage projects](https://neon.com/docs/manage/projects/).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="orgId"></param>
        /// <param name="timeout"></param>
        /// <param name="recoverable">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>> ListProjectsAsync(
            string? cursor = default,
            int? limit = default,
            string? search = default,
            string? orgId = default,
            int? timeout = default,
            bool? recoverable = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List projects<br/>
        /// Retrieves a list of projects for the specified organization.<br/>
        /// If using a personal API key, include the `org_id` parameter to specify which organization to work with.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.<br/>
        /// For more information, see [Manage organizations using the Neon API](https://neon.com/docs/manage/orgs-api)<br/>
        /// and [Manage projects](https://neon.com/docs/manage/projects/).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="orgId"></param>
        /// <param name="timeout"></param>
        /// <param name="recoverable">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>>> ListProjectsAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? search = default,
            string? orgId = default,
            int? timeout = default,
            bool? recoverable = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}