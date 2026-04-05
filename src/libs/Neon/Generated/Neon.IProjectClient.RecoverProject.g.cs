#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Recover a deleted project<br/>
        /// Recovers a deleted project during the deletion grace period.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectRecoverResponse> RecoverProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}