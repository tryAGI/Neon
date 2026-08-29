
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
        /// A Postgres LSN (for example, `0/1A2B3C4`) on the source branch to restore from.<br/>
        /// Mutually exclusive with `source_timestamp`. Omit both to restore to head.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lsn")]
        public string? SourceLsn { get; set; }

        /// <summary>
        /// A point in time on the source branch to restore from, in RFC 3339 format. When omitted alongside `source_lsn`, the branch is restored to the latest available state of the source branch.<br/>
        /// Example: 2024-02-26T12:00:00Z
        /// </summary>
        /// <example>2024-02-26T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_timestamp")]
        public global::System.DateTime? SourceTimestamp { get; set; }

        /// <summary>
        /// Name under which to save the current branch state before restoring. Required when the branch has children or when `source_branch_id` equals the branch being restored; in those cases all existing child branches are moved to the newly created branch. If omitted and not required, the previous state is not preserved.
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
        /// A Postgres LSN (for example, `0/1A2B3C4`) on the source branch to restore from.<br/>
        /// Mutually exclusive with `source_timestamp`. Omit both to restore to head.
        /// </param>
        /// <param name="sourceTimestamp">
        /// A point in time on the source branch to restore from, in RFC 3339 format. When omitted alongside `source_lsn`, the branch is restored to the latest available state of the source branch.<br/>
        /// Example: 2024-02-26T12:00:00Z
        /// </param>
        /// <param name="preserveUnderName">
        /// Name under which to save the current branch state before restoring. Required when the branch has children or when `source_branch_id` equals the branch being restored; in those cases all existing child branches are moved to the newly created branch. If omitted and not required, the previous state is not preserved.
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