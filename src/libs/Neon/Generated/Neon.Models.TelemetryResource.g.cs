
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryResource
    {
        /// <summary>
        /// Optional. Key-value attributes that describe the source of telemetry (e.g., service.name: neon-test).<br/>
        /// See: @https://opentelemetry.io/docs/specs/semconv/resource/#services
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryResource" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Optional. Key-value attributes that describe the source of telemetry (e.g., service.name: neon-test).<br/>
        /// See: @https://opentelemetry.io/docs/specs/semconv/resource/#services
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelemetryResource(
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryResource" /> class.
        /// </summary>
        public TelemetryResource()
        {
        }
    }
}