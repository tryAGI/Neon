
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthProviderConfig
    {
        /// <summary>
        /// Whether the OAuth provider plugin is enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// URL of the page that authorization requests redirect to for sign-in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login_page")]
        public string? LoginPage { get; set; }

        /// <summary>
        /// URL of the page that authorization requests redirect to for consent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consent_page")]
        public string? ConsentPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        public global::Neon.NeonAuthOAuthProviderMcp? Mcp { get; set; }

        /// <summary>
        /// Protected resources that clients can be linked to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Neon.NeonAuthOAuthProviderResource>? Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the OAuth provider plugin is enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loginPage">
        /// URL of the page that authorization requests redirect to for sign-in.
        /// </param>
        /// <param name="consentPage">
        /// URL of the page that authorization requests redirect to for consent.
        /// </param>
        /// <param name="mcp"></param>
        /// <param name="resources">
        /// Protected resources that clients can be linked to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthProviderConfig(
            bool enabled,
            string? loginPage,
            string? consentPage,
            global::Neon.NeonAuthOAuthProviderMcp? mcp,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthOAuthProviderResource>? resources)
        {
            this.Enabled = enabled;
            this.LoginPage = loginPage;
            this.ConsentPage = consentPage;
            this.Mcp = mcp;
            this.Resources = resources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderConfig" /> class.
        /// </summary>
        public NeonAuthOAuthProviderConfig()
        {
        }

    }
}