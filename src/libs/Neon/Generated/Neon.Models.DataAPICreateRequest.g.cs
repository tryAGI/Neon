
#nullable enable

namespace Neon
{
    /// <summary>
    /// Create Neon Data API
    /// </summary>
    public sealed partial class DataAPICreateRequest
    {
        /// <summary>
        /// Authentication provider for the Neon Data API. `neon_auth`: use Neon's built-in managed authentication (no JWKS configuration required). `external`: use an external JWT provider, which requires `jwks_url`. When omitted, no auth provider is configured (existing setup is kept).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.DataAPICreateRequestAuthProviderJsonConverter))]
        public global::Neon.DataAPICreateRequestAuthProvider? AuthProvider { get; set; }

        /// <summary>
        /// URL of the JWKS endpoint used to verify JWTs for this Data API. Required when configuring JWT-based authentication; omit when using a non-JWT auth provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        public string? JwksUrl { get; set; }

        /// <summary>
        /// Display name for the authentication provider. Accepted values include "Clerk", "Stytch", and "Auth0", but any non-empty string is valid. Optional field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Expected `aud` claim in incoming JWTs. When set, tokens with a different audience are rejected; tokens with no audience are still accepted. Omit to skip audience validation.
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
        /// Authentication provider for the Neon Data API. `neon_auth`: use Neon's built-in managed authentication (no JWKS configuration required). `external`: use an external JWT provider, which requires `jwks_url`. When omitted, no auth provider is configured (existing setup is kept).
        /// </param>
        /// <param name="jwksUrl">
        /// URL of the JWKS endpoint used to verify JWTs for this Data API. Required when configuring JWT-based authentication; omit when using a non-JWT auth provider.
        /// </param>
        /// <param name="providerName">
        /// Display name for the authentication provider. Accepted values include "Clerk", "Stytch", and "Auth0", but any non-empty string is valid. Optional field.
        /// </param>
        /// <param name="jwtAudience">
        /// Expected `aud` claim in incoming JWTs. When set, tokens with a different audience are rejected; tokens with no audience are still accepted. Omit to skip audience validation.
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