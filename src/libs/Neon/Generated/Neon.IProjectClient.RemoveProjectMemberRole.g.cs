#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Remove an org member's role on a project<br/>
        /// Idempotently removes the explicit project grant. The member's organization-role<br/>
        /// default project permission still applies. Self-DELETE requires<br/>
        /// `confirm_self_lockout=true` when effective manage access would be lost.
        /// </summary>
        /// <param name="confirmSelfLockout"></param>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectMemberRoleResponse> RemoveProjectMemberRoleAsync(
            string projectId,
            string memberId,
            bool? confirmSelfLockout = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an org member's role on a project<br/>
        /// Idempotently removes the explicit project grant. The member's organization-role<br/>
        /// default project permission still applies. Self-DELETE requires<br/>
        /// `confirm_self_lockout=true` when effective manage access would be lost.
        /// </summary>
        /// <param name="confirmSelfLockout"></param>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectMemberRoleResponse>> RemoveProjectMemberRoleAsResponseAsync(
            string projectId,
            string memberId,
            bool? confirmSelfLockout = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}