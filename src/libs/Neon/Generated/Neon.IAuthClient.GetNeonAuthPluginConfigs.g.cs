#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get all plugin configurations<br/>
        /// Returns all plugin configurations for Neon Auth in a single response.<br/>
        /// This endpoint aggregates organization, email provider, email and password,<br/>
        /// OAuth providers, and localhost settings.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthPluginConfigs> GetNeonAuthPluginConfigsAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}