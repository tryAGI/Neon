#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Create a project transfer request<br/>
        /// Creates a transfer request for the specified project. The request expires after a set period.<br/>
        /// To accept the request, the recipient calls `PUT /projects/{project_id}/transfer_requests/{request_id}`<br/>
        /// or uses the Neon Console claim link.<br/>
        /// The optional `ru` parameter redirects the recipient after acceptance.
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
        /// Creates a transfer request for the specified project. The request expires after a set period.<br/>
        /// To accept the request, the recipient calls `PUT /projects/{project_id}/transfer_requests/{request_id}`<br/>
        /// or uses the Neon Console claim link.<br/>
        /// The optional `ru` parameter redirects the recipient after acceptance.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectTransferRequestResponse>> CreateProjectTransferRequestAsResponseAsync(
            string projectId,

            global::Neon.CreateProjectTransferRequestRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project transfer request<br/>
        /// Creates a transfer request for the specified project. The request expires after a set period.<br/>
        /// To accept the request, the recipient calls `PUT /projects/{project_id}/transfer_requests/{request_id}`<br/>
        /// or uses the Neon Console claim link.<br/>
        /// The optional `ru` parameter redirects the recipient after acceptance.
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