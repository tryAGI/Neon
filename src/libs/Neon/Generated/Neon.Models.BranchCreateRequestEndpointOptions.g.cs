
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchCreateRequestEndpointOptions
    {
        /// <summary>
        /// Compute endpoint type. `read_write`: the primary read-write endpoint (one per branch). `read_only`: a read replica endpoint (multiple allowed per branch).
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
        /// Example: k8s-neonvm
        /// </summary>
        /// <example>k8s-neonvm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioner")]
        public string? Provisioner { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreateRequestEndpointOptions" /> class.
        /// </summary>
        /// <param name="type">
        /// Compute endpoint type. `read_write`: the primary read-write endpoint (one per branch). `read_only`: a read replica endpoint (multiple allowed per branch).
        /// </param>
        /// <param name="settings">
        /// A collection of settings for a compute endpoint
        /// </param>
        /// <param name="autoscalingLimitMinCu"></param>
        /// <param name="autoscalingLimitMaxCu"></param>
        /// <param name="provisioner">
        /// Example: k8s-neonvm
        /// </param>
        /// <param name="suspendTimeoutSeconds">
        /// Duration of inactivity in seconds after which the compute endpoint is<br/>
        /// automatically suspended. The value `0` means use the default value.<br/>
        /// The value `-1` means never suspend. The default value is `300` seconds (5 minutes).<br/>
        /// The minimum value is `60` seconds (1 minute).<br/>
        /// The maximum value is `604800` seconds (1 week). For more information, see<br/>
        /// [Scale to zero configuration](https://neon.com/docs/manage/endpoints#scale-to-zero-configuration).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchCreateRequestEndpointOptions(
            global::Neon.EndpointType type,
            global::Neon.EndpointSettingsData? settings,
            double? autoscalingLimitMinCu,
            double? autoscalingLimitMaxCu,
            string? provisioner,
            long? suspendTimeoutSeconds)
        {
            this.Type = type;
            this.Settings = settings;
            this.AutoscalingLimitMinCu = autoscalingLimitMinCu;
            this.AutoscalingLimitMaxCu = autoscalingLimitMaxCu;
            this.Provisioner = provisioner;
            this.SuspendTimeoutSeconds = suspendTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreateRequestEndpointOptions" /> class.
        /// </summary>
        public BranchCreateRequestEndpointOptions()
        {
        }

    }
}