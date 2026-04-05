
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryConfig
    {
        /// <summary>
        /// Required. The telemetry data types to enable. One or both of: metrics, logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.TelemetryConfigType> Types { get; set; }

        /// <summary>
        /// Optional. Overrides the default endpoint for metrics (e.g., https://metrics.customer.com:4317).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics_endpoint_override")]
        public string? MetricsEndpointOverride { get; set; }

        /// <summary>
        /// Optional. Overrides the default endpoint for logs (e.g., https://logs.customer.com:4318).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs_endpoint_override")]
        public string? LogsEndpointOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryConfig" /> class.
        /// </summary>
        /// <param name="types">
        /// Required. The telemetry data types to enable. One or both of: metrics, logs.
        /// </param>
        /// <param name="metricsEndpointOverride">
        /// Optional. Overrides the default endpoint for metrics (e.g., https://metrics.customer.com:4317).
        /// </param>
        /// <param name="logsEndpointOverride">
        /// Optional. Overrides the default endpoint for logs (e.g., https://logs.customer.com:4318).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryConfig(
            global::System.Collections.Generic.IList<global::Neon.TelemetryConfigType> types,
            string? metricsEndpointOverride,
            string? logsEndpointOverride)
        {
            this.Types = types ?? throw new global::System.ArgumentNullException(nameof(types));
            this.MetricsEndpointOverride = metricsEndpointOverride;
            this.LogsEndpointOverride = logsEndpointOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryConfig" /> class.
        /// </summary>
        public TelemetryConfig()
        {
        }
    }
}