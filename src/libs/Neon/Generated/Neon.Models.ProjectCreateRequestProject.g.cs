
#nullable enable

namespace Neon
{
    /// <summary>
    /// Configuration for the new project, including name, region, and Postgres compute and storage settings.
    /// </summary>
    public sealed partial class ProjectCreateRequestProject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.ProjectSettingsData? Settings { get; set; }

        /// <summary>
        /// The project name. If not specified, the name will be identical to the generated project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Configuration for the initial branch created with the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public global::Neon.ProjectCreateRequestProjectBranch? Branch { get; set; }

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
        /// The region identifier. Refer to our [Regions](https://neon.com/docs/introduction/regions) documentation for supported regions. Values are specified in this format: `aws-us-east-1`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public string? RegionId { get; set; }

        /// <summary>
        /// A collection of settings for a Neon endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_endpoint_settings")]
        public global::Neon.DefaultEndpointSettings? DefaultEndpointSettings { get; set; }

        /// <summary>
        /// The major Postgres version number. Supported versions are `14`, `15`, `16`, `17`, and `18`. `19` is rolling out and is accepted only in regions where it is enabled; requesting it elsewhere returns an error.<br/>
        /// Default Value: 18<br/>
        /// Example: 18
        /// </summary>
        /// <example>18</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pg_version")]
        public int? PgVersion { get; set; }

        /// <summary>
        /// Whether or not passwords are stored for roles in the Neon project. Storing passwords facilitates access to Neon features that require authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_passwords")]
        public bool? StorePasswords { get; set; }

        /// <summary>
        /// History window (point-in-time restore range) for all branches, in seconds. `0` disables it. Default 1 day (Free: 6 hours). Maximum depends on plan: Free 6 hours (21600), Launch 7 days (604800), Scale 30 days (2592000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_retention_seconds")]
        public int? HistoryRetentionSeconds { get; set; }

        /// <summary>
        /// ID of the organization that will own the project. If omitted when using an organization API key, it is inferred from the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequestProject" /> class.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="name">
        /// The project name. If not specified, the name will be identical to the generated project ID
        /// </param>
        /// <param name="branch">
        /// Configuration for the initial branch created with the project.
        /// </param>
        /// <param name="autoscalingLimitMinCu"></param>
        /// <param name="autoscalingLimitMaxCu"></param>
        /// <param name="provisioner">
        /// Example: k8s-neonvm
        /// </param>
        /// <param name="regionId">
        /// The region identifier. Refer to our [Regions](https://neon.com/docs/introduction/regions) documentation for supported regions. Values are specified in this format: `aws-us-east-1`
        /// </param>
        /// <param name="defaultEndpointSettings">
        /// A collection of settings for a Neon endpoint
        /// </param>
        /// <param name="pgVersion">
        /// The major Postgres version number. Supported versions are `14`, `15`, `16`, `17`, and `18`. `19` is rolling out and is accepted only in regions where it is enabled; requesting it elsewhere returns an error.<br/>
        /// Default Value: 18<br/>
        /// Example: 18
        /// </param>
        /// <param name="storePasswords">
        /// Whether or not passwords are stored for roles in the Neon project. Storing passwords facilitates access to Neon features that require authorization.
        /// </param>
        /// <param name="historyRetentionSeconds">
        /// History window (point-in-time restore range) for all branches, in seconds. `0` disables it. Default 1 day (Free: 6 hours). Maximum depends on plan: Free 6 hours (21600), Launch 7 days (604800), Scale 30 days (2592000).
        /// </param>
        /// <param name="orgId">
        /// ID of the organization that will own the project. If omitted when using an organization API key, it is inferred from the key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCreateRequestProject(
            global::Neon.ProjectSettingsData? settings,
            string? name,
            global::Neon.ProjectCreateRequestProjectBranch? branch,
            double? autoscalingLimitMinCu,
            double? autoscalingLimitMaxCu,
            string? provisioner,
            string? regionId,
            global::Neon.DefaultEndpointSettings? defaultEndpointSettings,
            int? pgVersion,
            bool? storePasswords,
            int? historyRetentionSeconds,
            string? orgId)
        {
            this.Settings = settings;
            this.Name = name;
            this.Branch = branch;
            this.AutoscalingLimitMinCu = autoscalingLimitMinCu;
            this.AutoscalingLimitMaxCu = autoscalingLimitMaxCu;
            this.Provisioner = provisioner;
            this.RegionId = regionId;
            this.DefaultEndpointSettings = defaultEndpointSettings;
            this.PgVersion = pgVersion;
            this.StorePasswords = storePasswords;
            this.HistoryRetentionSeconds = historyRetentionSeconds;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequestProject" /> class.
        /// </summary>
        public ProjectCreateRequestProject()
        {
        }

    }
}