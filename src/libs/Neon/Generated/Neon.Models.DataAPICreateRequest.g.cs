
#nullable enable

namespace Neon
{
    /// <summary>
    /// Create Neon Data API
    /// </summary>
    public sealed partial class DataAPICreateRequest
    {
        /// <summary>
        /// The authentication provider to use for the Neon Data API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.DataAPICreateRequestAuthProviderJsonConverter))]
        public global::Neon.DataAPICreateRequestAuthProvider? AuthProvider { get; set; }

        /// <summary>
        /// The URL that lists the JWKS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        public string? JwksUrl { get; set; }

        /// <summary>
        /// The name of the authentication provider (e.g., Clerk, Stytch, Auth0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// WARNING - using this setting will only reject tokens with a<br/>
        /// different audience claim. Tokens without audience claim will still<br/>
        /// be accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_audience")]
        public string? JwtAudience { get; set; }

        /// <summary>
        /// Grant all permissions to the tables in the public schema to authenticated users<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_default_grants")]
        public bool? AddDefaultGrants { get; set; }

        /// <summary>
        /// Skip creating the auth schema and RLS functions<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_auth_schema")]
        public bool? SkipAuthSchema { get; set; }

        /// <summary>
        /// Configuration settings for the Neon Data API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.DataAPISettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPICreateRequest" /> class.
        /// </summary>
        /// <param name="authProvider">
        /// The authentication provider to use for the Neon Data API
        /// </param>
        /// <param name="jwksUrl">
        /// The URL that lists the JWKS
        /// </param>
        /// <param name="providerName">
        /// The name of the authentication provider (e.g., Clerk, Stytch, Auth0)
        /// </param>
        /// <param name="jwtAudience">
        /// WARNING - using this setting will only reject tokens with a<br/>
        /// different audience claim. Tokens without audience claim will still<br/>
        /// be accepted.
        /// </param>
        /// <param name="addDefaultGrants">
        /// Grant all permissions to the tables in the public schema to authenticated users<br/>
        /// Default Value: false
        /// </param>
        /// <param name="skipAuthSchema">
        /// Skip creating the auth schema and RLS functions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="settings">
        /// Configuration settings for the Neon Data API
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAPICreateRequest(
            global::Neon.DataAPICreateRequestAuthProvider? authProvider,
            string? jwksUrl,
            string? providerName,
            string? jwtAudience,
            bool? addDefaultGrants,
            bool? skipAuthSchema,
            global::Neon.DataAPISettings? settings)
        {
            this.AuthProvider = authProvider;
            this.JwksUrl = jwksUrl;
            this.ProviderName = providerName;
            this.JwtAudience = jwtAudience;
            this.AddDefaultGrants = addDefaultGrants;
            this.SkipAuthSchema = skipAuthSchema;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPICreateRequest" /> class.
        /// </summary>
        public DataAPICreateRequest()
        {
        }
    }
}