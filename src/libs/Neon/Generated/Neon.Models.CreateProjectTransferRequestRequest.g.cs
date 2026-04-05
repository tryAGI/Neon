
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectTransferRequestRequest
    {
        /// <summary>
        /// Specifies the validity duration of the transfer request in seconds. If not provided,<br/>
        /// the request will expire after 24 hours (86,400 seconds).
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
        /// Specifies the validity duration of the transfer request in seconds. If not provided,<br/>
        /// the request will expire after 24 hours (86,400 seconds).
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