#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update email provider configuration<br/>
        /// Updates the email provider configuration for the specified branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthEmailServerConfig> UpdateNeonAuthEmailProviderAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthEmailServerConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}