#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Update project<br/>
        /// Updates the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>> UpdateProjectAsync(
            string projectId,

            global::Neon.ProjectUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project<br/>
        /// Updates the specified project.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ProjectResponse, global::Neon.OperationsResponse>> UpdateProjectAsync(
            string projectId,
            global::Neon.ProjectUpdateRequestProject project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}