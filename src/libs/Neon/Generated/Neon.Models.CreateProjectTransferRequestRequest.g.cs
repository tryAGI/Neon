
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectTransferRequestRequest
    {
        /// <summary>
        /// Number of seconds the transfer request stays valid before it expires. Defaults to 86400 (24 hours).<br/>
        /// Default Value: 86400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public long? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTransferRequestRequest" /> class.
        /// </summary>
        /// <param name="ttlSeconds">
        /// Number of seconds the transfer request stays valid before it expires. Defaults to 86400 (24 hours).<br/>
        /// Default Value: 86400
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectTransferRequestRequest(
            long? ttlSeconds)
        {
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTransferRequestRequest" /> class.
        /// </summary>
        public CreateProjectTransferRequestRequest()
        {
        }

    }
}