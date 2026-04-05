
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestRequest
    {
        /// <summary>
        /// The Neon organization ID to transfer the project to. If not provided, the project will be<br/>
        /// transferred to the current user or organization account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequest" /> class.
        /// </summary>
        /// <param name="orgId">
        /// The Neon organization ID to transfer the project to. If not provided, the project will be<br/>
        /// transferred to the current user or organization account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestRequest(
            string? orgId)
        {
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequest" /> class.
        /// </summary>
        public AcceptProjectTransferRequestRequest()
        {
        }
    }
}