#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update email provider configuration<br/>
        /// Updates the email provider configuration for the specified branch's Neon Auth integration.<br/>
        /// The email provider handles transactional messages such as verification emails and password reset links.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthEmailServerConfig> UpdateNeonAuthEmailProviderAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthEmailServerConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update email provider configuration<br/>
        /// Updates the email provider configuration for the specified branch's Neon Auth integration.<br/>
        /// The email provider handles transactional messages such as verification emails and password reset links.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthEmailServerConfig>> UpdateNeonAuthEmailProviderAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthEmailServerConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}