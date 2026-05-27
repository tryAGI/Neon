#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Delete project<br/>
        /// Deletes the specified project and all its endpoints, branches, databases, and users.<br/>
        /// Deleted projects can be recovered within 7 days using `POST /projects/{project_id}/recover`.<br/>
        /// To list recoverable projects, use `GET /projects?recoverable=true`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectResponse> DeleteProjectAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete project<br/>
        /// Deletes the specified project and all its endpoints, branches, databases, and users.<br/>
        /// Deleted projects can be recovered within 7 days using `POST /projects/{project_id}/recover`.<br/>
        /// To list recoverable projects, use `GET /projects?recoverable=true`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectResponse>> DeleteProjectAsResponseAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}