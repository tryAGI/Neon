
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthRedirectURIWhitelistDomain
    {
        /// <summary>
        /// Allowed redirect URI domain for the auth provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthSupportedAuthProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthSupportedAuthProvider AuthProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthRedirectURIWhitelistDomain" /> class.
        /// </summary>
        /// <param name="domain">
        /// Allowed redirect URI domain for the auth provider.
        /// </param>
        /// <param name="authProvider">
        /// Authentication provider integrated with this Neon Auth configuration. `better_auth` integrates with Better Auth (the current, recommended provider). `stack` integrates with Stack Auth (deprecated). `mock` is a simulated provider for local development and testing only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthRedirectURIWhitelistDomain(
            string domain,
            global::Neon.NeonAuthSupportedAuthProvider authProvider)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.AuthProvider = authProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthRedirectURIWhitelistDomain" /> class.
        /// </summary>
        public NeonAuthRedirectURIWhitelistDomain()
        {
        }

    }
}