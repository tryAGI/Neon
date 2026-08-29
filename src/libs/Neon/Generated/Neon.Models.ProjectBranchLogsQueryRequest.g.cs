
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogsQueryRequest
    {
        /// <summary>
        /// Length of the query window, ending at `end_time` or at the current<br/>
        /// time when `end_time` is omitted. Mutually exclusive with<br/>
        /// `start_time`. Prefer this over computing absolute bounds when the<br/>
        /// caller only means "the last hour".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        public string? Since { get; set; }

        /// <summary>
        /// Inclusive beginning of the query window. Mutually exclusive with<br/>
        /// `since`. Defaults to one hour before `end_time`, or one hour before<br/>
        /// the current time when both bounds are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Exclusive end of the query window. Defaults to the current time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Maximum number of log records to return per page.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Opaque pagination cursor returned as `next_cursor` by a previous<br/>
        /// call. Resume the query after the last record of the previous page,<br/>
        /// repeating the time range and every filter unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Order matching records by timestamp. `desc`, the default, returns<br/>
        /// the newest records first.<br/>
        /// Default Value: desc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectBranchLogsQueryRequestSortOrderJsonConverter))]
        public global::Neon.ProjectBranchLogsQueryRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// The Neon service that emitted the log record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectBranchLogSourceJsonConverter))]
        public global::Neon.ProjectBranchLogSource? Source { get; set; }

        /// <summary>
        /// Match the OpenTelemetry `service.name` resource attribute exactly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_name")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// Match the OpenTelemetry instrumentation scope name exactly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_name")]
        public string? ScopeName { get; set; }

        /// <summary>
        /// An OpenTelemetry severity level. A minimum severity includes every<br/>
        /// higher level in this order: `trace`, `debug`, `info`, `warn`, `error`,<br/>
        /// `fatal`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectBranchLogSeverityJsonConverter))]
        public global::Neon.ProjectBranchLogSeverity? MinimumSeverity { get; set; }

        /// <summary>
        /// Match the OpenTelemetry severity text exactly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_text")]
        public string? SeverityText { get; set; }

        /// <summary>
        /// Match records whose rendered `message` contains this case-sensitive<br/>
        /// substring.<br/>
        /// Records with a structured body are matched against their JSON<br/>
        /// rendering, so the substring meets JSON syntax rather than prose: a<br/>
        /// bare key name such as `operation` matches every record carrying that<br/>
        /// key, and `http_status: 200` matches none, because the rendering<br/>
        /// contains `"http_status":200` with no space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_contains")]
        public string? BodyContains { get; set; }

        /// <summary>
        /// Match records associated with this OpenTelemetry trace ID. W3C Trace<br/>
        /// Context defines a trace ID as 32 lowercase hex digits, and that is<br/>
        /// what is stored, so an uppercase value is rejected rather than<br/>
        /// silently matching nothing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Escape hatch for selections the structured filters cannot express: a<br/>
        /// raw LogQL expression, evaluated against this branch's log stream.<br/>
        /// Only stream selectors and line filters are accepted — no<br/>
        /// aggregations and no parser stages. Supplying this alongside any<br/>
        /// structured filter is rejected with `conflicting_filters` rather than<br/>
        /// silently ignoring one of them. `limit`, `sort_order`, and the time<br/>
        /// window still apply.<br/>
        /// This field passes the underlying query language through to the<br/>
        /// caller, so unlike the rest of this contract it may change as that<br/>
        /// backend changes. Prefer the structured filters where they suffice.<br/>
        /// Example: {entity_type="function"} |~ "(?i)timeout"
        /// </summary>
        /// <example>{entity_type="function"} |~ "(?i)timeout"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logql")]
        public string? Logql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsQueryRequest" /> class.
        /// </summary>
        /// <param name="since">
        /// Length of the query window, ending at `end_time` or at the current<br/>
        /// time when `end_time` is omitted. Mutually exclusive with<br/>
        /// `start_time`. Prefer this over computing absolute bounds when the<br/>
        /// caller only means "the last hour".
        /// </param>
        /// <param name="startTime">
        /// Inclusive beginning of the query window. Mutually exclusive with<br/>
        /// `since`. Defaults to one hour before `end_time`, or one hour before<br/>
        /// the current time when both bounds are omitted.
        /// </param>
        /// <param name="endTime">
        /// Exclusive end of the query window. Defaults to the current time.
        /// </param>
        /// <param name="limit">
        /// Maximum number of log records to return per page.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor returned as `next_cursor` by a previous<br/>
        /// call. Resume the query after the last record of the previous page,<br/>
        /// repeating the time range and every filter unchanged.
        /// </param>
        /// <param name="sortOrder">
        /// Order matching records by timestamp. `desc`, the default, returns<br/>
        /// the newest records first.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="serviceName">
        /// Match the OpenTelemetry `service.name` resource attribute exactly.
        /// </param>
        /// <param name="scopeName">
        /// Match the OpenTelemetry instrumentation scope name exactly.
        /// </param>
        /// <param name="minimumSeverity">
        /// An OpenTelemetry severity level. A minimum severity includes every<br/>
        /// higher level in this order: `trace`, `debug`, `info`, `warn`, `error`,<br/>
        /// `fatal`.
        /// </param>
        /// <param name="severityText">
        /// Match the OpenTelemetry severity text exactly.
        /// </param>
        /// <param name="bodyContains">
        /// Match records whose rendered `message` contains this case-sensitive<br/>
        /// substring.<br/>
        /// Records with a structured body are matched against their JSON<br/>
        /// rendering, so the substring meets JSON syntax rather than prose: a<br/>
        /// bare key name such as `operation` matches every record carrying that<br/>
        /// key, and `http_status: 200` matches none, because the rendering<br/>
        /// contains `"http_status":200` with no space.
        /// </param>
        /// <param name="traceId">
        /// Match records associated with this OpenTelemetry trace ID. W3C Trace<br/>
        /// Context defines a trace ID as 32 lowercase hex digits, and that is<br/>
        /// what is stored, so an uppercase value is rejected rather than<br/>
        /// silently matching nothing.
        /// </param>
        /// <param name="logql">
        /// Escape hatch for selections the structured filters cannot express: a<br/>
        /// raw LogQL expression, evaluated against this branch's log stream.<br/>
        /// Only stream selectors and line filters are accepted — no<br/>
        /// aggregations and no parser stages. Supplying this alongside any<br/>
        /// structured filter is rejected with `conflicting_filters` rather than<br/>
        /// silently ignoring one of them. `limit`, `sort_order`, and the time<br/>
        /// window still apply.<br/>
        /// This field passes the underlying query language through to the<br/>
        /// caller, so unlike the rest of this contract it may change as that<br/>
        /// backend changes. Prefer the structured filters where they suffice.<br/>
        /// Example: {entity_type="function"} |~ "(?i)timeout"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogsQueryRequest(
            string? since,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? limit,
            string? cursor,
            global::Neon.ProjectBranchLogsQueryRequestSortOrder? sortOrder,
            global::Neon.ProjectBranchLogSource? source,
            string? serviceName,
            string? scopeName,
            global::Neon.ProjectBranchLogSeverity? minimumSeverity,
            string? severityText,
            string? bodyContains,
            string? traceId,
            string? logql)
        {
            this.Since = since;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Limit = limit;
            this.Cursor = cursor;
            this.SortOrder = sortOrder;
            this.Source = source;
            this.ServiceName = serviceName;
            this.ScopeName = scopeName;
            this.MinimumSeverity = minimumSeverity;
            this.SeverityText = severityText;
            this.BodyContains = bodyContains;
            this.TraceId = traceId;
            this.Logql = logql;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsQueryRequest" /> class.
        /// </summary>
        public ProjectBranchLogsQueryRequest()
        {
        }

    }
}