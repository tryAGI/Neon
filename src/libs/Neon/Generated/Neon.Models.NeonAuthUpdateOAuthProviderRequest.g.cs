
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
        /// OAuth client secret for the provider. Omit to leave the existing secret unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The tenant ID scoping the Microsoft OAuth provider. Supply this field when the provider type is microsoft; it has no effect for other provider types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_tenant_id")]
        public string? MicrosoftTenantId { get; set; }

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
        /// OAuth client secret for the provider. Omit to leave the existing secret unchanged.
        /// </param>
        /// <param name="microsoftTenantId">
        /// The tenant ID scoping the Microsoft OAuth provider. Supply this field when the provider type is microsoft; it has no effect for other provider types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthUpdateOAuthProviderRequest(
            string? clientId,
            string? clientSecret,
            string? microsoftTenantId)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.MicrosoftTenantId = microsoftTenantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthUpdateOAuthProviderRequest" /> class.
        /// </summary>
        public NeonAuthUpdateOAuthProviderRequest()
        {
        }

    }
}