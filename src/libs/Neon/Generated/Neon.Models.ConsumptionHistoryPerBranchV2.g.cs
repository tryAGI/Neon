
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsumptionHistoryPerBranchV2
    {
        /// <summary>
        /// The project that owns the branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The branch ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriodV2> Periods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerBranchV2" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project that owns the branch
        /// </param>
        /// <param name="branchId">
        /// The branch ID
        /// </param>
        /// <param name="periods"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionHistoryPerBranchV2(
            string projectId,
            string branchId,
            global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriodV2> periods)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.Periods = periods ?? throw new global::System.ArgumentNullException(nameof(periods));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerBranchV2" /> class.
        /// </summary>
        public ConsumptionHistoryPerBranchV2()
        {
        }

    }
}