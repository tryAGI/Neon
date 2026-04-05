
#nullable enable

namespace Neon
{
    /// <summary>
    /// Configuration settings for the Neon Data API
    /// </summary>
    public sealed partial class DataAPISettings
    {
        /// <summary>
        /// Enable aggregates feature<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_aggregates_enabled")]
        public bool? DbAggregatesEnabled { get; set; }

        /// <summary>
        /// Database role to use for anonymous requests<br/>
        /// Default Value: anonymous
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_anon_role")]
        public string? DbAnonRole { get; set; }

        /// <summary>
        /// Extra schemas to add to the search path
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_extra_search_path")]
        public string? DbExtraSearchPath { get; set; }

        /// <summary>
        /// Maximum number of rows that can be returned in a single request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_max_rows")]
        public int? DbMaxRows { get; set; }

        /// <summary>
        /// List of schemas to expose via the API. Default: ["public"]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_schemas")]
        public global::System.Collections.Generic.IList<string>? DbSchemas { get; set; }

        /// <summary>
        /// JWT claim key to use for role extraction<br/>
        /// Default Value: ."role"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_role_claim_key")]
        public string? JwtRoleClaimKey { get; set; }

        /// <summary>
        /// Maximum lifetime for JWT cache in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_cache_max_lifetime")]
        public int? JwtCacheMaxLifetime { get; set; }

        /// <summary>
        /// OpenAPI specification mode (ignore-privileges, disabled)<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi_mode")]
        public string? OpenapiMode { get; set; }

        /// <summary>
        /// CORS allowed origins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_cors_allowed_origins")]
        public string? ServerCorsAllowedOrigins { get; set; }

        /// <summary>
        /// Enable server timing headers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_timing_enabled")]
        public bool? ServerTimingEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPISettings" /> class.
        /// </summary>
        /// <param name="dbAggregatesEnabled">
        /// Enable aggregates feature<br/>
        /// Default Value: true
        /// </param>
        /// <param name="dbAnonRole">
        /// Database role to use for anonymous requests<br/>
        /// Default Value: anonymous
        /// </param>
        /// <param name="dbExtraSearchPath">
        /// Extra schemas to add to the search path
        /// </param>
        /// <param name="dbMaxRows">
        /// Maximum number of rows that can be returned in a single request
        /// </param>
        /// <param name="dbSchemas">
        /// List of schemas to expose via the API. Default: ["public"]
        /// </param>
        /// <param name="jwtRoleClaimKey">
        /// JWT claim key to use for role extraction<br/>
        /// Default Value: ."role"
        /// </param>
        /// <param name="jwtCacheMaxLifetime">
        /// Maximum lifetime for JWT cache in seconds
        /// </param>
        /// <param name="openapiMode">
        /// OpenAPI specification mode (ignore-privileges, disabled)<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="serverCorsAllowedOrigins">
        /// CORS allowed origins
        /// </param>
        /// <param name="serverTimingEnabled">
        /// Enable server timing headers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAPISettings(
            bool? dbAggregatesEnabled,
            string? dbAnonRole,
            string? dbExtraSearchPath,
            int? dbMaxRows,
            global::System.Collections.Generic.IList<string>? dbSchemas,
            string? jwtRoleClaimKey,
            int? jwtCacheMaxLifetime,
            string? openapiMode,
            string? serverCorsAllowedOrigins,
            bool? serverTimingEnabled)
        {
            this.DbAggregatesEnabled = dbAggregatesEnabled;
            this.DbAnonRole = dbAnonRole;
            this.DbExtraSearchPath = dbExtraSearchPath;
            this.DbMaxRows = dbMaxRows;
            this.DbSchemas = dbSchemas;
            this.JwtRoleClaimKey = jwtRoleClaimKey;
            this.JwtCacheMaxLifetime = jwtCacheMaxLifetime;
            this.OpenapiMode = openapiMode;
            this.ServerCorsAllowedOrigins = serverCorsAllowedOrigins;
            this.ServerTimingEnabled = serverTimingEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPISettings" /> class.
        /// </summary>
        public DataAPISettings()
        {
        }
    }
}