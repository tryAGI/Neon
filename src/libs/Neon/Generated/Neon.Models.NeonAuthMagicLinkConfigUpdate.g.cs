
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthMagicLinkConfigUpdate
    {
        /// <summary>
        /// Whether to enable the magic link plugin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Minutes until the magic link expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// When true, sign-up via magic link is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_sign_up")]
        public bool? DisableSignUp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthMagicLinkConfigUpdate" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to enable the magic link plugin.
        /// </param>
        /// <param name="expiresIn">
        /// Minutes until the magic link expires.
        /// </param>
        /// <param name="disableSignUp">
        /// When true, sign-up via magic link is disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthMagicLinkConfigUpdate(
            bool? enabled,
            int? expiresIn,
            bool? disableSignUp)
        {
            this.Enabled = enabled;
            this.ExpiresIn = expiresIn;
            this.DisableSignUp = disableSignUp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthMagicLinkConfigUpdate" /> class.
        /// </summary>
        public NeonAuthMagicLinkConfigUpdate()
        {
        }

    }
}