#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// List branches<br/>
        /// Retrieves a list of branches for the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// Each Neon project has a root branch named `main`.<br/>
        /// A `branch_id` value has a `br-` prefix.<br/>
        /// A project may contain child branches that were branched from `main` or from another branch.<br/>
        /// A parent branch is identified by the `parent_id` value, which is the `id` of the parent branch.<br/>
        /// For related information, see [Manage branches](https://neon.tech/docs/manage/branches/).
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy">
        /// Default Value: updated_at
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="limit"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.BranchesResponse, global::Neon.AnnotationsMapResponse, global::Neon.CursorPaginationResponse>> ListProjectBranchesAsync(
            string projectId,
            string? search = default,
            global::Neon.ListProjectBranchesSortBy? sortBy = default,
            string? cursor = default,
            global::Neon.ListProjectBranchesSortOrder? sortOrder = default,
            int? limit = default,
            bool? includeDeleted = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}