
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryConnection
    {
        /// <summary>
        /// Required. Communication protocol used to send telemetry data. Options: grpc, http.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.TelemetryConnectionProtocolJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.TelemetryConnectionProtocol Protocol { get; set; }

        /// <summary>
        /// Required. URI of the OpenTelemetry Collector (e.g., https://collector.customer.com:4317).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.TelemetryAuthentication Authentication { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryConnection" /> class.
        /// </summary>
        /// <param name="protocol">
        /// Required. Communication protocol used to send telemetry data. Options: grpc, http.
        /// </param>
        /// <param name="endpoint">
        /// Required. URI of the OpenTelemetry Collector (e.g., https://collector.customer.com:4317).
        /// </param>
        /// <param name="authentication"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryConnection(
            global::Neon.TelemetryConnectionProtocol protocol,
            string endpoint,
            global::Neon.TelemetryAuthentication authentication)
        {
            this.Protocol = protocol;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Authentication = authentication ?? throw new global::System.ArgumentNullException(nameof(authentication));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryConnection" /> class.
        /// </summary>
        public TelemetryConnection()
        {
        }
    }
}