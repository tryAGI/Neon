
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogsInvalidQuery
    {
        /// <summary>
        /// Example: LOGS_INVALID_QUERY
        /// </summary>
        /// <example>LOGS_INVALID_QUERY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable reason why the request was rejected:<br/>
        /// - `time_range_too_large`: the requested window spans more than seven days.<br/>
        /// - `invalid_time_range`: `end_time` is not after `start_time`.<br/>
        /// - `conflicting_time_range`: both `since` and `start_time` were supplied.<br/>
        /// - `invalid_cursor`: the supplied `cursor` is malformed, expired, or was issued for a<br/>
        ///   different query.<br/>
        /// - `unknown_field`: the requested `field_name` is not one of the fields the log fields<br/>
        ///   endpoint reports for this branch.<br/>
        /// - `invalid_logql`: the supplied `logql` expression does not parse, or uses a<br/>
        ///   construct this endpoint does not accept.<br/>
        /// - `conflicting_filters`: `logql` was supplied alongside one or more structured<br/>
        ///   filters. Use one or the other.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectBranchLogsInvalidQueryReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ProjectBranchLogsInvalidQueryReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsInvalidQuery" /> class.
        /// </summary>
        /// <param name="code">
        /// Example: LOGS_INVALID_QUERY
        /// </param>
        /// <param name="message"></param>
        /// <param name="reason">
        /// Machine-readable reason why the request was rejected:<br/>
        /// - `time_range_too_large`: the requested window spans more than seven days.<br/>
        /// - `invalid_time_range`: `end_time` is not after `start_time`.<br/>
        /// - `conflicting_time_range`: both `since` and `start_time` were supplied.<br/>
        /// - `invalid_cursor`: the supplied `cursor` is malformed, expired, or was issued for a<br/>
        ///   different query.<br/>
        /// - `unknown_field`: the requested `field_name` is not one of the fields the log fields<br/>
        ///   endpoint reports for this branch.<br/>
        /// - `invalid_logql`: the supplied `logql` expression does not parse, or uses a<br/>
        ///   construct this endpoint does not accept.<br/>
        /// - `conflicting_filters`: `logql` was supplied alongside one or more structured<br/>
        ///   filters. Use one or the other.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogsInvalidQuery(
            string code,
            string message,
            global::Neon.ProjectBranchLogsInvalidQueryReason reason)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsInvalidQuery" /> class.
        /// </summary>
        public ProjectBranchLogsInvalidQuery()
        {
        }

    }
}