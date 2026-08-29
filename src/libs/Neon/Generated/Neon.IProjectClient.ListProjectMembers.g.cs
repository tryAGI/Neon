#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List org members and their project roles<br/>
        /// Lists organization members and their per-project roles for an org-owned project.<br/>
        /// Returns 404 when the project is not org-owned, per-project role management is disabled,<br/>
        /// or the caller has no access. Callers with VIEWER or EDITOR see members with<br/>
        /// effective project access. Callers with ADMIN also see unassigned org members.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectMembers> ListProjectMembersAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List org members and their project roles<br/>
        /// Lists organization members and their per-project roles for an org-owned project.<br/>
        /// Returns 404 when the project is not org-owned, per-project role management is disabled,<br/>
        /// or the caller has no access. Callers with VIEWER or EDITOR see members with<br/>
        /// effective project access. Callers with ADMIN also see unassigned org members.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectMembers>> ListProjectMembersAsResponseAsync(
            string projectId,
            string? cursor = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}