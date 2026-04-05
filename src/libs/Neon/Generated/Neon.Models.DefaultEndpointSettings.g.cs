
#nullable enable

namespace Neon
{
    /// <summary>
    /// A collection of settings for a Neon endpoint
    /// </summary>
    public sealed partial class DefaultEndpointSettings
    {
        /// <summary>
        /// A raw representation of Postgres settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pg_settings")]
        public global::System.Collections.Generic.Dictionary<string, string>? PgSettings { get; set; }

        /// <summary>
        /// A raw representation of PgBouncer settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pgbouncer_settings")]
        public global::System.Collections.Generic.Dictionary<string, string>? PgbouncerSettings { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultEndpointSettings" /> class.
        /// </summary>
        /// <param name="pgSettings">
        /// A raw representation of Postgres settings
        /// </param>
        /// <param name="pgbouncerSettings">
        /// A raw representation of PgBouncer settings
        /// </param>
        /// <param name="autoscalingLimitMinCu"></param>
        /// <param name="autoscalingLimitMaxCu"></param>
        /// <param name="suspendTimeoutSeconds">
        /// Duration of inactivity in seconds after which the compute endpoint is<br/>
        /// automatically suspended. The value `0` means use the default value.<br/>
        /// The value `-1` means never suspend. The default value is `300` seconds (5 minutes).<br/>
        /// The minimum value is `60` seconds (1 minute).<br/>
        /// The maximum value is `604800` seconds (1 week). For more information, see<br/>
        /// [Scale to zero configuration](https://neon.tech/docs/manage/endpoints#scale-to-zero-configuration).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultEndpointSettings(
            global::System.Collections.Generic.Dictionary<string, string>? pgSettings,
            global::System.Collections.Generic.Dictionary<string, string>? pgbouncerSettings,
            double? autoscalingLimitMinCu,
            double? autoscalingLimitMaxCu,
            long? suspendTimeoutSeconds)
        {
            this.PgSettings = pgSettings;
            this.PgbouncerSettings = pgbouncerSettings;
            this.AutoscalingLimitMinCu = autoscalingLimitMinCu;
            this.AutoscalingLimitMaxCu = autoscalingLimitMaxCu;
            this.SuspendTimeoutSeconds = suspendTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultEndpointSettings" /> class.
        /// </summary>
        public DefaultEndpointSettings()
        {
        }
    }
}