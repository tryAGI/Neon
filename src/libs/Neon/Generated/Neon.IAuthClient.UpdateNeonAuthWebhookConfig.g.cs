#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update webhook configuration for Neon Auth<br/>
        /// Updates the webhook configuration for Neon Auth on a specific branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthWebhookConfig> UpdateNeonAuthWebhookConfigAsync(
            string projectId,
            string branchId,

            global::Neon.NeonAuthWebhookConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook configuration for Neon Auth<br/>
        /// Updates the webhook configuration for Neon Auth on a specific branch.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="enabled"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="enabledEvents"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: 5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthWebhookConfig> UpdateNeonAuthWebhookConfigAsync(
            string projectId,
            string branchId,
            bool enabled,
            string? webhookUrl = default,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>? enabledEvents = default,
            int? timeoutSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}