#nullable enable

namespace Neon
{
    public partial interface IEndpointClient
    {
        /// <summary>
        /// List compute endpoints<br/>
        /// Retrieves a list of compute endpoints for the specified project.<br/>
        /// A compute endpoint is a Neon compute instance.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// For information about compute endpoints, see [Manage computes](https://neon.tech/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointsResponse> ListProjectEndpointsAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}