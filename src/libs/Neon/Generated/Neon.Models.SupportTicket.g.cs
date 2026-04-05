
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SupportTicket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salesforce_id")]
        public string? SalesforceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_uploads")]
        public global::System.Collections.Generic.IList<string>? FailedUploads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportTicket" /> class.
        /// </summary>
        /// <param name="salesforceId"></param>
        /// <param name="failedUploads"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupportTicket(
            string? salesforceId,
            global::System.Collections.Generic.IList<string>? failedUploads)
        {
            this.SalesforceId = salesforceId;
            this.FailedUploads = failedUploads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportTicket" /> class.
        /// </summary>
        public SupportTicket()
        {
        }
    }
}