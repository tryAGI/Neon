
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"id":"br-wispy-meadow-118737","project_id":"spring-example-302709","parent_id":"br-aged-salad-637688","parent_lsn":"0/1DE2850","name":"dev2","protected":false,"current_state":"ready","state_changed_at":"2022-11-30T20:09:48Z","creation_source":"console","created_at":"2022-11-30T19:09:48Z","updated_at":"2022-12-01T19:53:05Z","default":true,"init_source":"parent-data","data_transfer_bytes":72911987,"written_data_bytes":542998300,"compute_time_seconds":823880990,"active_time_seconds":922200,"cpu_used_sec":461100}
    /// </summary>
    public sealed partial class Branch
    {
        /// <summary>
        /// The branch ID. This value is generated when a branch is created. A `branch_id` value has a `br` prefix. For example: `br-small-term-683261`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the project to which the branch belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The `branch_id` of the parent branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// The Log Sequence Number (LSN) on the parent branch from which this branch was created.<br/>
        /// When restoring a branch using the [Restore branch](https://api-docs.neon.tech/reference/restoreprojectbranch) endpoint,<br/>
        /// this value isn’t finalized until all operations related to the restore have completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_lsn")]
        public string? ParentLsn { get; set; }

        /// <summary>
        /// The point in time on the parent branch from which this branch was created.<br/>
        /// When restoring a branch using the [Restore branch](https://api-docs.neon.tech/reference/restoreprojectbranch) endpoint,<br/>
        /// this value isn’t finalized until all operations related to the restore have completed successfully.<br/>
        /// After all the operations completed, this value might stay empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_timestamp")]
        public global::System.DateTime? ParentTimestamp { get; set; }

        /// <summary>
        /// The branch name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The branch’s state, indicating if it is initializing, ready for use, or archived.<br/>
        ///   * 'init' - the branch is being created but is not available for querying.<br/>
        ///   * 'resetting' - the branch is being reset to a specific point in time or LSN and is not yet available for querying.<br/>
        ///   * 'ready' - the branch is fully operational and ready for querying. Expect normal query response times.<br/>
        ///   * 'archived' - the branch is stored in cost-effective archival storage. Expect slow query response times.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentState { get; set; }

        /// <summary>
        /// The branch’s state, indicating if it is initializing, ready for use, or archived.<br/>
        ///   * 'init' - the branch is being created but is not available for querying.<br/>
        ///   * 'resetting' - the branch is being reset to a specific point in time or LSN and is not yet available for querying.<br/>
        ///   * 'ready' - the branch is fully operational and ready for querying. Expect normal query response times.<br/>
        ///   * 'archived' - the branch is stored in cost-effective archival storage. Expect slow query response times.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_state")]
        public string? PendingState { get; set; }

        /// <summary>
        /// A UTC timestamp indicating when the `current_state` began
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_changed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StateChangedAt { get; set; }

        /// <summary>
        /// The logical size of the branch, in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_size")]
        public long? LogicalSize { get; set; }

        /// <summary>
        /// The branch creation source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreationSource { get; set; }

        /// <summary>
        /// DEPRECATED. Use `default` field.<br/>
        /// Whether the branch is the project's primary branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Whether the branch is the project's default branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// Whether the branch is protected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Protected { get; set; }

        /// <summary>
        /// CPU seconds used by all of the branch's compute endpoints, including deleted ones.<br/>
        /// This value is reset at the beginning of each billing period.<br/>
        /// Examples:<br/>
        /// 1. A branch that uses 1 CPU for 1 second is equal to `cpu_used_sec=1`.<br/>
        /// 2. A branch that uses 2 CPUs simultaneously for 1 second is equal to `cpu_used_sec=2`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_used_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CpuUsedSec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ComputeTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ActiveTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("written_data_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long WrittenDataBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_transfer_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DataTransferBytes { get; set; }

        /// <summary>
        /// A timestamp indicating when the branch was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the branch was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The time-to-live (TTL) duration originally configured for the branch, in seconds. This read-only value represents the interval between the time `expires_at` was set and the expiration timestamp itself. It is preserved to ensure the same TTL duration is reapplied when resetting the branch from its parent, and only updates when a new `expires_at` value is set.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_interval_seconds")]
        public int? TtlIntervalSeconds { get; set; }

        /// <summary>
        /// The timestamp when the branch is scheduled to expire and be automatically deleted. Must be set by the client following the [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6) format with precision up to seconds (such as 2025-06-09T18:02:16Z). Deletion is performed by a background job and may not occur exactly at the specified time.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 2025-06-09T18:02:16Z
        /// </summary>
        /// <example>2025-06-09T18:02:16Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the branch was last reset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reset_at")]
        public global::System.DateTime? LastResetAt { get; set; }

        /// <summary>
        /// The resolved user model that contains details of the user/org/integration/api_key used for branch creation. This field is filled only in listing/get/create/get/update/delete methods, if it is empty when calling other handlers, it does not mean that it is empty in the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::Neon.BranchCreatedBy? CreatedBy { get; set; }

        /// <summary>
        /// The source of initialization for the branch. Valid values are `schema-only` and `parent-data` (default).<br/>
        ///   * `schema-only` - creates a new root branch containing only the schema. Use `parent_id` to specify the source branch. Optionally, you can provide `parent_lsn` or `parent_timestamp` to branch from a specific point in time or LSN. These fields define which branch to copy the schema from and at what point—they do not establish a parent-child relationship between the `parent_id` branch and the new schema-only branch.<br/>
        ///   * `parent-data` - creates the branch with both schema and data from the parent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_source")]
        public string? InitSource { get; set; }

        /// <summary>
        /// Could be `restored`, `finalized` or `detaching`.<br/>
        /// A `restored` branch becomes permanently `finalized` when you call `finalizeRestoreBranch`<br/>
        /// A `restored` or `finalized` branch may begin `detaching` as a one-time performance optimisation, after which it will continue in its original state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore_status")]
        public string? RestoreStatus { get; set; }

        /// <summary>
        /// ID of the snapshot that was the restore source for this branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restored_from")]
        public string? RestoredFrom { get; set; }

        /// <summary>
        /// ID of the target branch which was replaced when this branch was restored
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restored_as")]
        public string? RestoredAs { get; set; }

        /// <summary>
        /// A list of actions that are currently restricted for this branch and the reason why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_actions")]
        public global::System.Collections.Generic.IList<global::Neon.BranchRestrictedAction>? RestrictedActions { get; set; }

        /// <summary>
        /// Recovery information for a deleted branch. Only present when listing deleted branches<br/>
        /// with `include_deleted=true`.<br/>
        /// This is part of the Branch Recovery feature, which is in preview and not available to all users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery")]
        public global::Neon.BranchRecoveryInfo? Recovery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Branch" /> class.
        /// </summary>
        /// <param name="id">
        /// The branch ID. This value is generated when a branch is created. A `branch_id` value has a `br` prefix. For example: `br-small-term-683261`.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project to which the branch belongs
        /// </param>
        /// <param name="name">
        /// The branch name
        /// </param>
        /// <param name="currentState">
        /// The branch’s state, indicating if it is initializing, ready for use, or archived.<br/>
        ///   * 'init' - the branch is being created but is not available for querying.<br/>
        ///   * 'resetting' - the branch is being reset to a specific point in time or LSN and is not yet available for querying.<br/>
        ///   * 'ready' - the branch is fully operational and ready for querying. Expect normal query response times.<br/>
        ///   * 'archived' - the branch is stored in cost-effective archival storage. Expect slow query response times.
        /// </param>
        /// <param name="stateChangedAt">
        /// A UTC timestamp indicating when the `current_state` began
        /// </param>
        /// <param name="creationSource">
        /// The branch creation source
        /// </param>
        /// <param name="default">
        /// Whether the branch is the project's default branch
        /// </param>
        /// <param name="protected">
        /// Whether the branch is protected
        /// </param>
        /// <param name="cpuUsedSec">
        /// CPU seconds used by all of the branch's compute endpoints, including deleted ones.<br/>
        /// This value is reset at the beginning of each billing period.<br/>
        /// Examples:<br/>
        /// 1. A branch that uses 1 CPU for 1 second is equal to `cpu_used_sec=1`.<br/>
        /// 2. A branch that uses 2 CPUs simultaneously for 1 second is equal to `cpu_used_sec=2`.
        /// </param>
        /// <param name="computeTimeSeconds"></param>
        /// <param name="activeTimeSeconds"></param>
        /// <param name="writtenDataBytes"></param>
        /// <param name="dataTransferBytes"></param>
        /// <param name="createdAt">
        /// A timestamp indicating when the branch was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the branch was last updated
        /// </param>
        /// <param name="parentId">
        /// The `branch_id` of the parent branch
        /// </param>
        /// <param name="parentLsn">
        /// The Log Sequence Number (LSN) on the parent branch from which this branch was created.<br/>
        /// When restoring a branch using the [Restore branch](https://api-docs.neon.tech/reference/restoreprojectbranch) endpoint,<br/>
        /// this value isn’t finalized until all operations related to the restore have completed successfully.
        /// </param>
        /// <param name="parentTimestamp">
        /// The point in time on the parent branch from which this branch was created.<br/>
        /// When restoring a branch using the [Restore branch](https://api-docs.neon.tech/reference/restoreprojectbranch) endpoint,<br/>
        /// this value isn’t finalized until all operations related to the restore have completed successfully.<br/>
        /// After all the operations completed, this value might stay empty.
        /// </param>
        /// <param name="pendingState">
        /// The branch’s state, indicating if it is initializing, ready for use, or archived.<br/>
        ///   * 'init' - the branch is being created but is not available for querying.<br/>
        ///   * 'resetting' - the branch is being reset to a specific point in time or LSN and is not yet available for querying.<br/>
        ///   * 'ready' - the branch is fully operational and ready for querying. Expect normal query response times.<br/>
        ///   * 'archived' - the branch is stored in cost-effective archival storage. Expect slow query response times.
        /// </param>
        /// <param name="logicalSize">
        /// The logical size of the branch, in bytes
        /// </param>
        /// <param name="ttlIntervalSeconds">
        /// The time-to-live (TTL) duration originally configured for the branch, in seconds. This read-only value represents the interval between the time `expires_at` was set and the expiration timestamp itself. It is preserved to ensure the same TTL duration is reapplied when resetting the branch from its parent, and only updates when a new `expires_at` value is set.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 3600
        /// </param>
        /// <param name="expiresAt">
        /// The timestamp when the branch is scheduled to expire and be automatically deleted. Must be set by the client following the [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6) format with precision up to seconds (such as 2025-06-09T18:02:16Z). Deletion is performed by a background job and may not occur exactly at the specified time.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 2025-06-09T18:02:16Z
        /// </param>
        /// <param name="lastResetAt">
        /// A timestamp indicating when the branch was last reset
        /// </param>
        /// <param name="createdBy">
        /// The resolved user model that contains details of the user/org/integration/api_key used for branch creation. This field is filled only in listing/get/create/get/update/delete methods, if it is empty when calling other handlers, it does not mean that it is empty in the system.
        /// </param>
        /// <param name="initSource">
        /// The source of initialization for the branch. Valid values are `schema-only` and `parent-data` (default).<br/>
        ///   * `schema-only` - creates a new root branch containing only the schema. Use `parent_id` to specify the source branch. Optionally, you can provide `parent_lsn` or `parent_timestamp` to branch from a specific point in time or LSN. These fields define which branch to copy the schema from and at what point—they do not establish a parent-child relationship between the `parent_id` branch and the new schema-only branch.<br/>
        ///   * `parent-data` - creates the branch with both schema and data from the parent.
        /// </param>
        /// <param name="restoreStatus">
        /// Could be `restored`, `finalized` or `detaching`.<br/>
        /// A `restored` branch becomes permanently `finalized` when you call `finalizeRestoreBranch`<br/>
        /// A `restored` or `finalized` branch may begin `detaching` as a one-time performance optimisation, after which it will continue in its original state
        /// </param>
        /// <param name="restoredFrom">
        /// ID of the snapshot that was the restore source for this branch
        /// </param>
        /// <param name="restoredAs">
        /// ID of the target branch which was replaced when this branch was restored
        /// </param>
        /// <param name="restrictedActions">
        /// A list of actions that are currently restricted for this branch and the reason why.
        /// </param>
        /// <param name="recovery">
        /// Recovery information for a deleted branch. Only present when listing deleted branches<br/>
        /// with `include_deleted=true`.<br/>
        /// This is part of the Branch Recovery feature, which is in preview and not available to all users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Branch(
            string id,
            string projectId,
            string name,
            string currentState,
            global::System.DateTime stateChangedAt,
            string creationSource,
            bool @default,
            bool @protected,
            long cpuUsedSec,
            long computeTimeSeconds,
            long activeTimeSeconds,
            long writtenDataBytes,
            long dataTransferBytes,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? parentId,
            string? parentLsn,
            global::System.DateTime? parentTimestamp,
            string? pendingState,
            long? logicalSize,
            int? ttlIntervalSeconds,
            global::System.DateTime? expiresAt,
            global::System.DateTime? lastResetAt,
            global::Neon.BranchCreatedBy? createdBy,
            string? initSource,
            string? restoreStatus,
            string? restoredFrom,
            string? restoredAs,
            global::System.Collections.Generic.IList<global::Neon.BranchRestrictedAction>? restrictedActions,
            global::Neon.BranchRecoveryInfo? recovery)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ParentId = parentId;
            this.ParentLsn = parentLsn;
            this.ParentTimestamp = parentTimestamp;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CurrentState = currentState ?? throw new global::System.ArgumentNullException(nameof(currentState));
            this.PendingState = pendingState;
            this.StateChangedAt = stateChangedAt;
            this.LogicalSize = logicalSize;
            this.CreationSource = creationSource ?? throw new global::System.ArgumentNullException(nameof(creationSource));
            this.Default = @default;
            this.Protected = @protected;
            this.CpuUsedSec = cpuUsedSec;
            this.ComputeTimeSeconds = computeTimeSeconds;
            this.ActiveTimeSeconds = activeTimeSeconds;
            this.WrittenDataBytes = writtenDataBytes;
            this.DataTransferBytes = dataTransferBytes;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TtlIntervalSeconds = ttlIntervalSeconds;
            this.ExpiresAt = expiresAt;
            this.LastResetAt = lastResetAt;
            this.CreatedBy = createdBy;
            this.InitSource = initSource;
            this.RestoreStatus = restoreStatus;
            this.RestoredFrom = restoredFrom;
            this.RestoredAs = restoredAs;
            this.RestrictedActions = restrictedActions;
            this.Recovery = recovery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Branch" /> class.
        /// </summary>
        public Branch()
        {
        }
    }
}