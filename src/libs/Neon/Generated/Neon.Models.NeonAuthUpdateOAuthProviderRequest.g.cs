
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthUpdateOAuthProviderRequest
    {
        /// <summary>
        /// The OAuth client ID registered with the provider. Omit to keep the currently configured value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// OAuth client secret for the provider. Omit to leave the existing secret unchanged.<br/>
        /// For `apple`, a new `.p8` private key must be sent together with its `apple_key_id` in the same request; omit both to keep the stored key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The tenant ID scoping the Microsoft OAuth provider. Supply this field when the provider type is microsoft; it has no effect for other provider types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_tenant_id")]
        public string? MicrosoftTenantId { get; set; }

        /// <summary>
        /// Apple Developer Team ID. Supply this field when the provider is apple; it has no effect for other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_team_id")]
        public string? AppleTeamId { get; set; }

        /// <summary>
        /// Key ID of the Sign in with Apple private key supplied in `client_secret`. Supply this field when the provider is apple; it has no effect for other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_key_id")]
        public string? AppleKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthUpdateOAuthProviderRequest" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The OAuth client ID registered with the provider. Omit to keep the currently configured value.
        /// </param>
        /// <param name="clientSecret">
        /// OAuth client secret for the provider. Omit to leave the existing secret unchanged.<br/>
        /// For `apple`, a new `.p8` private key must be sent together with its `apple_key_id` in the same request; omit both to keep the stored key.
        /// </param>
        /// <param name="microsoftTenantId">
        /// The tenant ID scoping the Microsoft OAuth provider. Supply this field when the provider type is microsoft; it has no effect for other provider types.
        /// </param>
        /// <param name="appleTeamId">
        /// Apple Developer Team ID. Supply this field when the provider is apple; it has no effect for other providers.
        /// </param>
        /// <param name="appleKeyId">
        /// Key ID of the Sign in with Apple private key supplied in `client_secret`. Supply this field when the provider is apple; it has no effect for other providers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthUpdateOAuthProviderRequest(
            string? clientId,
            string? clientSecret,
            string? microsoftTenantId,
            string? appleTeamId,
            string? appleKeyId)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.MicrosoftTenantId = microsoftTenantId;
            this.AppleTeamId = appleTeamId;
            this.AppleKeyId = appleKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthUpdateOAuthProviderRequest" /> class.
        /// </summary>
        public NeonAuthUpdateOAuthProviderRequest()
        {
        }

    }
}