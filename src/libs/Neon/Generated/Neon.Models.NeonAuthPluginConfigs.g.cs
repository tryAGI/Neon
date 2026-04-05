
#nullable enable

namespace Neon
{
    /// <summary>
    /// Aggregated plugin configurations for Neon Auth
    /// </summary>
    public sealed partial class NeonAuthPluginConfigs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Neon.NeonAuthOrganizationConfig? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.NeonAuthEmailServerConfigJsonConverter))]
        public global::Neon.NeonAuthEmailServerConfig? EmailProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_and_password")]
        public global::Neon.NeonAuthEmailAndPasswordConfig? EmailAndPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_providers")]
        public global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider>? OauthProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_localhost")]
        public bool? AllowLocalhost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthPluginConfigs" /> class.
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="emailProvider"></param>
        /// <param name="emailAndPassword"></param>
        /// <param name="oauthProviders"></param>
        /// <param name="allowLocalhost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthPluginConfigs(
            global::Neon.NeonAuthOrganizationConfig? organization,
            global::Neon.NeonAuthEmailServerConfig? emailProvider,
            global::Neon.NeonAuthEmailAndPasswordConfig? emailAndPassword,
            global::System.Collections.Generic.IList<global::Neon.NeonAuthOauthProvider>? oauthProviders,
            bool? allowLocalhost)
        {
            this.Organization = organization;
            this.EmailProvider = emailProvider;
            this.EmailAndPassword = emailAndPassword;
            this.OauthProviders = oauthProviders;
            this.AllowLocalhost = allowLocalhost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthPluginConfigs" /> class.
        /// </summary>
        public NeonAuthPluginConfigs()
        {
        }
    }
}