#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Create a project transfer request<br/>
        /// Creates a transfer request for the specified project. A transfer request allows<br/>
        /// the project to be transferred to another account or organization. The request<br/>
        /// has an expiration time after which it can no longer be used. To accept/claim<br/>
        /// the transfer request, the recipient user/organization must call the<br/>
        /// `/projects/{project_id}/transfer_requests/{request_id}` API endpoint, or visit<br/>
        /// `https://console.neon.tech/app/claim?p={project_id}&amp;tr={request_id}&amp;ru={redirect_url}`<br/>
        /// in the Neon Console. The `ru` parameter is optional and can be used to redirect<br/>
        /// the user after accepting the transfer request.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectTransferRequestResponse> CreateProjectTransferRequestAsync(
            string projectId,

            global::Neon.CreateProjectTransferRequestRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project transfer request<br/>
        /// Creates a transfer request for the specified project. A transfer request allows<br/>
        /// the project to be transferred to another account or organization. The request<br/>
        /// has an expiration time after which it can no longer be used. To accept/claim<br/>
        /// the transfer request, the recipient user/organization must call the<br/>
        /// `/projects/{project_id}/transfer_requests/{request_id}` API endpoint, or visit<br/>
        /// `https://console.neon.tech/app/claim?p={project_id}&amp;tr={request_id}&amp;ru={redirect_url}`<br/>
        /// in the Neon Console. The `ru` parameter is optional and can be used to redirect<br/>
        /// the user after accepting the transfer request.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ttlSeconds">
        /// Specifies the validity duration of the transfer request in seconds. If not provided,<br/>
        /// the request will expire after 24 hours (86,400 seconds).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectTransferRequestResponse> CreateProjectTransferRequestAsync(
            string projectId,
            long? ttlSeconds = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}