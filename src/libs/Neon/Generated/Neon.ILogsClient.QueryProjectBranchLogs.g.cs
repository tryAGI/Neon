#nullable enable

namespace Neon
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Query branch logs<br/>
        /// Returns logs emitted by services running on the specified branch,<br/>
        /// ordered by timestamp according to `sort_order`.<br/>
        /// All supplied filters are combined with `AND`: a record is returned only<br/>
        /// when it matches every filter. `minimum_severity` and `severity_text` are<br/>
        /// independent filters, so setting both requires a record to clear the<br/>
        /// severity floor *and* match the exact severity text.<br/>
        /// Supply `logql` instead of the structured filters to run a raw LogQL<br/>
        /// expression. Combining it with any structured filter is rejected rather<br/>
        /// than silently ignored; `limit`, `sort_order`, and the time window still<br/>
        /// apply, because those bound the query rather than form part of the<br/>
        /// expression.<br/>
        /// Give the window either as `since` — a duration ending at `end_time`, or<br/>
        /// at the current time when `end_time` is omitted — or as an explicit<br/>
        /// `start_time`. Supplying both is rejected.<br/>
        /// A single response holds at most 1,000 records. When `is_truncated` is<br/>
        /// `true`, pass the returned `next_cursor` back as `cursor` to fetch the<br/>
        /// next page, repeating the time range and every filter unchanged.<br/>
        /// If no time range is supplied, the query covers the previous hour. The<br/>
        /// maximum supported time range is seven days. `end_time` is exclusive.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogsQueryResponse> QueryProjectBranchLogsAsync(
            string projectId,
            string branchId,

            global::Neon.ProjectBranchLogsQueryRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query branch logs<br/>
        /// Returns logs emitted by services running on the specified branch,<br/>
        /// ordered by timestamp according to `sort_order`.<br/>
        /// All supplied filters are combined with `AND`: a record is returned only<br/>
        /// when it matches every filter. `minimum_severity` and `severity_text` are<br/>
        /// independent filters, so setting both requires a record to clear the<br/>
        /// severity floor *and* match the exact severity text.<br/>
        /// Supply `logql` instead of the structured filters to run a raw LogQL<br/>
        /// expression. Combining it with any structured filter is rejected rather<br/>
        /// than silently ignored; `limit`, `sort_order`, and the time window still<br/>
        /// apply, because those bound the query rather than form part of the<br/>
        /// expression.<br/>
        /// Give the window either as `since` — a duration ending at `end_time`, or<br/>
        /// at the current time when `end_time` is omitted — or as an explicit<br/>
        /// `start_time`. Supplying both is rejected.<br/>
        /// A single response holds at most 1,000 records. When `is_truncated` is<br/>
        /// `true`, pass the returned `next_cursor` back as `cursor` to fetch the<br/>
        /// next page, repeating the time range and every filter unchanged.<br/>
        /// If no time range is supplied, the query covers the previous hour. The<br/>
        /// maximum supported time range is seven days. `end_time` is exclusive.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogsQueryResponse>> QueryProjectBranchLogsAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.ProjectBranchLogsQueryRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query branch logs<br/>
        /// Returns logs emitted by services running on the specified branch,<br/>
        /// ordered by timestamp according to `sort_order`.<br/>
        /// All supplied filters are combined with `AND`: a record is returned only<br/>
        /// when it matches every filter. `minimum_severity` and `severity_text` are<br/>
        /// independent filters, so setting both requires a record to clear the<br/>
        /// severity floor *and* match the exact severity text.<br/>
        /// Supply `logql` instead of the structured filters to run a raw LogQL<br/>
        /// expression. Combining it with any structured filter is rejected rather<br/>
        /// than silently ignored; `limit`, `sort_order`, and the time window still<br/>
        /// apply, because those bound the query rather than form part of the<br/>
        /// expression.<br/>
        /// Give the window either as `since` — a duration ending at `end_time`, or<br/>
        /// at the current time when `end_time` is omitted — or as an explicit<br/>
        /// `start_time`. Supplying both is rejected.<br/>
        /// A single response holds at most 1,000 records. When `is_truncated` is<br/>
        /// `true`, pass the returned `next_cursor` back as `cursor` to fetch the<br/>
        /// next page, repeating the time range and every filter unchanged.<br/>
        /// If no time range is supplied, the query covers the previous hour. The<br/>
        /// maximum supported time range is seven days. `end_time` is exclusive.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogsQueryResponse> QueryProjectBranchLogsAsync(
            string projectId,
            string branchId,
            string? since = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            string? cursor = default,
            global::Neon.ProjectBranchLogsQueryRequestSortOrder? sortOrder = default,
            global::Neon.ProjectBranchLogSource? source = default,
            string? serviceName = default,
            string? scopeName = default,
            global::Neon.ProjectBranchLogSeverity? minimumSeverity = default,
            string? severityText = default,
            string? bodyContains = default,
            string? traceId = default,
            string? logql = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}