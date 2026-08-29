
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogRecord
    {
        /// <summary>
        /// The OpenTelemetry record timestamp in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The OpenTelemetry log body rendered as text. A body that is already a<br/>
        /// string is returned verbatim. Any other OpenTelemetry `AnyValue` body<br/>
        /// — notably the structured key/value body that `storage` records always<br/>
        /// carry — is rendered as compact JSON with its keys sorted<br/>
        /// alphabetically, for example<br/>
        /// `{"bytes":1024,"operation":"GET","object_key":"a/b.png"}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The Neon service that emitted the log record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectBranchLogSourceJsonConverter))]
        public global::Neon.ProjectBranchLogSource? Source { get; set; }

        /// <summary>
        /// The Neon identifier of the service instance that emitted the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// The OpenTelemetry `service.name` resource attribute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_name")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// The OpenTelemetry instrumentation scope name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_name")]
        public string? ScopeName { get; set; }

        /// <summary>
        /// The numeric OpenTelemetry severity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_number")]
        public int? SeverityNumber { get; set; }

        /// <summary>
        /// The original OpenTelemetry severity text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_text")]
        public string? SeverityText { get; set; }

        /// <summary>
        /// The OpenTelemetry trace ID, when the record belongs to a trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// The OpenTelemetry span ID, when the record belongs to a span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// Customer-defined OpenTelemetry log and resource attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogRecord" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The OpenTelemetry record timestamp in UTC.
        /// </param>
        /// <param name="message">
        /// The OpenTelemetry log body rendered as text. A body that is already a<br/>
        /// string is returned verbatim. Any other OpenTelemetry `AnyValue` body<br/>
        /// — notably the structured key/value body that `storage` records always<br/>
        /// carry — is rendered as compact JSON with its keys sorted<br/>
        /// alphabetically, for example<br/>
        /// `{"bytes":1024,"operation":"GET","object_key":"a/b.png"}`.
        /// </param>
        /// <param name="attributes">
        /// Customer-defined OpenTelemetry log and resource attributes.
        /// </param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="entityId">
        /// The Neon identifier of the service instance that emitted the record.
        /// </param>
        /// <param name="serviceName">
        /// The OpenTelemetry `service.name` resource attribute.
        /// </param>
        /// <param name="scopeName">
        /// The OpenTelemetry instrumentation scope name.
        /// </param>
        /// <param name="severityNumber">
        /// The numeric OpenTelemetry severity.
        /// </param>
        /// <param name="severityText">
        /// The original OpenTelemetry severity text.
        /// </param>
        /// <param name="traceId">
        /// The OpenTelemetry trace ID, when the record belongs to a trace.
        /// </param>
        /// <param name="spanId">
        /// The OpenTelemetry span ID, when the record belongs to a span.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogRecord(
            global::System.DateTime timestamp,
            string message,
            object attributes,
            global::Neon.ProjectBranchLogSource? source,
            string? entityId,
            string? serviceName,
            string? scopeName,
            int? severityNumber,
            string? severityText,
            string? traceId,
            string? spanId)
        {
            this.Timestamp = timestamp;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Source = source;
            this.EntityId = entityId;
            this.ServiceName = serviceName;
            this.ScopeName = scopeName;
            this.SeverityNumber = severityNumber;
            this.SeverityText = severityText;
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogRecord" /> class.
        /// </summary>
        public ProjectBranchLogRecord()
        {
        }

    }
}