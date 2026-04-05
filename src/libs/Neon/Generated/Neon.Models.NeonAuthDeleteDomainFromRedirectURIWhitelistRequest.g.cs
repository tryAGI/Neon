
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthDeleteDomainFromRedirectURIWhitelistRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem> Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthDeleteDomainFromRedirectURIWhitelistRequest" /> class.
        /// </summary>
        /// <param name="authProvider"></param>
        /// <param name="domains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthDeleteDomainFromRedirectURIWhitelistRequest(
            global::Neon.NeonAuthSupportedAuthProvider authProvider,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthDeleteDomainFromRedirectURIWhitelistItem> domains)
        {
            this.AuthProvider = authProvider;
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthDeleteDomainFromRedirectURIWhitelistRequest" /> class.
        /// </summary>
        public NeonAuthDeleteDomainFromRedirectURIWhitelistRequest()
        {
        }
    }
}