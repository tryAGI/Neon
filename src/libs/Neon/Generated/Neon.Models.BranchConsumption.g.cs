
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"compute_time_seconds":3600,"data_transfer_bytes":104857600,"logical_size_bytes":1073741824,"written_size_since_parent_bytes":536870912,"pitr_history_size_since_parent_bytes":268435456}
    /// </summary>
    public sealed partial class BranchConsumption
    {
        /// <summary>
        /// Seconds. The number of CPU seconds used by the branch's compute endpoints, including compute endpoints that have been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ComputeTimeSeconds { get; set; }

        /// <summary>
        /// Bytes. The number of bytes transferred to and from the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_transfer_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DataTransferBytes { get; set; }

        /// <summary>
        /// Bytes. The logical size of the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LogicalSizeBytes { get; set; }

        /// <summary>
        /// Bytes. The number of bytes written to the branch since the parent branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written_size_since_parent_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WrittenSizeSinceParentBytes { get; set; }

        /// <summary>
        /// Bytes. The number of bytes in the PITR history of the branch since the parent branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitr_history_size_since_parent_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PitrHistorySizeSinceParentBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchConsumption" /> class.
        /// </summary>
        /// <param name="computeTimeSeconds">
        /// Seconds. The number of CPU seconds used by the branch's compute endpoints, including compute endpoints that have been deleted.
        /// </param>
        /// <param name="dataTransferBytes">
        /// Bytes. The number of bytes transferred to and from the branch.
        /// </param>
        /// <param name="logicalSizeBytes">
        /// Bytes. The logical size of the branch.
        /// </param>
        /// <param name="writtenSizeSinceParentBytes">
        /// Bytes. The number of bytes written to the branch since the parent branch.
        /// </param>
        /// <param name="pitrHistorySizeSinceParentBytes">
        /// Bytes. The number of bytes in the PITR history of the branch since the parent branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchConsumption(
            int computeTimeSeconds,
            int dataTransferBytes,
            int logicalSizeBytes,
            int writtenSizeSinceParentBytes,
            int pitrHistorySizeSinceParentBytes)
        {
            this.ComputeTimeSeconds = computeTimeSeconds;
            this.DataTransferBytes = dataTransferBytes;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.WrittenSizeSinceParentBytes = writtenSizeSinceParentBytes;
            this.PitrHistorySizeSinceParentBytes = pitrHistorySizeSinceParentBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchConsumption" /> class.
        /// </summary>
        public BranchConsumption()
        {
        }
    }
}