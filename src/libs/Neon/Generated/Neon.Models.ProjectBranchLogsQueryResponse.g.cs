
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogsQueryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.ProjectBranchLogRecord> Logs { get; set; }

        /// <summary>
        /// Pagination cursor to pass as `cursor` on the next request. Empty<br/>
        /// when the response is not truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// True when more records matched than were returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTruncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsQueryResponse" /> class.
        /// </summary>
        /// <param name="logs"></param>
        /// <param name="isTruncated">
        /// True when more records matched than were returned.
        /// </param>
        /// <param name="nextCursor">
        /// Pagination cursor to pass as `cursor` on the next request. Empty<br/>
        /// when the response is not truncated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogsQueryResponse(
            global::System.Collections.Generic.IList<global::Neon.ProjectBranchLogRecord> logs,
            bool isTruncated,
            string? nextCursor)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.NextCursor = nextCursor;
            this.IsTruncated = isTruncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsQueryResponse" /> class.
        /// </summary>
        public ProjectBranchLogsQueryResponse()
        {
        }

    }
}