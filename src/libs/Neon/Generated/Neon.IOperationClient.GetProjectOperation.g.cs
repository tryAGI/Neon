#nullable enable

namespace Neon
{
    public partial interface IOperationClient
    {
        /// <summary>
        /// Retrieve operation details<br/>
        /// Retrieves details for the specified operation.<br/>
        /// An operation is an action performed on a Neon project resource.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="operationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OperationResponse> GetProjectOperationAsync(
            string projectId,
            string operationId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve operation details<br/>
        /// Retrieves details for the specified operation.<br/>
        /// An operation is an action performed on a Neon project resource.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="operationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.OperationResponse>> GetProjectOperationAsResponseAsync(
            string projectId,
            string operationId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}