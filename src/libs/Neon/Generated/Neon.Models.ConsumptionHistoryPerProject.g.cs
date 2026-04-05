
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsumptionHistoryPerProject
    {
        /// <summary>
        /// The project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

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
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerProject" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project ID
        /// </param>
        /// <param name="periods"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsumptionHistoryPerProject(
            string projectId,
            global::System.Collections.Generic.IList<global::Neon.ConsumptionHistoryPerPeriod> periods)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Periods = periods ?? throw new global::System.ArgumentNullException(nameof(periods));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumptionHistoryPerProject" /> class.
        /// </summary>
        public ConsumptionHistoryPerProject()
        {
        }
    }
}