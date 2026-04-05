#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get allow localhost<br/>
        /// Get the allow localhost configuration for the specified branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthAllowLocalhostResponse> GetNeonAuthAllowLocalhostAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}