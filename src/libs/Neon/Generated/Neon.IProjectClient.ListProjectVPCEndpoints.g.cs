#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List VPC endpoint restrictions<br/>
        /// Lists VPC endpoint restrictions for the specified Neon project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.VPCEndpointsResponse> ListProjectVPCEndpointsAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}