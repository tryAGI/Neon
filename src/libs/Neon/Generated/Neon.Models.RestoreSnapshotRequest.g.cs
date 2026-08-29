
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RestoreSnapshotRequest
    {
        /// <summary>
        /// A name for the newly restored branch. If not provided, the server generates a unique name for the branch automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the branch to restore the snapshot into. Defaults to the snapshot's source branch (`snapshot.source_branch_id`); fails if that cannot be determined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_branch_id")]
        public string? TargetBranchId { get; set; }

        /// <summary>
        /// Set to `true` to finalize the restore operation immediately.<br/>
        /// This will complete the restore and move any associated computes to the new branch,<br/>
        /// similar to the `finalizeRestoreBranch` operation.<br/>
        /// Defaults to `false` to allow previewing the restored snapshot data first.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalize_restore")]
        public bool? FinalizeRestore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSnapshotRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the newly restored branch. If not provided, the server generates a unique name for the branch automatically.
        /// </param>
        /// <param name="targetBranchId">
        /// ID of the branch to restore the snapshot into. Defaults to the snapshot's source branch (`snapshot.source_branch_id`); fails if that cannot be determined.
        /// </param>
        /// <param name="finalizeRestore">
        /// Set to `true` to finalize the restore operation immediately.<br/>
        /// This will complete the restore and move any associated computes to the new branch,<br/>
        /// similar to the `finalizeRestoreBranch` operation.<br/>
        /// Defaults to `false` to allow previewing the restored snapshot data first.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreSnapshotRequest(
            string? name,
            string? targetBranchId,
            bool? finalizeRestore)
        {
            this.Name = name;
            this.TargetBranchId = targetBranchId;
            this.FinalizeRestore = finalizeRestore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreSnapshotRequest" /> class.
        /// </summary>
        public RestoreSnapshotRequest()
        {
        }

    }
}