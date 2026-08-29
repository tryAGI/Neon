#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Set an org member's role on a project<br/>
        /// Idempotently sets or updates the explicit project grant of the specified org member.<br/>
        /// Self-demotion requires `confirm_self_demotion=true`.
        /// </summary>
        /// <param name="confirmSelfDemotion"></param>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectMemberRoleResponse> SetProjectMemberRoleAsync(
            string projectId,
            string memberId,

            global::Neon.SetProjectMemberRoleRequest request,
            bool? confirmSelfDemotion = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an org member's role on a project<br/>
        /// Idempotently sets or updates the explicit project grant of the specified org member.<br/>
        /// Self-demotion requires `confirm_self_demotion=true`.
        /// </summary>
        /// <param name="confirmSelfDemotion"></param>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectMemberRoleResponse>> SetProjectMemberRoleAsResponseAsync(
            string projectId,
            string memberId,

            global::Neon.SetProjectMemberRoleRequest request,
            bool? confirmSelfDemotion = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an org member's role on a project<br/>
        /// Idempotently sets or updates the explicit project grant of the specified org member.<br/>
        /// Self-demotion requires `confirm_self_demotion=true`.
        /// </summary>
        /// <param name="confirmSelfDemotion"></param>
        /// <param name="projectId"></param>
        /// <param name="memberId"></param>
        /// <param name="role">
        /// Per-project role. `viewer` maps to `VIEWER`, `editor` maps to `EDITOR`,<br/>
        /// and `admin` maps to `ADMIN`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectMemberRoleResponse> SetProjectMemberRoleAsync(
            string projectId,
            string memberId,
            global::Neon.ProjectRole role,
            bool? confirmSelfDemotion = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}