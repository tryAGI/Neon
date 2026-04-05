
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchCreateRequestBranch
    {
        /// <summary>
        /// The `branch_id` of the parent branch. If omitted or empty, the branch will be created from the project's default branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// The branch name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A Log Sequence Number (LSN) on the parent branch. The branch will be created with data from this LSN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_lsn")]
        public string? ParentLsn { get; set; }

        /// <summary>
        /// A timestamp identifying a point in time on the parent branch. The branch will be created with data starting from this point in time.<br/>
        /// The timestamp must be provided in ISO 8601 format; for example: `2024-02-26T12:00:00Z`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_timestamp")]
        public global::System.DateTime? ParentTimestamp { get; set; }

        /// <summary>
        /// Whether the branch is protected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        public bool? Protected { get; set; }

        /// <summary>
        /// Whether to create the branch as archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// The source of initialization for the branch. Valid values are `schema-only` and `parent-data` (default).<br/>
        ///   * `schema-only` - creates a new root branch containing only the schema. Use `parent_id` to specify the source branch. Optionally, you can provide `parent_lsn` or `parent_timestamp` to branch from a specific point in time or LSN. These fields define which branch to copy the schema from and at what point—they do not establish a parent-child relationship between the `parent_id` branch and the new schema-only branch.<br/>
        ///   * `parent-data` - creates the branch with both schema and data from the parent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_source")]
        public string? InitSource { get; set; }

        /// <summary>
        /// The timestamp when the branch is scheduled to expire and be automatically deleted. Must be set by the client following the [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6) format with precision up to seconds (such as 2025-06-09T18:02:16Z). Deletion is performed by a background job and may not occur exactly at the specified time.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 2025-06-09T18:02:16Z
        /// </summary>
        /// <example>2025-06-09T18:02:16Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreateRequestBranch" /> class.
        /// </summary>
        /// <param name="parentId">
        /// The `branch_id` of the parent branch. If omitted or empty, the branch will be created from the project's default branch.
        /// </param>
        /// <param name="name">
        /// The branch name
        /// </param>
        /// <param name="parentLsn">
        /// A Log Sequence Number (LSN) on the parent branch. The branch will be created with data from this LSN.
        /// </param>
        /// <param name="parentTimestamp">
        /// A timestamp identifying a point in time on the parent branch. The branch will be created with data starting from this point in time.<br/>
        /// The timestamp must be provided in ISO 8601 format; for example: `2024-02-26T12:00:00Z`.
        /// </param>
        /// <param name="protected">
        /// Whether the branch is protected
        /// </param>
        /// <param name="archived">
        /// Whether to create the branch as archived
        /// </param>
        /// <param name="initSource">
        /// The source of initialization for the branch. Valid values are `schema-only` and `parent-data` (default).<br/>
        ///   * `schema-only` - creates a new root branch containing only the schema. Use `parent_id` to specify the source branch. Optionally, you can provide `parent_lsn` or `parent_timestamp` to branch from a specific point in time or LSN. These fields define which branch to copy the schema from and at what point—they do not establish a parent-child relationship between the `parent_id` branch and the new schema-only branch.<br/>
        ///   * `parent-data` - creates the branch with both schema and data from the parent.
        /// </param>
        /// <param name="expiresAt">
        /// The timestamp when the branch is scheduled to expire and be automatically deleted. Must be set by the client following the [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6) format with precision up to seconds (such as 2025-06-09T18:02:16Z). Deletion is performed by a background job and may not occur exactly at the specified time.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 2025-06-09T18:02:16Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchCreateRequestBranch(
            string? parentId,
            string? name,
            string? parentLsn,
            global::System.DateTime? parentTimestamp,
            bool? @protected,
            bool? archived,
            string? initSource,
            global::System.DateTime? expiresAt)
        {
            this.ParentId = parentId;
            this.Name = name;
            this.ParentLsn = parentLsn;
            this.ParentTimestamp = parentTimestamp;
            this.Protected = @protected;
            this.Archived = archived;
            this.InitSource = initSource;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreateRequestBranch" /> class.
        /// </summary>
        public BranchCreateRequestBranch()
        {
        }
    }
}