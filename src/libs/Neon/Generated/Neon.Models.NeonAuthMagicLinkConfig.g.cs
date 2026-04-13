
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthMagicLinkConfig
    {
        /// <summary>
        /// Whether the magic link plugin is enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Time in minutes before the magic link expires<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// Whether to disable sign-up via magic link<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_sign_up")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableSignUp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthMagicLinkConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the magic link plugin is enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expiresIn">
        /// Time in minutes before the magic link expires<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="disableSignUp">
        /// Whether to disable sign-up via magic link<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthMagicLinkConfig(
            bool enabled,
            int expiresIn,
            bool disableSignUp)
        {
            this.Enabled = enabled;
            this.ExpiresIn = expiresIn;
            this.DisableSignUp = disableSignUp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthMagicLinkConfig" /> class.
        /// </summary>
        public NeonAuthMagicLinkConfig()
        {
        }
    }
}