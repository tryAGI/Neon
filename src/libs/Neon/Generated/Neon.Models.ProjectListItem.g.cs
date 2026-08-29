
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Essential data about the project. Full data is available at `GET /projects/{project_id}`.<br/>
    /// Example: {"active_time":750111,"branch_logical_size_limit":10,"branch_logical_size_limit_bytes":10485760,"cpu_used_sec":523011,"id":"spring-example-302709","owner_id":"629982cc-de05-43db-ae16-28f2399c4910","platform_id":"aws","region_id":"aws-us-east-2","name":"spring-example-302709","provisioner":"k8s-pod","pg_version":15,"proxy_host":"us-east-2.aws.neon.tech","store_passwords":true,"creation_source":"console","created_at":"2022-12-13T01:30:55Z","updated_at":"2022-12-13T01:30:55Z"}
    /// </summary>
    public sealed partial class ProjectListItem
    {
        /// <summary>
        /// The Neon project ID. Use as the `project_id` path parameter in other endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The cloud platform identifier. Currently, only AWS is supported, for which the identifier is `aws`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlatformId { get; set; }

        /// <summary>
        /// Cloud region where the project's Postgres compute and storage reside (for example, `aws-us-east-2`). Valid values are returned by `GET /regions`.<br/>
        /// Example: aws-us-east-2
        /// </summary>
        /// <example>aws-us-east-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegionId { get; set; }

        /// <summary>
        /// The project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: k8s-neonvm
        /// </summary>
        /// <example>k8s-neonvm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provisioner { get; set; }

        /// <summary>
        /// A collection of settings for a Neon endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_endpoint_settings")]
        public global::Neon.DefaultEndpointSettings? DefaultEndpointSettings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.ProjectSettingsData? Settings { get; set; }

        /// <summary>
        /// The major Postgres version number. Supported versions are `14`, `15`, `16`, `17`, and `18`. `19` is rolling out and is accepted only in regions where it is enabled; requesting it elsewhere returns an error.<br/>
        /// Default Value: 18<br/>
        /// Example: 18
        /// </summary>
        /// <example>18</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pg_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PgVersion { get; set; }

        /// <summary>
        /// The proxy host for the project. This value combines the `region_id`, the `platform_id`, and the Neon domain (`neon.tech`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyHost { get; set; }

        /// <summary>
        /// The logical size limit for a branch. The value is in MiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_logical_size_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BranchLogicalSizeLimit { get; set; }

        /// <summary>
        /// The logical size limit for a branch. The value is in B.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_logical_size_limit_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BranchLogicalSizeLimitBytes { get; set; }

        /// <summary>
        /// Whether or not passwords are stored for roles in the Neon project. Storing passwords facilitates access to Neon features that require authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_passwords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StorePasswords { get; set; }

        /// <summary>
        /// Control plane observed endpoints of this project being active this amount of wall-clock time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ActiveTime { get; set; }

        /// <summary>
        /// Deprecated. Use `compute_time_seconds` from `GET /projects/{project_id}` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_used_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CpuUsedSec { get; set; }

        /// <summary>
        /// A timestamp indicating when project maintenance begins. If set, the project is placed into maintenance mode at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintenance_starts_at")]
        public global::System.DateTime? MaintenanceStartsAt { get; set; }

        /// <summary>
        /// The project creation source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreationSource { get; set; }

        /// <summary>
        /// A timestamp indicating when the project was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the project was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The current space occupied by the project in Postgres storage, in bytes. Synthetic Postgres storage size combines the logical data size and Write-Ahead Log (WAL) size for all branches in a project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synthetic_storage_size")]
        public long? SyntheticStorageSize { get; set; }

        /// <summary>
        /// Deprecated. Use `consumption_period_end` from `GET /projects/{project_id}` instead. A timestamp indicating when the project quota resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota_reset_at")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.DateTime? QuotaResetAt { get; set; }

        /// <summary>
        /// ID of the organization that owns the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The most recent time when any endpoint of this project was active.<br/>
        /// Omitted when observed no activity for endpoints of this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_last_active_at")]
        public global::System.DateTime? ComputeLastActiveAt { get; set; }

        /// <summary>
        /// ID of the organization that owns the project. Project permissions are granted to organization members as configured by the organization's admins, independent of which member created the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Name of the organization that owns the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// The number of seconds to retain the shared history for all branches in this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_retention_seconds")]
        public int? HistoryRetentionSeconds { get; set; }

        /// <summary>
        /// A timestamp indicating when HIPAA was enabled for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaa_enabled_at")]
        public global::System.DateTime? HipaaEnabledAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the project was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// A timestamp indicating the project will be recoverable until this date and time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recoverable_until")]
        public global::System.DateTime? RecoverableUntil { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_project_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectPermissionLevelJsonConverter))]
        public global::Neon.ProjectPermissionLevel? EffectiveProjectPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The Neon project ID. Use as the `project_id` path parameter in other endpoints.
        /// </param>
        /// <param name="platformId">
        /// The cloud platform identifier. Currently, only AWS is supported, for which the identifier is `aws`.
        /// </param>
        /// <param name="regionId">
        /// Cloud region where the project's Postgres compute and storage reside (for example, `aws-us-east-2`). Valid values are returned by `GET /regions`.<br/>
        /// Example: aws-us-east-2
        /// </param>
        /// <param name="name">
        /// The project name
        /// </param>
        /// <param name="provisioner">
        /// Example: k8s-neonvm
        /// </param>
        /// <param name="pgVersion">
        /// The major Postgres version number. Supported versions are `14`, `15`, `16`, `17`, and `18`. `19` is rolling out and is accepted only in regions where it is enabled; requesting it elsewhere returns an error.<br/>
        /// Default Value: 18<br/>
        /// Example: 18
        /// </param>
        /// <param name="proxyHost">
        /// The proxy host for the project. This value combines the `region_id`, the `platform_id`, and the Neon domain (`neon.tech`).
        /// </param>
        /// <param name="branchLogicalSizeLimit">
        /// The logical size limit for a branch. The value is in MiB.
        /// </param>
        /// <param name="branchLogicalSizeLimitBytes">
        /// The logical size limit for a branch. The value is in B.
        /// </param>
        /// <param name="storePasswords">
        /// Whether or not passwords are stored for roles in the Neon project. Storing passwords facilitates access to Neon features that require authorization.
        /// </param>
        /// <param name="activeTime">
        /// Control plane observed endpoints of this project being active this amount of wall-clock time.
        /// </param>
        /// <param name="cpuUsedSec">
        /// Deprecated. Use `compute_time_seconds` from `GET /projects/{project_id}` instead.
        /// </param>
        /// <param name="creationSource">
        /// The project creation source
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the project was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the project was last updated
        /// </param>
        /// <param name="ownerId">
        /// ID of the organization that owns the project.
        /// </param>
        /// <param name="defaultEndpointSettings">
        /// A collection of settings for a Neon endpoint
        /// </param>
        /// <param name="settings"></param>
        /// <param name="maintenanceStartsAt">
        /// A timestamp indicating when project maintenance begins. If set, the project is placed into maintenance mode at this time.
        /// </param>
        /// <param name="syntheticStorageSize">
        /// The current space occupied by the project in Postgres storage, in bytes. Synthetic Postgres storage size combines the logical data size and Write-Ahead Log (WAL) size for all branches in a project.
        /// </param>
        /// <param name="computeLastActiveAt">
        /// The most recent time when any endpoint of this project was active.<br/>
        /// Omitted when observed no activity for endpoints of this project.
        /// </param>
        /// <param name="orgId">
        /// ID of the organization that owns the project. Project permissions are granted to organization members as configured by the organization's admins, independent of which member created the project.
        /// </param>
        /// <param name="orgName">
        /// Name of the organization that owns the project.
        /// </param>
        /// <param name="historyRetentionSeconds">
        /// The number of seconds to retain the shared history for all branches in this project.
        /// </param>
        /// <param name="hipaaEnabledAt">
        /// A timestamp indicating when HIPAA was enabled for this project
        /// </param>
        /// <param name="deletedAt">
        /// A timestamp indicating when the project was deleted
        /// </param>
        /// <param name="recoverableUntil">
        /// A timestamp indicating the project will be recoverable until this date and time.
        /// </param>
        /// <param name="effectiveProjectPermission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectListItem(
            string id,
            string platformId,
            string regionId,
            string name,
            string provisioner,
            int pgVersion,
            string proxyHost,
            long branchLogicalSizeLimit,
            long branchLogicalSizeLimitBytes,
            bool storePasswords,
            long activeTime,
            long cpuUsedSec,
            string creationSource,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string ownerId,
            global::Neon.DefaultEndpointSettings? defaultEndpointSettings,
            global::Neon.ProjectSettingsData? settings,
            global::System.DateTime? maintenanceStartsAt,
            long? syntheticStorageSize,
            global::System.DateTime? computeLastActiveAt,
            string? orgId,
            string? orgName,
            int? historyRetentionSeconds,
            global::System.DateTime? hipaaEnabledAt,
            global::System.DateTime? deletedAt,
            global::System.DateTime? recoverableUntil,
            global::Neon.ProjectPermissionLevel? effectiveProjectPermission)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PlatformId = platformId ?? throw new global::System.ArgumentNullException(nameof(platformId));
            this.RegionId = regionId ?? throw new global::System.ArgumentNullException(nameof(regionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provisioner = provisioner ?? throw new global::System.ArgumentNullException(nameof(provisioner));
            this.DefaultEndpointSettings = defaultEndpointSettings;
            this.Settings = settings;
            this.PgVersion = pgVersion;
            this.ProxyHost = proxyHost ?? throw new global::System.ArgumentNullException(nameof(proxyHost));
            this.BranchLogicalSizeLimit = branchLogicalSizeLimit;
            this.BranchLogicalSizeLimitBytes = branchLogicalSizeLimitBytes;
            this.StorePasswords = storePasswords;
            this.ActiveTime = activeTime;
            this.CpuUsedSec = cpuUsedSec;
            this.MaintenanceStartsAt = maintenanceStartsAt;
            this.CreationSource = creationSource ?? throw new global::System.ArgumentNullException(nameof(creationSource));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SyntheticStorageSize = syntheticStorageSize;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ComputeLastActiveAt = computeLastActiveAt;
            this.OrgId = orgId;
            this.OrgName = orgName;
            this.HistoryRetentionSeconds = historyRetentionSeconds;
            this.HipaaEnabledAt = hipaaEnabledAt;
            this.DeletedAt = deletedAt;
            this.RecoverableUntil = recoverableUntil;
            this.EffectiveProjectPermission = effectiveProjectPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectListItem" /> class.
        /// </summary>
        public ProjectListItem()
        {
        }

    }
}