
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestoreRequest
    {
        /// <summary>
        /// The `branch_id` of the restore source branch.<br/>
        /// If `source_timestamp` and `source_lsn` are omitted, the branch will be restored to head.<br/>
        /// If `source_branch_id` is equal to the branch's id, `source_timestamp` or `source_lsn` is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceBranchId { get; set; }

        /// <summary>
        /// A Log Sequence Number (LSN) on the source branch. The branch will be restored with data from this LSN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lsn")]
        public string? SourceLsn { get; set; }

        /// <summary>
        /// A timestamp identifying a point in time on the source branch. The branch will be restored with data starting from this point in time.<br/>
        /// The timestamp must be provided in ISO 8601 format; for example: `2024-02-26T12:00:00Z`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_timestamp")]
        public global::System.DateTime? SourceTimestamp { get; set; }

        /// <summary>
        /// If not empty, the previous state of the branch will be saved to a branch with this name.<br/>
        /// If the branch has children or the `source_branch_id` is equal to the branch id, this field is required. All existing child branches will be moved to the newly created branch under the name `preserve_under_name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_under_name")]
        public string? PreserveUnderName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestoreRequest" /> class.
        /// </summary>
        /// <param name="sourceBranchId">
        /// The `branch_id` of the restore source branch.<br/>
        /// If `source_timestamp` and `source_lsn` are omitted, the branch will be restored to head.<br/>
        /// If `source_branch_id` is equal to the branch's id, `source_timestamp` or `source_lsn` is required.
        /// </param>
        /// <param name="sourceLsn">
        /// A Log Sequence Number (LSN) on the source branch. The branch will be restored with data from this LSN.
        /// </param>
        /// <param name="sourceTimestamp">
        /// A timestamp identifying a point in time on the source branch. The branch will be restored with data starting from this point in time.<br/>
        /// The timestamp must be provided in ISO 8601 format; for example: `2024-02-26T12:00:00Z`.
        /// </param>
        /// <param name="preserveUnderName">
        /// If not empty, the previous state of the branch will be saved to a branch with this name.<br/>
        /// If the branch has children or the `source_branch_id` is equal to the branch id, this field is required. All existing child branches will be moved to the newly created branch under the name `preserve_under_name`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchRestoreRequest(
            string sourceBranchId,
            string? sourceLsn,
            global::System.DateTime? sourceTimestamp,
            string? preserveUnderName)
        {
            this.SourceBranchId = sourceBranchId ?? throw new global::System.ArgumentNullException(nameof(sourceBranchId));
            this.SourceLsn = sourceLsn;
            this.SourceTimestamp = sourceTimestamp;
            this.PreserveUnderName = preserveUnderName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestoreRequest" /> class.
        /// </summary>
        public BranchRestoreRequest()
        {
        }
    }
}