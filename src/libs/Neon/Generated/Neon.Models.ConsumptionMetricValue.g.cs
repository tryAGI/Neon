
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConsumptionMetricValue
    {
        /// <summary>
        /// Name of the consumption metric, such as compute_time or data_storage_bytes_hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricName { get; set; }

        /// <summary>
        /// Measured quantity for the metric named by `metric_name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionMetricValue" /> class.
        /// </summary>
        /// <param name="metricName">
        /// Name of the consumption metric, such as compute_time or data_storage_bytes_hour.
        /// </param>
        /// <param name="value">
        /// Measured quantity for the metric named by `metric_name`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionMetricValue(
            string metricName,
            int value)
        {
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionMetricValue" /> class.
        /// </summary>
        public ConsumptionMetricValue()
        {
        }

    }
}