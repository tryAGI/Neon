#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List projects<br/>
        /// Retrieves a list of projects for an organization.<br/>
        /// You may need to specify an org_id parameter depending on your API key type.<br/>
        /// For more information, see [Manage projects](https://neon.tech/docs/manage/projects/).
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse, global::Neon.ProjectsApplicationsMapResponse, global::Neon.ProjectsIntegrationsMapResponse>> ListProjectsAsync(
            string? cursor = default,
            int? limit = default,
            string? search = default,
            string? orgId = default,
            int? timeout = default,
            bool? recoverable = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}