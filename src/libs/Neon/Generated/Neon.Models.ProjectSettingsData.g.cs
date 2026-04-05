
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSettingsData
    {
        /// <summary>
        /// Per-project consumption quotas. If a quota is exceeded, all active computes<br/>
        /// are automatically suspended and cannot be started via API calls or incoming connections.<br/>
        /// The exception is `logical_size_bytes`, which is enforced per branch.<br/>
        /// If a branch exceeds its `logical_size_bytes` quota, computes can still be started,<br/>
        /// but write operations will fail—allowing data to be deleted to free up space.<br/>
        /// Computes on other branches are not affected.<br/>
        /// Setting `logical_size_bytes` overrides any lower value set by the `neon.max_cluster_size` Postgres setting.<br/>
        /// Quotas are enforced using per-project consumption metrics with the same names.<br/>
        /// These metrics reset at the start of each billing period. `logical_size_bytes`<br/>
        /// is also an exception—it reflects the total data stored in a branch and does not reset.<br/>
        /// A zero or empty quota value means “unlimited.”
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        public global::Neon.ProjectQuota? Quota { get; set; }

        /// <summary>
        /// A list of IP addresses that are allowed to connect to the compute endpoint.<br/>
        /// If the list is empty or not set, all IP addresses are allowed.<br/>
        /// If protected_branches_only is true, the list will be applied only to protected branches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_ips")]
        public global::Neon.AllowedIps? AllowedIps { get; set; }

        /// <summary>
        /// Sets wal_level=logical for all compute endpoints in this project.<br/>
        /// All active endpoints will be suspended.<br/>
        /// Once enabled, logical replication cannot be disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_logical_replication")]
        public bool? EnableLogicalReplication { get; set; }

        /// <summary>
        /// A maintenance window is a time period during which Neon may perform maintenance on the project's infrastructure.<br/>
        /// During this time, the project's compute endpoints may be unavailable and existing connections can be<br/>
        /// interrupted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintenance_window")]
        public global::Neon.MaintenanceWindow? MaintenanceWindow { get; set; }

        /// <summary>
        /// When set, connections from the public internet<br/>
        /// are disallowed. This supersedes the AllowedIPs list.<br/>
        /// This parameter is under active development and its semantics may change in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_public_connections")]
        public bool? BlockPublicConnections { get; set; }

        /// <summary>
        /// When set, connections using VPC endpoints are disallowed.<br/>
        /// This parameter is under active development and its semantics may change in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_vpc_connections")]
        public bool? BlockVpcConnections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audit_log_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.ProjectAuditLogLevelJsonConverter))]
        public global::Neon.ProjectAuditLogLevel? AuditLogLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hipaa")]
        public bool? Hipaa { get; set; }

        /// <summary>
        /// The shared libraries to preload into the project's compute instances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preload_libraries")]
        public global::Neon.PreloadLibraries? PreloadLibraries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsData" /> class.
        /// </summary>
        /// <param name="quota">
        /// Per-project consumption quotas. If a quota is exceeded, all active computes<br/>
        /// are automatically suspended and cannot be started via API calls or incoming connections.<br/>
        /// The exception is `logical_size_bytes`, which is enforced per branch.<br/>
        /// If a branch exceeds its `logical_size_bytes` quota, computes can still be started,<br/>
        /// but write operations will fail—allowing data to be deleted to free up space.<br/>
        /// Computes on other branches are not affected.<br/>
        /// Setting `logical_size_bytes` overrides any lower value set by the `neon.max_cluster_size` Postgres setting.<br/>
        /// Quotas are enforced using per-project consumption metrics with the same names.<br/>
        /// These metrics reset at the start of each billing period. `logical_size_bytes`<br/>
        /// is also an exception—it reflects the total data stored in a branch and does not reset.<br/>
        /// A zero or empty quota value means “unlimited.”
        /// </param>
        /// <param name="allowedIps">
        /// A list of IP addresses that are allowed to connect to the compute endpoint.<br/>
        /// If the list is empty or not set, all IP addresses are allowed.<br/>
        /// If protected_branches_only is true, the list will be applied only to protected branches.
        /// </param>
        /// <param name="enableLogicalReplication">
        /// Sets wal_level=logical for all compute endpoints in this project.<br/>
        /// All active endpoints will be suspended.<br/>
        /// Once enabled, logical replication cannot be disabled.
        /// </param>
        /// <param name="maintenanceWindow">
        /// A maintenance window is a time period during which Neon may perform maintenance on the project's infrastructure.<br/>
        /// During this time, the project's compute endpoints may be unavailable and existing connections can be<br/>
        /// interrupted.
        /// </param>
        /// <param name="blockPublicConnections">
        /// When set, connections from the public internet<br/>
        /// are disallowed. This supersedes the AllowedIPs list.<br/>
        /// This parameter is under active development and its semantics may change in the future.
        /// </param>
        /// <param name="blockVpcConnections">
        /// When set, connections using VPC endpoints are disallowed.<br/>
        /// This parameter is under active development and its semantics may change in the future.
        /// </param>
        /// <param name="auditLogLevel"></param>
        /// <param name="hipaa"></param>
        /// <param name="preloadLibraries">
        /// The shared libraries to preload into the project's compute instances.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettingsData(
            global::Neon.ProjectQuota? quota,
            global::Neon.AllowedIps? allowedIps,
            bool? enableLogicalReplication,
            global::Neon.MaintenanceWindow? maintenanceWindow,
            bool? blockPublicConnections,
            bool? blockVpcConnections,
            global::Neon.ProjectAuditLogLevel? auditLogLevel,
            bool? hipaa,
            global::Neon.PreloadLibraries? preloadLibraries)
        {
            this.Quota = quota;
            this.AllowedIps = allowedIps;
            this.EnableLogicalReplication = enableLogicalReplication;
            this.MaintenanceWindow = maintenanceWindow;
            this.BlockPublicConnections = blockPublicConnections;
            this.BlockVpcConnections = blockVpcConnections;
            this.AuditLogLevel = auditLogLevel;
            this.Hipaa = hipaa;
            this.PreloadLibraries = preloadLibraries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsData" /> class.
        /// </summary>
        public ProjectSettingsData()
        {
        }
    }
}