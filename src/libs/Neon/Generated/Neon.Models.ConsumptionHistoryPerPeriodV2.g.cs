
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"period_id":"79ec829f-1828-4006-ac82-9f1828a0067d","period_plan":"scale","period_start":"2024-03-01T00:00:00Z","consumption":[{"timeframe_start":"2024-03-22T00:00:00Z","timeframe_end":"2024-03-23T00:00:00Z","metrics":[{"metric_name":"compute_unit_seconds","value":100},{"metric_name":"root_branch_bytes_month","value":1000000},{"metric_name":"child_branch_bytes_month","value":1000000}]}]}
    /// </summary>
    public sealed partial class ConsumptionHistoryPerPeriodV2
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
        public required global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframeV2> Consumption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerPeriodV2" /> class.
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
        public ConsumptionHistoryPerPeriodV2(
            global::System.Guid periodId,
            string periodPlan,
            global::System.DateTime periodStart,
            global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerTimeframeV2> consumption,
            global::System.DateTime? periodEnd)
        {
            this.PeriodId = periodId;
            this.PeriodPlan = periodPlan ?? throw new global::System.ArgumentNullException(nameof(periodPlan));
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.Consumption = consumption ?? throw new global::System.ArgumentNullException(nameof(consumption));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerPeriodV2" /> class.
        /// </summary>
        public ConsumptionHistoryPerPeriodV2()
        {
        }
    }
}