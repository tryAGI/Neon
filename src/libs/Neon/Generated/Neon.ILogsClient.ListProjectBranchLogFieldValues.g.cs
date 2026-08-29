#nullable enable

namespace Neon
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// List branch log field values<br/>
        /// Lists the distinct values observed for a low-cardinality log field in<br/>
        /// the requested time range. Call the log fields endpoint first to learn<br/>
        /// which `field_name` values this branch supports; a field that branch has<br/>
        /// never emitted is rejected with `unknown_field`.<br/>
        /// Give the window either as `since` or as an explicit `start_time`;<br/>
        /// supplying both is rejected. If neither is given, the previous six hours<br/>
        /// are used. The maximum supported time range is seven days.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="since">
        /// A length of time as a count and a unit, for example `30m`, `6h`, or<br/>
        /// `7d`. Valid units are `ms`, `s`, `m`, `h`, and `d`.<br/>
        /// Example: 1h
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="fieldName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectBranchLogFieldValuesResponse> ListProjectBranchLogFieldValuesAsync(
            string projectId,
            string branchId,
            string fieldName,
            string? since = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Neon.ProjectBranchLogSource? source = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List branch log field values<br/>
        /// Lists the distinct values observed for a low-cardinality log field in<br/>
        /// the requested time range. Call the log fields endpoint first to learn<br/>
        /// which `field_name` values this branch supports; a field that branch has<br/>
        /// never emitted is rejected with `unknown_field`.<br/>
        /// Give the window either as `since` or as an explicit `start_time`;<br/>
        /// supplying both is rejected. If neither is given, the previous six hours<br/>
        /// are used. The maximum supported time range is seven days.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="since">
        /// A length of time as a count and a unit, for example `30m`, `6h`, or<br/>
        /// `7d`. Valid units are `ms`, `s`, `m`, `h`, and `d`.<br/>
        /// Example: 1h
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="source">
        /// The Neon service that emitted the log record.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="fieldName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectBranchLogFieldValuesResponse>> ListProjectBranchLogFieldValuesAsResponseAsync(
            string projectId,
            string branchId,
            string fieldName,
            string? since = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Neon.ProjectBranchLogSource? source = default,
            int? limit = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}