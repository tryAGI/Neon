
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Neon
{
    /// <summary>
    /// Parameters for the compute endpoint update.
    /// </summary>
    public sealed partial class EndpointUpdateRequestEndpoint
    {
        /// <summary>
        /// Deprecated. The destination branch ID; must not have an existing read-write endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? BranchId { get; set; }

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
        /// Example: k8s-neonvm
        /// </summary>
        /// <example>k8s-neonvm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioner")]
        public string? Provisioner { get; set; }

        /// <summary>
        /// A collection of settings for a compute endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.EndpointSettingsData? Settings { get; set; }

        /// <summary>
        /// Deprecated. To enable connection pooling, append `-pooler` to the endpoint ID in the connection string.<br/>
        /// See [How to use connection pooling](https://neon.com/docs/connect/connection-pooling#how-to-use-connection-pooling)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_enabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PoolerEnabled { get; set; }

        /// <summary>
        /// Deprecated. The connection pooler mode. Neon supports PgBouncer in `transaction` mode only. Removal scheduled for June 20, 2026.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pooler_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.EndpointPoolerModeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// [Scale to zero configuration](https://neon.com/docs/manage/endpoints#scale-to-zero-configuration).
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
        /// Initializes a new instance of the <see cref="EndpointUpdateRequestEndpoint" /> class.
        /// </summary>
        /// <param name="autoscalingLimitMinCu"></param>
        /// <param name="autoscalingLimitMaxCu"></param>
        /// <param name="provisioner">
        /// Example: k8s-neonvm
        /// </param>
        /// <param name="settings">
        /// A collection of settings for a compute endpoint
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
        /// [Scale to zero configuration](https://neon.com/docs/manage/endpoints#scale-to-zero-configuration).
        /// </param>
        /// <param name="name">
        /// Optional name of the compute endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointUpdateRequestEndpoint(
            double? autoscalingLimitMinCu,
            double? autoscalingLimitMaxCu,
            string? provisioner,
            global::Neon.EndpointSettingsData? settings,
            bool? disabled,
            bool? passwordlessAccess,
            long? suspendTimeoutSeconds,
            string? name)
        {
            this.AutoscalingLimitMinCu = autoscalingLimitMinCu;
            this.AutoscalingLimitMaxCu = autoscalingLimitMaxCu;
            this.Provisioner = provisioner;
            this.Settings = settings;
            this.Disabled = disabled;
            this.PasswordlessAccess = passwordlessAccess;
            this.SuspendTimeoutSeconds = suspendTimeoutSeconds;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointUpdateRequestEndpoint" /> class.
        /// </summary>
        public EndpointUpdateRequestEndpoint()
        {
        }

    }
}