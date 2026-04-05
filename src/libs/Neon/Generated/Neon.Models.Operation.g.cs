
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"id":"d8ac46eb-a757-42b1-9907-f78322ee394e","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","endpoint_id":"ep-silent-smoke-806639","action":"start_compute","status":"finished","failures_count":0,"created_at":"2022-11-15T20:02:00Z","updated_at":"2022-11-15T20:02:02Z","total_duration_ms":200}
    /// </summary>
    public sealed partial class Operation
    {
        /// <summary>
        /// The operation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The Neon project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The branch ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// The endpoint ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        public string? EndpointId { get; set; }

        /// <summary>
        /// The action performed by the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.OperationActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.OperationAction Action { get; set; }

        /// <summary>
        /// The status of the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.OperationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.OperationStatus Status { get; set; }

        /// <summary>
        /// The error that occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The number of times the operation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failures_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailuresCount { get; set; }

        /// <summary>
        /// A timestamp indicating when the operation was last retried
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_at")]
        public global::System.DateTime? RetryAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the operation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the operation status was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The total duration of the operation in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// </summary>
        /// <param name="id">
        /// The operation ID
        /// </param>
        /// <param name="projectId">
        /// The Neon project ID
        /// </param>
        /// <param name="action">
        /// The action performed by the operation
        /// </param>
        /// <param name="status">
        /// The status of the operation
        /// </param>
        /// <param name="failuresCount">
        /// The number of times the operation failed
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the operation was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the operation status was last updated
        /// </param>
        /// <param name="totalDurationMs">
        /// The total duration of the operation in milliseconds
        /// </param>
        /// <param name="branchId">
        /// The branch ID
        /// </param>
        /// <param name="endpointId">
        /// The endpoint ID
        /// </param>
        /// <param name="error">
        /// The error that occurred
        /// </param>
        /// <param name="retryAt">
        /// A timestamp indicating when the operation was last retried
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Operation(
            global::System.Guid id,
            string projectId,
            global::Neon.OperationAction action,
            global::Neon.OperationStatus status,
            int failuresCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int totalDurationMs,
            string? branchId,
            string? endpointId,
            string? error,
            global::System.DateTime? retryAt)
        {
            this.Id = id;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BranchId = branchId;
            this.EndpointId = endpointId;
            this.Action = action;
            this.Status = status;
            this.Error = error;
            this.FailuresCount = failuresCount;
            this.RetryAt = retryAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TotalDurationMs = totalDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// </summary>
        public Operation()
        {
        }
    }
}