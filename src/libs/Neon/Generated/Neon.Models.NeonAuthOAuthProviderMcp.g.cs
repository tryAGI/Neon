
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthProviderMcp
    {
        /// <summary>
        /// The MCP server URL that dynamically registered clients are linked to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// Whether MCP clients may register themselves via dynamic client registration (RFC 7591). Defaults to true, but takes effect only when an MCP resource is configured; reads report false otherwise. When false, only clients created through the OAuth clients API can be used, and they can still be linked to the MCP resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_registration")]
        public bool? DynamicRegistration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderMcp" /> class.
        /// </summary>
        /// <param name="resource">
        /// The MCP server URL that dynamically registered clients are linked to.
        /// </param>
        /// <param name="dynamicRegistration">
        /// Whether MCP clients may register themselves via dynamic client registration (RFC 7591). Defaults to true, but takes effect only when an MCP resource is configured; reads report false otherwise. When false, only clients created through the OAuth clients API can be used, and they can still be linked to the MCP resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthProviderMcp(
            string? resource,
            bool? dynamicRegistration)
        {
            this.Resource = resource;
            this.DynamicRegistration = dynamicRegistration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderMcp" /> class.
        /// </summary>
        public NeonAuthOAuthProviderMcp()
        {
        }

    }
}