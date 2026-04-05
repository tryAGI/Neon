
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthWebhookConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        public global::System.Collections.Generic.IList<global::Neon.NeonAuthWebhookConfigEnabledEvent>? EnabledEvents { get; set; }

        /// <summary>
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
        /// <param name="enabled"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="enabledEvents"></param>
        /// <param name="timeoutSeconds">
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