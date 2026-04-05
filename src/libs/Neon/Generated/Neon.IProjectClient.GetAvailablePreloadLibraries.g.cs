#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Return available shared preload libraries<br/>
        /// Return available shared preload libraries
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AvailablePreloadLibraries> GetAvailablePreloadLibrariesAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}