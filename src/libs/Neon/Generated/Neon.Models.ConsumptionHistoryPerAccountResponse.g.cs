
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsumptionHistoryPerAccountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriod> Periods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerAccountResponse" /> class.
        /// </summary>
        /// <param name="periods"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionHistoryPerAccountResponse(
            global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriod> periods)
        {
            this.Periods = periods ?? throw new global::System.ArgumentNullException(nameof(periods));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerAccountResponse" /> class.
        /// </summary>
        public ConsumptionHistoryPerAccountResponse()
        {
        }
    }
}