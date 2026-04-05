
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Limits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ActiveTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBranches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_snapshots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSnapshots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_protected_branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxProtectedBranches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_autoscaling_cu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxAutoscalingCu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_fixed_size_cu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxFixedSizeCu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CpuSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_compute_time_non_primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxComputeTimeNonPrimary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActiveEndpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_read_only_endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReadOnlyEndpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_read_computes_per_branch")]
        public int? MaxReadComputesPerBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_allowed_ips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxAllowedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_vpc_endpoints_per_region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxVpcEndpointsPerRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_monitoring_retention_hours")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxMonitoringRetentionHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_history_retention_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxHistoryRetentionSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_autosuspend_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinAutosuspendSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_data_transfer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxDataTransfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_idle_seconds_to_autoarchive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MinIdleSecondsToAutoarchive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_age_seconds_to_autoarchive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MinAgeSecondsToAutoarchive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_branch_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBranchRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_branch_databases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBranchDatabases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_scheduled_operation_chains_per_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrentScheduledOperationChainsPerProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_executing_operation_chains_per_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrentExecutingOperationChainsPerProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_root_branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRootBranches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_import_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxImportSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_organization_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxOrganizationMembers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_only_branches_size_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SchemaOnlyBranchesSizeLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.LimitsPerProject PerProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Limits" /> class.
        /// </summary>
        /// <param name="activeTime"></param>
        /// <param name="maxProjects"></param>
        /// <param name="maxBranches"></param>
        /// <param name="maxSnapshots"></param>
        /// <param name="maxProtectedBranches"></param>
        /// <param name="maxAutoscalingCu"></param>
        /// <param name="maxFixedSizeCu"></param>
        /// <param name="cpuSeconds"></param>
        /// <param name="maxComputeTimeNonPrimary"></param>
        /// <param name="maxActiveEndpoints"></param>
        /// <param name="maxReadOnlyEndpoints"></param>
        /// <param name="maxAllowedIps"></param>
        /// <param name="maxVpcEndpointsPerRegion"></param>
        /// <param name="maxMonitoringRetentionHours"></param>
        /// <param name="maxHistoryRetentionSeconds"></param>
        /// <param name="minAutosuspendSeconds"></param>
        /// <param name="maxDataTransfer"></param>
        /// <param name="minIdleSecondsToAutoarchive"></param>
        /// <param name="minAgeSecondsToAutoarchive"></param>
        /// <param name="maxBranchRoles"></param>
        /// <param name="maxBranchDatabases"></param>
        /// <param name="maxConcurrentScheduledOperationChainsPerProject"></param>
        /// <param name="maxConcurrentExecutingOperationChainsPerProject"></param>
        /// <param name="maxRootBranches"></param>
        /// <param name="maxImportSize"></param>
        /// <param name="maxOrganizationMembers"></param>
        /// <param name="schemaOnlyBranchesSizeLimit"></param>
        /// <param name="perProject"></param>
        /// <param name="maxReadComputesPerBranch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Limits(
            long activeTime,
            int maxProjects,
            int maxBranches,
            int maxSnapshots,
            int maxProtectedBranches,
            double maxAutoscalingCu,
            double maxFixedSizeCu,
            long cpuSeconds,
            long maxComputeTimeNonPrimary,
            int maxActiveEndpoints,
            int maxReadOnlyEndpoints,
            int maxAllowedIps,
            int maxVpcEndpointsPerRegion,
            int maxMonitoringRetentionHours,
            int maxHistoryRetentionSeconds,
            int minAutosuspendSeconds,
            long maxDataTransfer,
            long minIdleSecondsToAutoarchive,
            long minAgeSecondsToAutoarchive,
            int maxBranchRoles,
            int maxBranchDatabases,
            int maxConcurrentScheduledOperationChainsPerProject,
            int maxConcurrentExecutingOperationChainsPerProject,
            int maxRootBranches,
            long maxImportSize,
            int maxOrganizationMembers,
            int schemaOnlyBranchesSizeLimit,
            global::Neon.LimitsPerProject perProject,
            int? maxReadComputesPerBranch)
        {
            this.ActiveTime = activeTime;
            this.MaxProjects = maxProjects;
            this.MaxBranches = maxBranches;
            this.MaxSnapshots = maxSnapshots;
            this.MaxProtectedBranches = maxProtectedBranches;
            this.MaxAutoscalingCu = maxAutoscalingCu;
            this.MaxFixedSizeCu = maxFixedSizeCu;
            this.CpuSeconds = cpuSeconds;
            this.MaxComputeTimeNonPrimary = maxComputeTimeNonPrimary;
            this.MaxActiveEndpoints = maxActiveEndpoints;
            this.MaxReadOnlyEndpoints = maxReadOnlyEndpoints;
            this.MaxReadComputesPerBranch = maxReadComputesPerBranch;
            this.MaxAllowedIps = maxAllowedIps;
            this.MaxVpcEndpointsPerRegion = maxVpcEndpointsPerRegion;
            this.MaxMonitoringRetentionHours = maxMonitoringRetentionHours;
            this.MaxHistoryRetentionSeconds = maxHistoryRetentionSeconds;
            this.MinAutosuspendSeconds = minAutosuspendSeconds;
            this.MaxDataTransfer = maxDataTransfer;
            this.MinIdleSecondsToAutoarchive = minIdleSecondsToAutoarchive;
            this.MinAgeSecondsToAutoarchive = minAgeSecondsToAutoarchive;
            this.MaxBranchRoles = maxBranchRoles;
            this.MaxBranchDatabases = maxBranchDatabases;
            this.MaxConcurrentScheduledOperationChainsPerProject = maxConcurrentScheduledOperationChainsPerProject;
            this.MaxConcurrentExecutingOperationChainsPerProject = maxConcurrentExecutingOperationChainsPerProject;
            this.MaxRootBranches = maxRootBranches;
            this.MaxImportSize = maxImportSize;
            this.MaxOrganizationMembers = maxOrganizationMembers;
            this.SchemaOnlyBranchesSizeLimit = schemaOnlyBranchesSizeLimit;
            this.PerProject = perProject ?? throw new global::System.ArgumentNullException(nameof(perProject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Limits" /> class.
        /// </summary>
        public Limits()
        {
        }
    }
}