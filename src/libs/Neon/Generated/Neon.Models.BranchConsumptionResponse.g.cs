
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchConsumptionResponse
    {
        /// <summary>
        /// Example: {"compute_time_seconds":3600,"data_transfer_bytes":104857600,"logical_size_bytes":1073741824,"written_size_since_parent_bytes":536870912,"pitr_history_size_since_parent_bytes":268435456}
        /// </summary>
        /// <example>{"compute_time_seconds":3600,"data_transfer_bytes":104857600,"logical_size_bytes":1073741824,"written_size_since_parent_bytes":536870912,"pitr_history_size_since_parent_bytes":268435456}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumption")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BranchConsumption Consumption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchConsumptionResponse" /> class.
        /// </summary>
        /// <param name="consumption">
        /// Example: {"compute_time_seconds":3600,"data_transfer_bytes":104857600,"logical_size_bytes":1073741824,"written_size_since_parent_bytes":536870912,"pitr_history_size_since_parent_bytes":268435456}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchConsumptionResponse(
            global::Neon.BranchConsumption consumption)
        {
            this.Consumption = consumption ?? throw new global::System.ArgumentNullException(nameof(consumption));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchConsumptionResponse" /> class.
        /// </summary>
        public BranchConsumptionResponse()
        {
        }
    }
}