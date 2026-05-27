#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Retrieve project details<br/>
        /// Retrieves information about the specified project.<br/>
        /// Returned details include the project settings, compute configuration, history retention, owner information, and current usage metrics.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectResponse> GetProjectAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve project details<br/>
        /// Retrieves information about the specified project.<br/>
        /// Returned details include the project settings, compute configuration, history retention, owner information, and current usage metrics.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectResponse>> GetProjectAsResponseAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}