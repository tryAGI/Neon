
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthClient
    {
        /// <summary>
        /// The OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Display name of the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Confidential clients authenticate with a client secret. Public clients have no secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthOAuthClientTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.NeonAuthOAuthClientType Type { get; set; }

        /// <summary>
        /// Redirect URIs the client may use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RedirectUris { get; set; }

        /// <summary>
        /// Identifiers of the protected resources the client is linked to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Whether users are not asked for consent when authorizing this client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_consent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SkipConsent { get; set; }

        /// <summary>
        /// Whether the client is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// When the client was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthClient" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The OAuth client ID.
        /// </param>
        /// <param name="name">
        /// Display name of the client.
        /// </param>
        /// <param name="type">
        /// Confidential clients authenticate with a client secret. Public clients have no secret.
        /// </param>
        /// <param name="redirectUris">
        /// Redirect URIs the client may use.
        /// </param>
        /// <param name="resources">
        /// Identifiers of the protected resources the client is linked to.
        /// </param>
        /// <param name="skipConsent">
        /// Whether users are not asked for consent when authorizing this client.
        /// </param>
        /// <param name="disabled">
        /// Whether the client is disabled.
        /// </param>
        /// <param name="createdAt">
        /// When the client was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthClient(
            string clientId,
            string name,
            global::Neon.NeonAuthOAuthClientType type,
            global::System.Collections.Generic.IList<string> redirectUris,
            global::System.Collections.Generic.IList<string> resources,
            bool skipConsent,
            bool disabled,
            global::System.DateTime? createdAt)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.RedirectUris = redirectUris ?? throw new global::System.ArgumentNullException(nameof(redirectUris));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.SkipConsent = skipConsent;
            this.Disabled = disabled;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthClient" /> class.
        /// </summary>
        public NeonAuthOAuthClient()
        {
        }

    }
}