
#nullable enable

namespace Neon
{
    /// <summary>
    /// Per-project consumption quotas. If a quota is exceeded, all active computes<br/>
    /// are automatically suspended and cannot be started via API calls or incoming connections.<br/>
    /// The exception is `logical_size_bytes`, which is enforced per branch.<br/>
    /// If a branch exceeds its `logical_size_bytes` quota, computes can still be started,<br/>
    /// but write operations will fail—allowing data to be deleted to free up space.<br/>
    /// Computes on other branches are not affected.<br/>
    /// Setting `logical_size_bytes` overrides any lower value set by the `neon.max_cluster_size` Postgres setting.<br/>
    /// Quotas are enforced using per-project consumption metrics with the same names.<br/>
    /// These metrics reset at the start of each billing period. `logical_size_bytes`<br/>
    /// is also an exception—it reflects the total data stored in a branch and does not reset.<br/>
    /// A zero or empty quota value means “unlimited.”
    /// </summary>
    public sealed partial class ProjectQuota
    {
        /// <summary>
        /// The total amount of wall-clock time allowed to be spent by the project's compute endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_time_seconds")]
        public long? ActiveTimeSeconds { get; set; }

        /// <summary>
        /// The total amount of CPU seconds allowed to be spent by the project's compute endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_time_seconds")]
        public long? ComputeTimeSeconds { get; set; }

        /// <summary>
        /// Total amount of data written to all of a project's branches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written_data_bytes")]
        public long? WrittenDataBytes { get; set; }

        /// <summary>
        /// Total amount of data transferred from all of a project's branches using the proxy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_transfer_bytes")]
        public long? DataTransferBytes { get; set; }

        /// <summary>
        /// Limit on the logical size of every project's branch.<br/>
        /// If a branch exceeds its `logical_size_bytes` quota, computes can still be started,<br/>
        /// but write operations will fail—allowing data to be deleted to free up space.<br/>
        /// Computes on other branches are not affected.<br/>
        /// Setting `logical_size_bytes` overrides any lower value set by the `neon.max_cluster_size` Postgres setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_size_bytes")]
        public long? LogicalSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectQuota" /> class.
        /// </summary>
        /// <param name="activeTimeSeconds">
        /// The total amount of wall-clock time allowed to be spent by the project's compute endpoints.
        /// </param>
        /// <param name="computeTimeSeconds">
        /// The total amount of CPU seconds allowed to be spent by the project's compute endpoints.
        /// </param>
        /// <param name="writtenDataBytes">
        /// Total amount of data written to all of a project's branches.
        /// </param>
        /// <param name="dataTransferBytes">
        /// Total amount of data transferred from all of a project's branches using the proxy.
        /// </param>
        /// <param name="logicalSizeBytes">
        /// Limit on the logical size of every project's branch.<br/>
        /// If a branch exceeds its `logical_size_bytes` quota, computes can still be started,<br/>
        /// but write operations will fail—allowing data to be deleted to free up space.<br/>
        /// Computes on other branches are not affected.<br/>
        /// Setting `logical_size_bytes` overrides any lower value set by the `neon.max_cluster_size` Postgres setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectQuota(
            long? activeTimeSeconds,
            long? computeTimeSeconds,
            long? writtenDataBytes,
            long? dataTransferBytes,
            long? logicalSizeBytes)
        {
            this.ActiveTimeSeconds = activeTimeSeconds;
            this.ComputeTimeSeconds = computeTimeSeconds;
            this.WrittenDataBytes = writtenDataBytes;
            this.DataTransferBytes = dataTransferBytes;
            this.LogicalSizeBytes = logicalSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectQuota" /> class.
        /// </summary>
        public ProjectQuota()
        {
        }
    }
}