
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NeonAuthAllowLocalhostResponse
    {
        /// <summary>
        /// Whether to allow localhost connections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_localhost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowLocalhost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthAllowLocalhostResponse" /> class.
        /// </summary>
        /// <param name="allowLocalhost">
        /// Whether to allow localhost connections
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NeonAuthAllowLocalhostResponse(
            bool allowLocalhost)
        {
            this.AllowLocalhost = allowLocalhost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NeonAuthAllowLocalhostResponse" /> class.
        /// </summary>
        public NeonAuthAllowLocalhostResponse()
        {
        }
    }
}