
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthClientCreateRequest
    {
        /// <summary>
        /// Display name of the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Redirect URIs the client may use. Must be https, or http on loopback hosts when localhost is allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RedirectUris { get; set; }

        /// <summary>
        /// Confidential clients authenticate with a client secret. Public clients have no secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOAuthClientTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthOAuthClientType Type { get; set; }

        /// <summary>
        /// Identifiers of the protected resources to link the client to. Each must be configured on the OAuth provider plugin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Whether to skip the consent prompt for this client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_consent")]
        public bool? SkipConsent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthClientCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the client.
        /// </param>
        /// <param name="redirectUris">
        /// Redirect URIs the client may use. Must be https, or http on loopback hosts when localhost is allowed.
        /// </param>
        /// <param name="type">
        /// Confidential clients authenticate with a client secret. Public clients have no secret.
        /// </param>
        /// <param name="resources">
        /// Identifiers of the protected resources to link the client to. Each must be configured on the OAuth provider plugin.
        /// </param>
        /// <param name="skipConsent">
        /// Whether to skip the consent prompt for this client.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthClientCreateRequest(
            string name,
            global::System.Collections.Generic.IList<string> redirectUris,
            global::Neon.NeonAuthOAuthClientType type,
            global::System.Collections.Generic.IList<string> resources,
            bool? skipConsent)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RedirectUris = redirectUris ?? throw new global::System.ArgumentNullException(nameof(redirectUris));
            this.Type = type;
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.SkipConsent = skipConsent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthClientCreateRequest" /> class.
        /// </summary>
        public NeonAuthOAuthClientCreateRequest()
        {
        }

    }
}