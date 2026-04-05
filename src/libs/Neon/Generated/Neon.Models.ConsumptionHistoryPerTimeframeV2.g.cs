
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsumptionHistoryPerTimeframeV2
    {
        /// <summary>
        /// The specified start date-time for the reported consumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeframe_start")]
        public global::System.DateTime? TimeframeStart { get; set; }

        /// <summary>
        /// The specified end date-time for the reported consumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeframe_end")]
        public global::System.DateTime? TimeframeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Neon.ConsumptionMetricValue>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerTimeframeV2" /> class.
        /// </summary>
        /// <param name="timeframeStart">
        /// The specified start date-time for the reported consumption.
        /// </param>
        /// <param name="timeframeEnd">
        /// The specified end date-time for the reported consumption.
        /// </param>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionHistoryPerTimeframeV2(
            global::System.DateTime? timeframeStart,
            global::System.DateTime? timeframeEnd,
            global::System.Collections.Generic.IList<global::Neon.ConsumptionMetricValue>? metrics)
        {
            this.TimeframeStart = timeframeStart;
            this.TimeframeEnd = timeframeEnd;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerTimeframeV2" /> class.
        /// </summary>
        public ConsumptionHistoryPerTimeframeV2()
        {
        }
    }
}