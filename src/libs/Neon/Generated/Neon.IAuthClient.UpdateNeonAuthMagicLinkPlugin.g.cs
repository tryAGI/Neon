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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthMagicLinkConfig>> UpdateNeonAuthMagicLinkPluginAsResponseAsync(
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
        /// Whether to enable the magic link plugin.
        /// </param>
        /// <param name="expiresIn">
        /// Minutes until the magic link expires.
        /// </param>
        /// <param name="disableSignUp">
        /// When true, sign-up via magic link is disabled.
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