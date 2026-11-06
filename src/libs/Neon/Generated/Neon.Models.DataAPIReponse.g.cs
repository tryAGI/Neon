
#nullable enable

namespace Neon
{
    /// <summary>
    /// Neon Data API response
    /// </summary>
    public sealed partial class DataAPIReponse
    {
        /// <summary>
        /// The URL of the Neon Data API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The status of the Neon Data API deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Configuration settings for the Data API (SubZero only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Neon.DataAPISettings? Settings { get; set; }

        /// <summary>
        /// List of available database schemas (SubZero only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_schemas")]
        public global::System.Collections.Generic.IList<string>? AvailableSchemas { get; set; }

        /// <summary>
        /// When `settings` and `available_schemas` were read from the database. While the<br/>
        /// compute is suspended they are served from that read, so a change made directly in<br/>
        /// the database since then shows up in the first response served while the compute is<br/>
        /// active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observed_at")]
        public global::System.DateTime? ObservedAt { get; set; }

        /// <summary>
        /// How this Data API verifies JWTs, as recorded by the last create that named a provider. `neon_auth` verifies Neon Auth tokens; `external` verifies tokens from a third-party identity provider via `jwks_url`. Absent when no provider is recorded: the Data API was created before providers were recorded, or it was created without naming one. Treat an absent value as unknown and fall back to the branch's Neon Auth state (`GET /projects/{project_id}/branches/{branch_id}/auth`). The value can differ from the current setup (for example, a JWKS added later), and it is also absent in responses served from the state cache while the compute is suspended. A child branch inherits its parent's Data API and reports the parent's provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.DataAPIReponseAuthProviderJsonConverter))]
        public global::Neon.DataAPIReponseAuthProvider? AuthProvider { get; set; }

        /// <summary>
        /// URL of the JWKS endpoint the Data API verifies JWTs against. Only set when `auth_provider` is `external`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        public string? JwksUrl { get; set; }

        /// <summary>
        /// Display name of the external authentication provider, as given at creation (for example "Clerk"). Only set when `auth_provider` is `external` and a name was given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Expected `aud` claim in incoming JWTs, as given at creation. Only set when `auth_provider` is `external` and an audience was given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_audience")]
        public string? JwtAudience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPIReponse" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the Neon Data API
        /// </param>
        /// <param name="status">
        /// The status of the Neon Data API deployment
        /// </param>
        /// <param name="settings">
        /// Configuration settings for the Data API (SubZero only)
        /// </param>
        /// <param name="availableSchemas">
        /// List of available database schemas (SubZero only)
        /// </param>
        /// <param name="observedAt">
        /// When `settings` and `available_schemas` were read from the database. While the<br/>
        /// compute is suspended they are served from that read, so a change made directly in<br/>
        /// the database since then shows up in the first response served while the compute is<br/>
        /// active.
        /// </param>
        /// <param name="authProvider">
        /// How this Data API verifies JWTs, as recorded by the last create that named a provider. `neon_auth` verifies Neon Auth tokens; `external` verifies tokens from a third-party identity provider via `jwks_url`. Absent when no provider is recorded: the Data API was created before providers were recorded, or it was created without naming one. Treat an absent value as unknown and fall back to the branch's Neon Auth state (`GET /projects/{project_id}/branches/{branch_id}/auth`). The value can differ from the current setup (for example, a JWKS added later), and it is also absent in responses served from the state cache while the compute is suspended. A child branch inherits its parent's Data API and reports the parent's provider.
        /// </param>
        /// <param name="jwksUrl">
        /// URL of the JWKS endpoint the Data API verifies JWTs against. Only set when `auth_provider` is `external`.
        /// </param>
        /// <param name="providerName">
        /// Display name of the external authentication provider, as given at creation (for example "Clerk"). Only set when `auth_provider` is `external` and a name was given.
        /// </param>
        /// <param name="jwtAudience">
        /// Expected `aud` claim in incoming JWTs, as given at creation. Only set when `auth_provider` is `external` and an audience was given.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAPIReponse(
            string url,
            string status,
            global::Neon.DataAPISettings? settings,
            global::System.Collections.Generic.IList<string>? availableSchemas,
            global::System.DateTime? observedAt,
            global::Neon.DataAPIReponseAuthProvider? authProvider,
            string? jwksUrl,
            string? providerName,
            string? jwtAudience)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Settings = settings;
            this.AvailableSchemas = availableSchemas;
            this.ObservedAt = observedAt;
            this.AuthProvider = authProvider;
            this.JwksUrl = jwksUrl;
            this.ProviderName = providerName;
            this.JwtAudience = jwtAudience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPIReponse" /> class.
        /// </summary>
        public DataAPIReponse()
        {
        }

    }
}