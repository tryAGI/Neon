
#nullable enable

namespace Neon
{
    /// <summary>
    /// Optional. Key-value attributes that describe the source of telemetry (e.g., service.name: neon-test).<br/>
    /// See: @https://opentelemetry.io/docs/specs/semconv/resource/#services
    /// </summary>
    public sealed partial class TelemetryResourceAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}