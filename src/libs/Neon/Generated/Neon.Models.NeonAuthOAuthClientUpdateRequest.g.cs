
#nullable enable

namespace Neon
{
    /// <summary>
    /// At least one field must be provided.
    /// </summary>
    public sealed partial class NeonAuthOAuthClientUpdateRequest
    {
        /// <summary>
        /// Display name of the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Redirect URIs the client may use. When provided, replaces the stored list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        /// Whether to skip the consent prompt for this client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_consent")]
        public bool? SkipConsent { get; set; }

        /// <summary>
        /// Whether the client is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Identifiers of the protected resources to link the client to. When provided, replaces the stored list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<string>? Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthClientUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the client.
        /// </param>
        /// <param name="redirectUris">
        /// Redirect URIs the client may use. When provided, replaces the stored list.
        /// </param>
        /// <param name="skipConsent">
        /// Whether to skip the consent prompt for this client.
        /// </param>
        /// <param name="disabled">
        /// Whether the client is disabled.
        /// </param>
        /// <param name="resources">
        /// Identifiers of the protected resources to link the client to. When provided, replaces the stored list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthClientUpdateRequest(
            string? name,
            global::System.Collections.Generic.IList<string>? redirectUris,
            bool? skipConsent,
            bool? disabled,
            global::System.Collections.Generic.IList<string>? resources)
        {
            this.Name = name;
            this.RedirectUris = redirectUris;
            this.SkipConsent = skipConsent;
            this.Disabled = disabled;
            this.Resources = resources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthClientUpdateRequest" /> class.
        /// </summary>
        public NeonAuthOAuthClientUpdateRequest()
        {
        }

    }
}