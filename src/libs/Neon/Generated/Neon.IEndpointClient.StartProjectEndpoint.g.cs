#nullable enable

namespace Neon
{
    public partial interface IEndpointClient
    {
        /// <summary>
        /// Start compute endpoint<br/>
        /// Starts a compute endpoint. The compute endpoint is ready to use<br/>
        /// after the last operation in chain finishes successfully.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain an `endpoint_id` by listing your project's compute endpoints.<br/>
        /// An `endpoint_id` has an `ep-` prefix.<br/>
        /// For information about compute endpoints, see [Manage computes](https://neon.tech/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="endpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> StartProjectEndpointAsync(
            string projectId,
            string endpointId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}