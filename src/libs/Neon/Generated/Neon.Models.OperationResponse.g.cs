
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OperationResponse
    {
        /// <summary>
        /// Example: {"id":"d8ac46eb-a757-42b1-9907-f78322ee394e","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","endpoint_id":"ep-silent-smoke-806639","action":"start_compute","status":"finished","failures_count":0,"created_at":"2022-11-15T20:02:00Z","updated_at":"2022-11-15T20:02:02Z","total_duration_ms":200}
        /// </summary>
        /// <example>{"id":"d8ac46eb-a757-42b1-9907-f78322ee394e","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","endpoint_id":"ep-silent-smoke-806639","action":"start_compute","status":"finished","failures_count":0,"created_at":"2022-11-15T20:02:00Z","updated_at":"2022-11-15T20:02:02Z","total_duration_ms":200}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.Operation Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResponse" /> class.
        /// </summary>
        /// <param name="operation">
        /// Example: {"id":"d8ac46eb-a757-42b1-9907-f78322ee394e","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","endpoint_id":"ep-silent-smoke-806639","action":"start_compute","status":"finished","failures_count":0,"created_at":"2022-11-15T20:02:00Z","updated_at":"2022-11-15T20:02:02Z","total_duration_ms":200}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationResponse(
            global::Neon.Operation operation)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResponse" /> class.
        /// </summary>
        public OperationResponse()
        {
        }
    }
}