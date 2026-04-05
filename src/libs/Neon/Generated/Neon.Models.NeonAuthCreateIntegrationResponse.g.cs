
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthCreateIntegrationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthProviderProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pub_client_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PubClientKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_server_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretServerKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// 
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
        /// <param name="authProvider"></param>
        /// <param name="authProviderProjectId"></param>
        /// <param name="pubClientKey"></param>
        /// <param name="secretServerKey"></param>
        /// <param name="jwksUrl"></param>
        /// <param name="schemaName"></param>
        /// <param name="tableName"></param>
        /// <param name="baseUrl"></param>
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