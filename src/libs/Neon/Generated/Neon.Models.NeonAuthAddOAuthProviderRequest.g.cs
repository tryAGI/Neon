
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthAddOAuthProviderRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOauthProviderIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthOauthProviderId Id { get; set; }

        /// <summary>
        /// The client ID issued by the OAuth provider for your application. Used to identify the application during the OAuth flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// OAuth client secret for the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Tenant ID for the Microsoft OAuth provider. Only relevant when the OAuth provider is Microsoft; omit or leave blank for other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_tenant_id")]
        public string? MicrosoftTenantId { get; set; }

        /// <summary>
        /// Apple Developer Team ID. Only relevant when the OAuth provider is Apple; omit for other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_team_id")]
        public string? AppleTeamId { get; set; }

        /// <summary>
        /// Key ID of the Sign in with Apple private key supplied in `client_secret`. Only relevant when the OAuth provider is Apple; omit for other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_key_id")]
        public string? AppleKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthAddOAuthProviderRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientId">
        /// The client ID issued by the OAuth provider for your application. Used to identify the application during the OAuth flow.
        /// </param>
        /// <param name="clientSecret">
        /// OAuth client secret for the provider.
        /// </param>
        /// <param name="microsoftTenantId">
        /// Tenant ID for the Microsoft OAuth provider. Only relevant when the OAuth provider is Microsoft; omit or leave blank for other providers.
        /// </param>
        /// <param name="appleTeamId">
        /// Apple Developer Team ID. Only relevant when the OAuth provider is Apple; omit for other providers.
        /// </param>
        /// <param name="appleKeyId">
        /// Key ID of the Sign in with Apple private key supplied in `client_secret`. Only relevant when the OAuth provider is Apple; omit for other providers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthAddOAuthProviderRequest(
            global::Neon.NeonAuthOauthProviderId id,
            string? clientId,
            string? clientSecret,
            string? microsoftTenantId,
            string? appleTeamId,
            string? appleKeyId)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.MicrosoftTenantId = microsoftTenantId;
            this.AppleTeamId = appleTeamId;
            this.AppleKeyId = appleKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthAddOAuthProviderRequest" /> class.
        /// </summary>
        public NeonAuthAddOAuthProviderRequest()
        {
        }

    }
}