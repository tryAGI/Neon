
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
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
        /// 
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
        /// The region identifier. Refer to our [Regions](https://neon.tech/docs/introduction/regions) documentation for supported regions. Values are specified in this format: `aws-us-east-1`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public string? RegionId { get; set; }

        /// <summary>
        /// A collection of settings for a Neon endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_endpoint_settings")]
        public global::Neon.DefaultEndpointSettings? DefaultEndpointSettings { get; set; }

        /// <summary>
        /// The major Postgres version number. Currently supported versions are `14`, `15`, `16`, `17`, and `18`.<br/>
        /// Default Value: 17
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pg_version")]
        public int? PgVersion { get; set; }

        /// <summary>
        /// Whether or not passwords are stored for roles in the Neon project. Storing passwords facilitates access to Neon features that require authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_passwords")]
        public bool? StorePasswords { get; set; }

        /// <summary>
        /// The number of seconds to retain the shared history for all branches in this project.<br/>
        /// The default is 1 day (86400 seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_retention_seconds")]
        public int? HistoryRetentionSeconds { get; set; }

        /// <summary>
        /// Organization id in case the project created belongs to an organization.<br/>
        /// If not present, project is owned by a user and not by org.
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
        /// <param name="branch"></param>
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
        /// <param name="regionId">
        /// The region identifier. Refer to our [Regions](https://neon.tech/docs/introduction/regions) documentation for supported regions. Values are specified in this format: `aws-us-east-1`
        /// </param>
        /// <param name="defaultEndpointSettings">
        /// A collection of settings for a Neon endpoint
        /// </param>
        /// <param name="pgVersion">
        /// The major Postgres version number. Currently supported versions are `14`, `15`, `16`, `17`, and `18`.<br/>
        /// Default Value: 17
        /// </param>
        /// <param name="storePasswords">
        /// Whether or not passwords are stored for roles in the Neon project. Storing passwords facilitates access to Neon features that require authorization.
        /// </param>
        /// <param name="historyRetentionSeconds">
        /// The number of seconds to retain the shared history for all branches in this project.<br/>
        /// The default is 1 day (86400 seconds).
        /// </param>
        /// <param name="orgId">
        /// Organization id in case the project created belongs to an organization.<br/>
        /// If not present, project is owned by a user and not by org.
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