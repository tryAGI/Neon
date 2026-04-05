
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemStatusSummaryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ongoing_incidents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OngoingIncidents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_maintenances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InProgressMaintenances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_maintenances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScheduledMaintenances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatusSummaryResponse" /> class.
        /// </summary>
        /// <param name="ongoingIncidents"></param>
        /// <param name="inProgressMaintenances"></param>
        /// <param name="scheduledMaintenances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemStatusSummaryResponse(
            int ongoingIncidents,
            int inProgressMaintenances,
            int scheduledMaintenances)
        {
            this.OngoingIncidents = ongoingIncidents;
            this.InProgressMaintenances = inProgressMaintenances;
            this.ScheduledMaintenances = scheduledMaintenances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemStatusSummaryResponse" /> class.
        /// </summary>
        public SystemStatusSummaryResponse()
        {
        }
    }
}