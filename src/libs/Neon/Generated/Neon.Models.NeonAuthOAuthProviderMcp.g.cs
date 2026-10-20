
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NeonAuthOAuthProviderMcp
    {
        /// <summary>
        /// The MCP server URL that MCP clients (Client ID Metadata Document and dynamically registered) are linked to. Required for either to be accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// Legacy: whether MCP clients may register themselves via dynamic client registration (RFC 7591). Deprecated in favor of Client ID Metadata Documents (CIMD), which are controlled by `client_id_metadata_documents`. Defaults to false, and takes effect only when an MCP resource is configured; reads report false otherwise. When false, only CIMD clients and clients created through the OAuth clients API can be used, and they can still be linked to the MCP resource.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_registration")]
        public bool? DynamicRegistration { get; set; }

        /// <summary>
        /// Whether MCP clients may identify themselves with an https Client ID Metadata Document (CIMD) URL. Recommended over dynamic registration. When false, new CIMD clients are rejected and existing CIMD clients fail closed.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id_metadata_documents")]
        public bool? ClientIdMetadataDocuments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderMcp" /> class.
        /// </summary>
        /// <param name="resource">
        /// The MCP server URL that MCP clients (Client ID Metadata Document and dynamically registered) are linked to. Required for either to be accepted.
        /// </param>
        /// <param name="dynamicRegistration">
        /// Legacy: whether MCP clients may register themselves via dynamic client registration (RFC 7591). Deprecated in favor of Client ID Metadata Documents (CIMD), which are controlled by `client_id_metadata_documents`. Defaults to false, and takes effect only when an MCP resource is configured; reads report false otherwise. When false, only CIMD clients and clients created through the OAuth clients API can be used, and they can still be linked to the MCP resource.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="clientIdMetadataDocuments">
        /// Whether MCP clients may identify themselves with an https Client ID Metadata Document (CIMD) URL. Recommended over dynamic registration. When false, new CIMD clients are rejected and existing CIMD clients fail closed.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthOAuthProviderMcp(
            string? resource,
            bool? dynamicRegistration,
            bool? clientIdMetadataDocuments)
        {
            this.Resource = resource;
            this.DynamicRegistration = dynamicRegistration;
            this.ClientIdMetadataDocuments = clientIdMetadataDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthOAuthProviderMcp" /> class.
        /// </summary>
        public NeonAuthOAuthProviderMcp()
        {
        }

    }
}