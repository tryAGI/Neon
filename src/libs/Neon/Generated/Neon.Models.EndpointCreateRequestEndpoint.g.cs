
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointCreateRequestEndpoint
    {
        /// <summary>
        /// The ID of the branch the compute endpoint will be associated with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// The region where the compute endpoint will be created. Only the project's `region_id` is permitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public string? RegionId { get; set; }

        /// <summary>
        /// The compute endpoint type. Either `read_write` or `read_only`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.EndpointType Type { get; set; }

        /// <summary>
        /// A collection of settings for a compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.EndpointSettingsData? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_limit_min_cu")]
        public double? AutoscalingLimitMinCu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_limit_max_cu")]
        public double? AutoscalingLimitMaxCu { get; set; }

        /// <summary>
        /// The Neon compute provisioner.<br/>
        /// Specify the `k8s-neonvm` provisioner to create a compute endpoint that supports Autoscaling.<br/>
        /// Provisioner can be one of the following values:<br/>
        /// * k8s-pod<br/>
        /// * k8s-neonvm<br/>
        /// * serverless-platform<br/>
        /// Clients must expect, that any string value that is not documented in the description above should be treated as a error. UNKNOWN value if safe to treat as an error too.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioner")]
        public string? Provisioner { get; set; }

        /// <summary>
        /// Whether to enable connection pooling for the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_enabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PoolerEnabled { get; set; }

        /// <summary>
        /// The connection pooler mode. Neon supports PgBouncer in `transaction` mode only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointPoolerModeJsonConverter))]
        public global::Neon.EndpointPoolerMode? PoolerMode { get; set; }

        /// <summary>
        /// Whether to restrict connections to the compute endpoint.<br/>
        /// Enabling this option schedules a suspend compute operation.<br/>
        /// A disabled compute endpoint cannot be enabled by a connection or<br/>
        /// console action. However, the compute endpoint is periodically<br/>
        /// enabled by check_availability operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// NOT YET IMPLEMENTED. Whether to permit passwordless access to the compute endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordless_access")]
        public bool? PasswordlessAccess { get; set; }

        /// <summary>
        /// Duration of inactivity in seconds after which the compute endpoint is<br/>
        /// automatically suspended. The value `0` means use the default value.<br/>
        /// The value `-1` means never suspend. The default value is `300` seconds (5 minutes).<br/>
        /// The minimum value is `60` seconds (1 minute).<br/>
        /// The maximum value is `604800` seconds (1 week). For more information, see<br/>
        /// [Scale to zero configuration](https://neon.tech/docs/manage/endpoints#scale-to-zero-configuration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_timeout_seconds")]
        public long? SuspendTimeoutSeconds { get; set; }

        /// <summary>
        /// Optional name of the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointCreateRequestEndpoint" /> class.
        /// </summary>
        /// <param name="branchId">
        /// The ID of the branch the compute endpoint will be associated with
        /// </param>
        /// <param name="type">
        /// The compute endpoint type. Either `read_write` or `read_only`.
        /// </param>
        /// <param name="regionId">
        /// The region where the compute endpoint will be created. Only the project's `region_id` is permitted.
        /// </param>
        /// <param name="settings">
        /// A collection of settings for a compute endpoint
        /// </param>
        /// <param name="autoscalingLimitMinCu"></param>
        /// <param name="autoscalingLimitMaxCu"></param>
        /// <param name="provisioner">
        /// The Neon compute provisioner.<br/>
        /// Specify the `k8s-neonvm` provisioner to create a compute endpoint that supports Autoscaling.<br/>
        /// Provisioner can be one of the following values:<br/>
        /// * k8s-pod<br/>
        /// * k8s-neonvm<br/>
        /// * serverless-platform<br/>
        /// Clients must expect, that any string value that is not documented in the description above should be treated as a error. UNKNOWN value if safe to treat as an error too.
        /// </param>
        /// <param name="poolerMode">
        /// The connection pooler mode. Neon supports PgBouncer in `transaction` mode only.
        /// </param>
        /// <param name="disabled">
        /// Whether to restrict connections to the compute endpoint.<br/>
        /// Enabling this option schedules a suspend compute operation.<br/>
        /// A disabled compute endpoint cannot be enabled by a connection or<br/>
        /// console action. However, the compute endpoint is periodically<br/>
        /// enabled by check_availability operations.
        /// </param>
        /// <param name="passwordlessAccess">
        /// NOT YET IMPLEMENTED. Whether to permit passwordless access to the compute endpoint.
        /// </param>
        /// <param name="suspendTimeoutSeconds">
        /// Duration of inactivity in seconds after which the compute endpoint is<br/>
        /// automatically suspended. The value `0` means use the default value.<br/>
        /// The value `-1` means never suspend. The default value is `300` seconds (5 minutes).<br/>
        /// The minimum value is `60` seconds (1 minute).<br/>
        /// The maximum value is `604800` seconds (1 week). For more information, see<br/>
        /// [Scale to zero configuration](https://neon.tech/docs/manage/endpoints#scale-to-zero-configuration).
        /// </param>
        /// <param name="name">
        /// Optional name of the compute endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointCreateRequestEndpoint(
            string branchId,
            global::Neon.EndpointType type,
            string? regionId,
            global::Neon.EndpointSettingsData? settings,
            double? autoscalingLimitMinCu,
            double? autoscalingLimitMaxCu,
            string? provisioner,
            global::Neon.EndpointPoolerMode? poolerMode,
            bool? disabled,
            bool? passwordlessAccess,
            long? suspendTimeoutSeconds,
            string? name)
        {
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.RegionId = regionId;
            this.Type = type;
            this.Settings = settings;
            this.AutoscalingLimitMinCu = autoscalingLimitMinCu;
            this.AutoscalingLimitMaxCu = autoscalingLimitMaxCu;
            this.Provisioner = provisioner;
            this.PoolerMode = poolerMode;
            this.Disabled = disabled;
            this.PasswordlessAccess = passwordlessAccess;
            this.SuspendTimeoutSeconds = suspendTimeoutSeconds;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointCreateRequestEndpoint" /> class.
        /// </summary>
        public EndpointCreateRequestEndpoint()
        {
        }
    }
}