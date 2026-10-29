
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOauthProvider
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOauthProviderIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthOauthProviderId Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOauthProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthOauthProviderType Type { get; set; }

        /// <summary>
        /// Public identifier for the OAuth application, issued by the provider when the application is registered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Masked OAuth client secret for the provider. For `apple`, a masked fingerprint of the Sign in with Apple `.p8` private key; the key itself is never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Tenant ID of the Microsoft OAuth provider. Present only for the Microsoft OAuth provider when a tenant is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_tenant_id")]
        public string? MicrosoftTenantId { get; set; }

        /// <summary>
        /// Apple Developer Team ID. Present only for the Apple OAuth provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_team_id")]
        public string? AppleTeamId { get; set; }

        /// <summary>
        /// Key ID of the Sign in with Apple private key. Present only for the Apple OAuth provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_key_id")]
        public string? AppleKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOauthProvider" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="clientId">
        /// Public identifier for the OAuth application, issued by the provider when the application is registered.
        /// </param>
        /// <param name="clientSecret">
        /// Masked OAuth client secret for the provider. For `apple`, a masked fingerprint of the Sign in with Apple `.p8` private key; the key itself is never returned.
        /// </param>
        /// <param name="microsoftTenantId">
        /// Tenant ID of the Microsoft OAuth provider. Present only for the Microsoft OAuth provider when a tenant is configured.
        /// </param>
        /// <param name="appleTeamId">
        /// Apple Developer Team ID. Present only for the Apple OAuth provider.
        /// </param>
        /// <param name="appleKeyId">
        /// Key ID of the Sign in with Apple private key. Present only for the Apple OAuth provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOauthProvider(
            global::Neon.NeonAuthOauthProviderId id,
            global::Neon.NeonAuthOauthProviderType type,
            string? clientId,
            string? clientSecret,
            string? microsoftTenantId,
            string? appleTeamId,
            string? appleKeyId)
        {
            this.Id = id;
            this.Type = type;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.MicrosoftTenantId = microsoftTenantId;
            this.AppleTeamId = appleTeamId;
            this.AppleKeyId = appleKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOauthProvider" /> class.
        /// </summary>
        public NeonAuthOauthProvider()
        {
        }

    }
}