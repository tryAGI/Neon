
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthWebhookConfig
    {
        /// <summary>
        /// Whether the webhook is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Destination URL that receives webhook event payloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Event types that trigger this webhook. Covers user lifecycle, email/OTP delivery, organization invitations, and phone verification events; see the enum for exact values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        public global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>? EnabledEvents { get; set; }

        /// <summary>
        /// Maximum time, in seconds, to wait for a response from the webhook endpoint.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthWebhookConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the webhook is active.
        /// </param>
        /// <param name="webhookUrl">
        /// Destination URL that receives webhook event payloads.
        /// </param>
        /// <param name="enabledEvents">
        /// Event types that trigger this webhook. Covers user lifecycle, email/OTP delivery, organization invitations, and phone verification events; see the enum for exact values.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum time, in seconds, to wait for a response from the webhook endpoint.<br/>
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthWebhookConfig(
            bool enabled,
            string? webhookUrl,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>? enabledEvents,
            int? timeoutSeconds)
        {
            this.Enabled = enabled;
            this.WebhookUrl = webhookUrl;
            this.EnabledEvents = enabledEvents;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthWebhookConfig" /> class.
        /// </summary>
        public NeonAuthWebhookConfig()
        {
        }

    }
}