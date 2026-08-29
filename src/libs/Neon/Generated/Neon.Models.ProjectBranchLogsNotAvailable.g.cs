
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogsNotAvailable
    {
        /// <summary>
        /// Example: LOGS_NOT_AVAILABLE
        /// </summary>
        /// <example>LOGS_NOT_AVAILABLE</example>
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
        /// Machine-readable reason why logs cannot be read:<br/>
        /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
        ///   have access to it.<br/>
        /// - `telemetry_not_enabled`: the branch exists but is not collecting telemetry, so it<br/>
        ///   has no logs to serve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectBranchLogsNotAvailableReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ProjectBranchLogsNotAvailableReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsNotAvailable" /> class.
        /// </summary>
        /// <param name="code">
        /// Example: LOGS_NOT_AVAILABLE
        /// </param>
        /// <param name="message"></param>
        /// <param name="reason">
        /// Machine-readable reason why logs cannot be read:<br/>
        /// - `branch_not_found`: the project or branch does not exist, or the caller does not<br/>
        ///   have access to it.<br/>
        /// - `telemetry_not_enabled`: the branch exists but is not collecting telemetry, so it<br/>
        ///   has no logs to serve.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogsNotAvailable(
            string code,
            string message,
            global::Neon.ProjectBranchLogsNotAvailableReason reason)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogsNotAvailable" /> class.
        /// </summary>
        public ProjectBranchLogsNotAvailable()
        {
        }

    }
}