
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkedAuthAccount
    {
        /// <summary>
        /// Identity provider id from keycloak
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.IdentityProviderIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.IdentityProviderId Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedAuthAccount" /> class.
        /// </summary>
        /// <param name="provider">
        /// Identity provider id from keycloak
        /// </param>
        /// <param name="providerDisplayName"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkedAuthAccount(
            global::Neon.IdentityProviderId provider,
            string providerDisplayName,
            string username)
        {
            this.Provider = provider;
            this.ProviderDisplayName = providerDisplayName ?? throw new global::System.ArgumentNullException(nameof(providerDisplayName));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedAuthAccount" /> class.
        /// </summary>
        public LinkedAuthAccount()
        {
        }
    }
}