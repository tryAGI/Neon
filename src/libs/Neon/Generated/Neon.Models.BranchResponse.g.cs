
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchResponse
    {
        /// <summary>
        /// Example: {"id":"br-wispy-meadow-118737","project_id":"spring-example-302709","parent_id":"br-aged-salad-637688","parent_lsn":"0/1DE2850","name":"dev2","protected":false,"current_state":"ready","state_changed_at":"2022-11-30T20:09:48Z","creation_source":"console","created_at":"2022-11-30T19:09:48Z","updated_at":"2022-12-01T19:53:05Z","default":true,"init_source":"parent-data","data_transfer_bytes":72911987,"written_data_bytes":542998300,"compute_time_seconds":823880990,"active_time_seconds":922200,"cpu_used_sec":461100}
        /// </summary>
        /// <example>{"id":"br-wispy-meadow-118737","project_id":"spring-example-302709","parent_id":"br-aged-salad-637688","parent_lsn":"0/1DE2850","name":"dev2","protected":false,"current_state":"ready","state_changed_at":"2022-11-30T20:09:48Z","creation_source":"console","created_at":"2022-11-30T19:09:48Z","updated_at":"2022-12-01T19:53:05Z","default":true,"init_source":"parent-data","data_transfer_bytes":72911987,"written_data_bytes":542998300,"compute_time_seconds":823880990,"active_time_seconds":922200,"cpu_used_sec":461100}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Branch Branch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchResponse" /> class.
        /// </summary>
        /// <param name="branch">
        /// Example: {"id":"br-wispy-meadow-118737","project_id":"spring-example-302709","parent_id":"br-aged-salad-637688","parent_lsn":"0/1DE2850","name":"dev2","protected":false,"current_state":"ready","state_changed_at":"2022-11-30T20:09:48Z","creation_source":"console","created_at":"2022-11-30T19:09:48Z","updated_at":"2022-12-01T19:53:05Z","default":true,"init_source":"parent-data","data_transfer_bytes":72911987,"written_data_bytes":542998300,"compute_time_seconds":823880990,"active_time_seconds":922200,"cpu_used_sec":461100}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchResponse(
            global::Neon.Branch branch)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchResponse" /> class.
        /// </summary>
        public BranchResponse()
        {
        }
    }
}