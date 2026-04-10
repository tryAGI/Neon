#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Delete project<br/>
        /// Deletes the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// Deleting a project is a permanent action.<br/>
        /// Deleting a project also deletes endpoints, branches, databases, and users that belong to the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectResponse> DeleteProjectAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}