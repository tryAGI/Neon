
#nullable enable

namespace Neon
{
    /// <summary>
    /// Metadata about the most recent anonymization attempt for the branch.
    /// </summary>
    public sealed partial class AnonymizationRunMetadata
    {
        /// <summary>
        /// Timestamp indicating when the latest anonymization attempt started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when the latest anonymization attempt completed.<br/>
        /// Populated even if the attempt failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// UUID of the user who triggered the latest anonymization attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by")]
        public global::System.Guid? TriggeredBy { get; set; }

        /// <summary>
        /// Username of the user who triggered the latest anonymization attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by_username")]
        public string? TriggeredByUsername { get; set; }

        /// <summary>
        /// Number of columns that had masking rules applied during the attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masked_columns")]
        public int? MaskedColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizationRunMetadata" /> class.
        /// </summary>
        /// <param name="startedAt">
        /// Timestamp indicating when the latest anonymization attempt started.
        /// </param>
        /// <param name="completedAt">
        /// Timestamp indicating when the latest anonymization attempt completed.<br/>
        /// Populated even if the attempt failed.
        /// </param>
        /// <param name="triggeredBy">
        /// UUID of the user who triggered the latest anonymization attempt.
        /// </param>
        /// <param name="triggeredByUsername">
        /// Username of the user who triggered the latest anonymization attempt.
        /// </param>
        /// <param name="maskedColumns">
        /// Number of columns that had masking rules applied during the attempt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnonymizationRunMetadata(
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            global::System.Guid? triggeredBy,
            string? triggeredByUsername,
            int? maskedColumns)
        {
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.TriggeredBy = triggeredBy;
            this.TriggeredByUsername = triggeredByUsername;
            this.MaskedColumns = maskedColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymizationRunMetadata" /> class.
        /// </summary>
        public AnonymizationRunMetadata()
        {
        }
    }
}