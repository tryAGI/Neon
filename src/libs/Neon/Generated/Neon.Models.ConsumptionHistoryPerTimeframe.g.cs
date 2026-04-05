
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsumptionHistoryPerTimeframe
    {
        /// <summary>
        /// The specified start date-time for the reported consumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeframe_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TimeframeStart { get; set; }

        /// <summary>
        /// The specified end date-time for the reported consumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeframe_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime TimeframeEnd { get; set; }

        /// <summary>
        /// Seconds. The amount of time the compute endpoints have been active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveTimeSeconds { get; set; }

        /// <summary>
        /// Seconds. The number of CPU seconds used by compute endpoints, including compute endpoints that have been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ComputeTimeSeconds { get; set; }

        /// <summary>
        /// Bytes. The amount of written data for all branches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written_data_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WrittenDataBytes { get; set; }

        /// <summary>
        /// Bytes. The space occupied in storage. Synthetic storage size combines the logical data size and Write-Ahead Log (WAL) size for all branches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthetic_storage_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SyntheticStorageSizeBytes { get; set; }

        /// <summary>
        /// Bytes-Hour. The amount of storage consumed hourly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_bytes_hour")]
        public int? DataStorageBytesHour { get; set; }

        /// <summary>
        /// Bytes. The amount of logical size consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_size_bytes")]
        public int? LogicalSizeBytes { get; set; }

        /// <summary>
        /// Bytes-Hour. The amount of logical size consumed hourly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_size_bytes_hour")]
        public int? LogicalSizeBytesHour { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerTimeframe" /> class.
        /// </summary>
        /// <param name="timeframeStart">
        /// The specified start date-time for the reported consumption.
        /// </param>
        /// <param name="timeframeEnd">
        /// The specified end date-time for the reported consumption.
        /// </param>
        /// <param name="activeTimeSeconds">
        /// Seconds. The amount of time the compute endpoints have been active.
        /// </param>
        /// <param name="computeTimeSeconds">
        /// Seconds. The number of CPU seconds used by compute endpoints, including compute endpoints that have been deleted.
        /// </param>
        /// <param name="writtenDataBytes">
        /// Bytes. The amount of written data for all branches.
        /// </param>
        /// <param name="syntheticStorageSizeBytes">
        /// Bytes. The space occupied in storage. Synthetic storage size combines the logical data size and Write-Ahead Log (WAL) size for all branches.
        /// </param>
        /// <param name="dataStorageBytesHour">
        /// Bytes-Hour. The amount of storage consumed hourly.
        /// </param>
        /// <param name="logicalSizeBytes">
        /// Bytes. The amount of logical size consumed.
        /// </param>
        /// <param name="logicalSizeBytesHour">
        /// Bytes-Hour. The amount of logical size consumed hourly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionHistoryPerTimeframe(
            global::System.DateTime timeframeStart,
            global::System.DateTime timeframeEnd,
            int activeTimeSeconds,
            int computeTimeSeconds,
            int writtenDataBytes,
            int syntheticStorageSizeBytes,
            int? dataStorageBytesHour,
            int? logicalSizeBytes,
            int? logicalSizeBytesHour)
        {
            this.TimeframeStart = timeframeStart;
            this.TimeframeEnd = timeframeEnd;
            this.ActiveTimeSeconds = activeTimeSeconds;
            this.ComputeTimeSeconds = computeTimeSeconds;
            this.WrittenDataBytes = writtenDataBytes;
            this.SyntheticStorageSizeBytes = syntheticStorageSizeBytes;
            this.DataStorageBytesHour = dataStorageBytesHour;
            this.LogicalSizeBytes = logicalSizeBytes;
            this.LogicalSizeBytesHour = logicalSizeBytesHour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerTimeframe" /> class.
        /// </summary>
        public ConsumptionHistoryPerTimeframe()
        {
        }
    }
}