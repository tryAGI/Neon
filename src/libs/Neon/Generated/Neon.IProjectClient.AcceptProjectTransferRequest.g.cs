#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Accept a project transfer request<br/>
        /// Accepts a transfer request for the specified project, transferring it to the specified organization<br/>
        /// or user. If org_id is not passed, the project will be transferred to the current user or organization account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task AcceptProjectTransferRequestAsync(
            string projectId,
            string requestId,

            global::Neon.AcceptProjectTransferRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Accept a project transfer request<br/>
        /// Accepts a transfer request for the specified project, transferring it to the specified organization<br/>
        /// or user. If org_id is not passed, the project will be transferred to the current user or organization account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestId"></param>
        /// <param name="orgId">
        /// The Neon organization ID to transfer the project to. If not provided, the project will be<br/>
        /// transferred to the current user or organization account.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AcceptProjectTransferRequestAsync(
            string projectId,
            string requestId,
            string? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}