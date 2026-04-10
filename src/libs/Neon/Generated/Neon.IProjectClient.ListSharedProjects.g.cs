#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List shared projects<br/>
        /// Retrieves a list of projects shared with your Neon account.<br/>
        /// For more information, see [Manage projects](https://neon.tech/docs/manage/projects/).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="timeout"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectsResponse, global::Neon.PaginationResponse>> ListSharedProjectsAsync(
            string? cursor = default,
            int? limit = default,
            string? search = default,
            int? timeout = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}