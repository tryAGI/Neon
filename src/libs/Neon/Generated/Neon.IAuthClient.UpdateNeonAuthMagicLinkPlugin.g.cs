#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update magic link plugin configuration<br/>
        /// Updates the magic link plugin configuration for Neon Auth.<br/>
        /// The magic link plugin enables passwordless authentication via email magic links.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthMagicLinkConfig> UpdateNeonAuthMagicLinkPluginAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthMagicLinkConfigUpdate request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update magic link plugin configuration<br/>
        /// Updates the magic link plugin configuration for Neon Auth.<br/>
        /// The magic link plugin enables passwordless authentication via email magic links.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled">
        /// Whether the magic link plugin is enabled
        /// </param>
        /// <param name="expiresIn">
        /// Time in minutes before the magic link expires
        /// </param>
        /// <param name="disableSignUp">
        /// Whether to disable sign-up via magic link
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthMagicLinkConfig> UpdateNeonAuthMagicLinkPluginAsync(
            string projectId,
            string branchId,
            bool? enabled = default,
            int? expiresIn = default,
            bool? disableSignUp = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}