
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthCreateIntegrationResponse
    {
        /// <summary>
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// Project ID assigned by the auth provider for this integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthProviderProjectId { get; set; }

        /// <summary>
        /// Publishable SDK key from the auth provider. Populated only for Stack Auth (deprecated); empty for Better Auth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pub_client_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PubClientKey { get; set; }

        /// <summary>
        /// Secret server-side SDK key from the auth provider. Populated only for Stack Auth (deprecated); empty for Better Auth. Treat as a credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_server_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretServerKey { get; set; }

        /// <summary>
        /// URL of the provider's JWKS endpoint used to verify JWTs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUrl { get; set; }

        /// <summary>
        /// Postgres schema containing the auth integration tables. Defaults to `neon_auth`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// Postgres table in the integration schema where synced user records are stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// Base URL of the Neon Auth service for this integration. Set as the NEON_AUTH_BASE_URL environment variable in your application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthCreateIntegrationResponse" /> class.
        /// </summary>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
        /// <param name="authProviderProjectId">
        /// Project ID assigned by the auth provider for this integration.
        /// </param>
        /// <param name="pubClientKey">
        /// Publishable SDK key from the auth provider. Populated only for Stack Auth (deprecated); empty for Better Auth.
        /// </param>
        /// <param name="secretServerKey">
        /// Secret server-side SDK key from the auth provider. Populated only for Stack Auth (deprecated); empty for Better Auth. Treat as a credential.
        /// </param>
        /// <param name="jwksUrl">
        /// URL of the provider's JWKS endpoint used to verify JWTs.
        /// </param>
        /// <param name="schemaName">
        /// Postgres schema containing the auth integration tables. Defaults to `neon_auth`.
        /// </param>
        /// <param name="tableName">
        /// Postgres table in the integration schema where synced user records are stored.
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of the Neon Auth service for this integration. Set as the NEON_AUTH_BASE_URL environment variable in your application.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthCreateIntegrationResponse(
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            string authProviderProjectId,
            string pubClientKey,
            string secretServerKey,
            string jwksUrl,
            string schemaName,
            string tableName,
            string? baseUrl)
        {
            this.AuthProvider = authProvider;
            this.AuthProviderProjectId = authProviderProjectId ?? throw new global::System.ArgumentNullException(nameof(authProviderProjectId));
            this.PubClientKey = pubClientKey ?? throw new global::System.ArgumentNullException(nameof(pubClientKey));
            this.SecretServerKey = secretServerKey ?? throw new global::System.ArgumentNullException(nameof(secretServerKey));
            this.JwksUrl = jwksUrl ?? throw new global::System.ArgumentNullException(nameof(jwksUrl));
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.TableName = tableName ?? throw new global::System.ArgumentNullException(nameof(tableName));
            this.BaseUrl = baseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthCreateIntegrationResponse" /> class.
        /// </summary>
        public NeonAuthCreateIntegrationResponse()
        {
        }

    }
}