
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"host":"ep-silent-smoke-806639.us-east-2.aws.neon.tech","id":"ep-silent-smoke-806639","name":"My cool compute","project_id":"spring-example-302709","branch_id":"br-wispy-meadow-118737","autoscaling_limit_min_cu":1,"autoscaling_limit_max_cu":1,"region_id":"aws-us-east-2","type":"read_write","current_state":"init","pending_state":"active","settings":{"pg_settings":{}},"pooler_enabled":false,"pooler_mode":"transaction","disabled":false,"passwordless_access":true,"creation_source":"console","created_at":"2022-12-03T15:37:07Z","updated_at":"2022-12-03T15:37:07Z","proxy_host":"us-east-2.aws.neon.tech","suspend_timeout_seconds":0,"provisioner":"k8s-neonvm"}
    /// </summary>
    public sealed partial class Endpoint
    {
        /// <summary>
        /// The hostname of the compute endpoint. This is the hostname specified when connecting to a Neon database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// The compute endpoint ID. Compute endpoint IDs have an `ep-` prefix. For example: `ep-little-smoke-851426`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Optional name of the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the project to which the compute endpoint belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The ID of the branch that the compute endpoint is associated with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_limit_min_cu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AutoscalingLimitMinCu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_limit_max_cu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AutoscalingLimitMaxCu { get; set; }

        /// <summary>
        /// The region identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegionId { get; set; }

        /// <summary>
        /// The compute endpoint type. Either `read_write` or `read_only`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.EndpointType Type { get; set; }

        /// <summary>
        /// The state of the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.EndpointState CurrentState { get; set; }

        /// <summary>
        /// The state of the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointStateJsonConverter))]
        public global::Neon.EndpointState? PendingState { get; set; }

        /// <summary>
        /// A collection of settings for a compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.EndpointSettingsData Settings { get; set; }

        /// <summary>
        /// Whether connection pooling is enabled for the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PoolerEnabled { get; set; }

        /// <summary>
        /// The connection pooler mode. Neon supports PgBouncer in `transaction` mode only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointPoolerModeJsonConverter))]
        public global::Neon.EndpointPoolerMode PoolerMode { get; set; }

        /// <summary>
        /// Whether to restrict connections to the compute endpoint.<br/>
        /// Enabling this option schedules a suspend compute operation.<br/>
        /// A disabled compute endpoint cannot be enabled by a connection or<br/>
        /// console action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Whether to permit passwordless access to the compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordless_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PasswordlessAccess { get; set; }

        /// <summary>
        /// A timestamp indicating when the compute endpoint was last active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active")]
        public global::System.DateTime? LastActive { get; set; }

        /// <summary>
        /// The compute endpoint creation source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreationSource { get; set; }

        /// <summary>
        /// A timestamp indicating when the compute endpoint was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the compute endpoint was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the compute endpoint was last started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the compute endpoint was last suspended
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_at")]
        public global::System.DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// DEPRECATED. Use the "host" property instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyHost { get; set; }

        /// <summary>
        /// Duration of inactivity in seconds after which the compute endpoint is<br/>
        /// automatically suspended. The value `0` means use the default value.<br/>
        /// The value `-1` means never suspend. The default value is `300` seconds (5 minutes).<br/>
        /// The minimum value is `60` seconds (1 minute).<br/>
        /// The maximum value is `604800` seconds (1 week). For more information, see<br/>
        /// [Scale to zero configuration](https://neon.tech/docs/manage/endpoints#scale-to-zero-configuration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_timeout_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SuspendTimeoutSeconds { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provisioner { get; set; }

        /// <summary>
        /// Attached compute's release version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_release_version")]
        public string? ComputeReleaseVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="host">
        /// The hostname of the compute endpoint. This is the hostname specified when connecting to a Neon database.
        /// </param>
        /// <param name="id">
        /// The compute endpoint ID. Compute endpoint IDs have an `ep-` prefix. For example: `ep-little-smoke-851426`
        /// </param>
        /// <param name="projectId">
        /// The ID of the project to which the compute endpoint belongs
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch that the compute endpoint is associated with
        /// </param>
        /// <param name="autoscalingLimitMinCu"></param>
        /// <param name="autoscalingLimitMaxCu"></param>
        /// <param name="regionId">
        /// The region identifier
        /// </param>
        /// <param name="type">
        /// The compute endpoint type. Either `read_write` or `read_only`.
        /// </param>
        /// <param name="currentState">
        /// The state of the compute endpoint
        /// </param>
        /// <param name="settings">
        /// A collection of settings for a compute endpoint
        /// </param>
        /// <param name="poolerEnabled">
        /// Whether connection pooling is enabled for the compute endpoint
        /// </param>
        /// <param name="disabled">
        /// Whether to restrict connections to the compute endpoint.<br/>
        /// Enabling this option schedules a suspend compute operation.<br/>
        /// A disabled compute endpoint cannot be enabled by a connection or<br/>
        /// console action.
        /// </param>
        /// <param name="passwordlessAccess">
        /// Whether to permit passwordless access to the compute endpoint
        /// </param>
        /// <param name="creationSource">
        /// The compute endpoint creation source
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the compute endpoint was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the compute endpoint was last updated
        /// </param>
        /// <param name="proxyHost">
        /// DEPRECATED. Use the "host" property instead.
        /// </param>
        /// <param name="suspendTimeoutSeconds">
        /// Duration of inactivity in seconds after which the compute endpoint is<br/>
        /// automatically suspended. The value `0` means use the default value.<br/>
        /// The value `-1` means never suspend. The default value is `300` seconds (5 minutes).<br/>
        /// The minimum value is `60` seconds (1 minute).<br/>
        /// The maximum value is `604800` seconds (1 week). For more information, see<br/>
        /// [Scale to zero configuration](https://neon.tech/docs/manage/endpoints#scale-to-zero-configuration).
        /// </param>
        /// <param name="provisioner">
        /// The Neon compute provisioner.<br/>
        /// Specify the `k8s-neonvm` provisioner to create a compute endpoint that supports Autoscaling.<br/>
        /// Provisioner can be one of the following values:<br/>
        /// * k8s-pod<br/>
        /// * k8s-neonvm<br/>
        /// * serverless-platform<br/>
        /// Clients must expect, that any string value that is not documented in the description above should be treated as a error. UNKNOWN value if safe to treat as an error too.
        /// </param>
        /// <param name="name">
        /// Optional name of the compute endpoint
        /// </param>
        /// <param name="pendingState">
        /// The state of the compute endpoint
        /// </param>
        /// <param name="poolerMode">
        /// The connection pooler mode. Neon supports PgBouncer in `transaction` mode only.
        /// </param>
        /// <param name="lastActive">
        /// A timestamp indicating when the compute endpoint was last active
        /// </param>
        /// <param name="startedAt">
        /// A timestamp indicating when the compute endpoint was last started
        /// </param>
        /// <param name="suspendedAt">
        /// A timestamp indicating when the compute endpoint was last suspended
        /// </param>
        /// <param name="computeReleaseVersion">
        /// Attached compute's release version number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Endpoint(
            string host,
            string id,
            string projectId,
            string branchId,
            double autoscalingLimitMinCu,
            double autoscalingLimitMaxCu,
            string regionId,
            global::Neon.EndpointType type,
            global::Neon.EndpointState currentState,
            global::Neon.EndpointSettingsData settings,
            bool poolerEnabled,
            bool disabled,
            bool passwordlessAccess,
            string creationSource,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string proxyHost,
            long suspendTimeoutSeconds,
            string provisioner,
            string? name,
            global::Neon.EndpointState? pendingState,
            global::Neon.EndpointPoolerMode poolerMode,
            global::System.DateTime? lastActive,
            global::System.DateTime? startedAt,
            global::System.DateTime? suspendedAt,
            string? computeReleaseVersion)
        {
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.AutoscalingLimitMinCu = autoscalingLimitMinCu;
            this.AutoscalingLimitMaxCu = autoscalingLimitMaxCu;
            this.RegionId = regionId ?? throw new global::System.ArgumentNullException(nameof(regionId));
            this.Type = type;
            this.CurrentState = currentState;
            this.PendingState = pendingState;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.PoolerEnabled = poolerEnabled;
            this.PoolerMode = poolerMode;
            this.Disabled = disabled;
            this.PasswordlessAccess = passwordlessAccess;
            this.LastActive = lastActive;
            this.CreationSource = creationSource ?? throw new global::System.ArgumentNullException(nameof(creationSource));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.SuspendedAt = suspendedAt;
            this.ProxyHost = proxyHost ?? throw new global::System.ArgumentNullException(nameof(proxyHost));
            this.SuspendTimeoutSeconds = suspendTimeoutSeconds;
            this.Provisioner = provisioner ?? throw new global::System.ArgumentNullException(nameof(provisioner));
            this.ComputeReleaseVersion = computeReleaseVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        public Endpoint()
        {
        }
    }
}