
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthProviderResource
    {
        /// <summary>
        /// Absolute URL identifying a protected resource. Issued access tokens carry it as their audience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderResource" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Absolute URL identifying a protected resource. Issued access tokens carry it as their audience.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthProviderResource(
            string identifier)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderResource" /> class.
        /// </summary>
        public NeonAuthOAuthProviderResource()
        {
        }

    }
}