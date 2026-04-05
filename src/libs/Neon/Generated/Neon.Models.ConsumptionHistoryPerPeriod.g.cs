
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"period_id":"79ec829f-1828-4006-ac82-9f1828a0067d","period_plan":"scale","period_start":"2024-03-01T00:00:00Z","consumption":[{"timeframe_start":"2024-03-22T00:00:00Z","timeframe_end":"2024-03-23T00:00:00Z","active_time_seconds":27853,"compute_time_seconds":18346,"written_data_bytes":1073741824,"synthetic_storage_size_bytes":5368709120},{"timeframe_start":"2024-03-23T00:00:00Z","timeframe_end":"2024-03-24T00:00:00Z","active_time_seconds":17498,"compute_time_seconds":3378,"written_data_bytes":5741824,"synthetic_storage_size_bytes":2370912}]}
    /// </summary>
    public sealed partial class ConsumptionHistoryPerPeriod
    {
        /// <summary>
        /// The ID assigned to the specified billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PeriodId { get; set; }

        /// <summary>
        /// The billing plan applicable during the billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PeriodPlan { get; set; }

        /// <summary>
        /// The start date-time of the billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodStart { get; set; }

        /// <summary>
        /// The end date-time of the billing period, available for the past periods only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end")]
        public global::System.DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumption")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframe> Consumption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerPeriod" /> class.
        /// </summary>
        /// <param name="periodId">
        /// The ID assigned to the specified billing period.
        /// </param>
        /// <param name="periodPlan">
        /// The billing plan applicable during the billing period.
        /// </param>
        /// <param name="periodStart">
        /// The start date-time of the billing period.
        /// </param>
        /// <param name="consumption"></param>
        /// <param name="periodEnd">
        /// The end date-time of the billing period, available for the past periods only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionHistoryPerPeriod(
            global::System.Guid periodId,
            string periodPlan,
            global::System.DateTime periodStart,
            global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframe> consumption,
            global::System.DateTime? periodEnd)
        {
            this.PeriodId = periodId;
            this.PeriodPlan = periodPlan ?? throw new global::System.ArgumentNullException(nameof(periodPlan));
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.Consumption = consumption ?? throw new global::System.ArgumentNullException(nameof(consumption));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerPeriod" /> class.
        /// </summary>
        public ConsumptionHistoryPerPeriod()
        {
        }
    }
}