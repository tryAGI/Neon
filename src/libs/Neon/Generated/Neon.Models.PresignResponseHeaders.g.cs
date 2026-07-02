
#nullable enable

namespace Neon
{
    /// <summary>
    /// Headers the caller MUST send verbatim on the request (e.g.<br/>
    /// `Content-Type` when it was signed on an upload). May be empty.
    /// </summary>
    public sealed partial class PresignResponseHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}