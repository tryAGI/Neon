
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"branch_id":"br-aged-salad-637688","project_id":"simple-truth-637688","state":"anonymizing","status_message":"Anonymizing table mydb.public.users (3/5)","created_at":"2022-11-30T18:25:15Z","updated_at":"2022-11-30T18:30:22Z","last_run":{"started_at":"2022-11-30T18:25:15Z","completed_at":"2022-11-30T18:30:22Z","triggered_by":"df6c5f70-6cbf-4c8c-9e7a-74c3ddbd8f9f","masked_columns":12}}
    /// </summary>
    public sealed partial class AnonymizedBranchStatusResponse
    {
        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The ID of the anonymized branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// The current state of the anonymized branch. Possible values: created, initialized, initialization_error, anonymizing, anonymized, error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// A descriptive message about the current status or any errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// A timestamp indicating when the anonymized branch was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the anonymized branch status was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the anonymized branch operation failed (if applicable)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// Metadata about the most recent anonymization attempt for the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run")]
        public global::Neon.AnonymizationRunMetadata? LastRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizedBranchStatusResponse" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="branchId">
        /// The ID of the anonymized branch
        /// </param>
        /// <param name="state">
        /// The current state of the anonymized branch. Possible values: created, initialized, initialization_error, anonymizing, anonymized, error
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the anonymized branch was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the anonymized branch status was last updated
        /// </param>
        /// <param name="statusMessage">
        /// A descriptive message about the current status or any errors
        /// </param>
        /// <param name="failedAt">
        /// A timestamp indicating when the anonymized branch operation failed (if applicable)
        /// </param>
        /// <param name="lastRun">
        /// Metadata about the most recent anonymization attempt for the branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnonymizedBranchStatusResponse(
            string projectId,
            string branchId,
            string state,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? statusMessage,
            global::System.DateTime? failedAt,
            global::Neon.AnonymizationRunMetadata? lastRun)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.StatusMessage = statusMessage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FailedAt = failedAt;
            this.LastRun = lastRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizedBranchStatusResponse" /> class.
        /// </summary>
        public AnonymizedBranchStatusResponse()
        {
        }
    }
}