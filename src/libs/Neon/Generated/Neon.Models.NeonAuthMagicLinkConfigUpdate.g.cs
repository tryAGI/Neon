
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthMagicLinkConfigUpdate
    {
        /// <summary>
        /// Whether the magic link plugin is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time in minutes before the magic link expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Whether to disable sign-up via magic link
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
        /// Whether the magic link plugin is enabled
        /// </param>
        /// <param name="expiresIn">
        /// Time in minutes before the magic link expires
        /// </param>
        /// <param name="disableSignUp">
        /// Whether to disable sign-up via magic link
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