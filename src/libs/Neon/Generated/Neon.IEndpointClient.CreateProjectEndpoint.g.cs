#nullable enable

namespace Neon
{
    public partial interface IEndpointClient
    {
        /// <summary>
        /// Create compute endpoint<br/>
        /// Creates a compute endpoint for the specified branch.<br/>
        /// A compute endpoint is a Neon compute instance.<br/>
        /// There is a maximum of one read-write compute endpoint per branch.<br/>
        /// If the specified branch already has a read-write compute endpoint, the operation fails.<br/>
        /// A branch can have multiple read-only compute endpoints.<br/>
        /// For more information about compute endpoints, see [Manage computes](https://neon.com/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> CreateProjectEndpointAsync(
            string projectId,

            global::Neon.EndpointCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create compute endpoint<br/>
        /// Creates a compute endpoint for the specified branch.<br/>
        /// A compute endpoint is a Neon compute instance.<br/>
        /// There is a maximum of one read-write compute endpoint per branch.<br/>
        /// If the specified branch already has a read-write compute endpoint, the operation fails.<br/>
        /// A branch can have multiple read-only compute endpoints.<br/>
        /// For more information about compute endpoints, see [Manage computes](https://neon.com/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.EndpointOperations>> CreateProjectEndpointAsResponseAsync(
            string projectId,

            global::Neon.EndpointCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create compute endpoint<br/>
        /// Creates a compute endpoint for the specified branch.<br/>
        /// A compute endpoint is a Neon compute instance.<br/>
        /// There is a maximum of one read-write compute endpoint per branch.<br/>
        /// If the specified branch already has a read-write compute endpoint, the operation fails.<br/>
        /// A branch can have multiple read-only compute endpoints.<br/>
        /// For more information about compute endpoints, see [Manage computes](https://neon.com/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> CreateProjectEndpointAsync(
            string projectId,
            global::Neon.EndpointCreateRequestEndpoint endpoint,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}