#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// List available shared preload libraries<br/>
        /// Returns the shared preload libraries available for the specified project's Postgres version.<br/>
        /// Shared preload libraries are Postgres extensions that require the `shared_preload_libraries`<br/>
        /// setting and a compute restart to activate.<br/>
        /// Use this list to determine which libraries can be enabled in the project's<br/>
        /// `settings.preload_libraries` configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AvailablePreloadLibraries> GetAvailablePreloadLibrariesAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List available shared preload libraries<br/>
        /// Returns the shared preload libraries available for the specified project's Postgres version.<br/>
        /// Shared preload libraries are Postgres extensions that require the `shared_preload_libraries`<br/>
        /// setting and a compute restart to activate.<br/>
        /// Use this list to determine which libraries can be enabled in the project's<br/>
        /// `settings.preload_libraries` configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AvailablePreloadLibraries>> GetAvailablePreloadLibrariesAsResponseAsync(
            string projectId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}