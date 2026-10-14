
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthProviderMcpUpdate
    {
        /// <summary>
        /// The MCP server URL that dynamically registered clients are linked to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        /// Whether MCP clients may register themselves via dynamic client registration (RFC 7591). When omitted, the stored value is kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_registration")]
        public bool? DynamicRegistration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderMcpUpdate" /> class.
        /// </summary>
        /// <param name="resource">
        /// The MCP server URL that dynamically registered clients are linked to.
        /// </param>
        /// <param name="dynamicRegistration">
        /// Whether MCP clients may register themselves via dynamic client registration (RFC 7591). When omitted, the stored value is kept.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthProviderMcpUpdate(
            string resource,
            bool? dynamicRegistration)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.DynamicRegistration = dynamicRegistration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderMcpUpdate" /> class.
        /// </summary>
        public NeonAuthOAuthProviderMcpUpdate()
        {
        }

    }
}