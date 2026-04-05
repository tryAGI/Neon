
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectionURIsOptionalResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_uris")]
        public global::System.Collections.Generic.IList<global::Neon.ConnectionDetails>? ConnectionUris { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionURIsOptionalResponse" /> class.
        /// </summary>
        /// <param name="connectionUris"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionURIsOptionalResponse(
            global::System.Collections.Generic.IList<global::Neon.ConnectionDetails>? connectionUris)
        {
            this.ConnectionUris = connectionUris;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionURIsOptionalResponse" /> class.
        /// </summary>
        public ConnectionURIsOptionalResponse()
        {
        }
    }
}