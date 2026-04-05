#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Retrieve project details<br/>
        /// Retrieves information about the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for an organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectResponse> GetProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}