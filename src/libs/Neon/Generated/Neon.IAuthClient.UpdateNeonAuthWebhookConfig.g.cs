#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update Neon Auth webhook configuration<br/>
        /// Updates the webhook configuration for the specified branch's Neon Auth integration.<br/>
        /// Webhooks notify an external endpoint when auth events occur, such as user creation or sign-in.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthWebhookConfig> UpdateNeonAuthWebhookConfigAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthWebhookConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Neon Auth webhook configuration<br/>
        /// Updates the webhook configuration for the specified branch's Neon Auth integration.<br/>
        /// Webhooks notify an external endpoint when auth events occur, such as user creation or sign-in.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthWebhookConfig>> UpdateNeonAuthWebhookConfigAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthWebhookConfig request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Neon Auth webhook configuration<br/>
        /// Updates the webhook configuration for the specified branch's Neon Auth integration.<br/>
        /// Webhooks notify an external endpoint when auth events occur, such as user creation or sign-in.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="enabledEvents"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthWebhookConfig> UpdateNeonAuthWebhookConfigAsync(
            string projectId,
            string branchId,
            bool enabled,
            string? webhookUrl = default,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>? enabledEvents = default,
            int? timeoutSeconds = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}