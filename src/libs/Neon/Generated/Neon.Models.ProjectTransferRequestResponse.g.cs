
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectTransferRequestResponse
    {
        /// <summary>
        /// The unique identifier for the transfer request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The ID of the project that is being transferred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The timestamp when the transfer request was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the transfer request will expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTransferRequestResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the transfer request
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that is being transferred
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the transfer request was created
        /// </param>
        /// <param name="expiresAt">
        /// The timestamp when the transfer request will expire
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTransferRequestResponse(
            global::System.Guid id,
            string projectId,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt)
        {
            this.Id = id;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTransferRequestResponse" /> class.
        /// </summary>
        public ProjectTransferRequestResponse()
        {
        }
    }
}