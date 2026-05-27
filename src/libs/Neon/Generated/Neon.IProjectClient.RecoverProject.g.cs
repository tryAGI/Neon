#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Recover a deleted project<br/>
        /// Recovers a deleted project within the 7-day deletion recovery period.<br/>
        /// Restores branches, endpoints, settings, and connection strings.<br/>
        /// Some integrations require manual reconfiguration after recovery.<br/>
        /// To list recoverable projects, use `GET /projects?recoverable=true`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectRecoverResponse> RecoverProjectAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recover a deleted project<br/>
        /// Recovers a deleted project within the 7-day deletion recovery period.<br/>
        /// Restores branches, endpoints, settings, and connection strings.<br/>
        /// Some integrations require manual reconfiguration after recovery.<br/>
        /// To list recoverable projects, use `GET /projects?recoverable=true`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectRecoverResponse>> RecoverProjectAsResponseAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}