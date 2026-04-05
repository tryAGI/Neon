
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchUpdateRequestBranch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        public bool? Protected { get; set; }

        /// <summary>
        /// The timestamp when the branch is scheduled to expire and be automatically deleted. Must be set by the client following the [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6) format with precision up to seconds (such as 2025-06-09T18:02:16Z). Deletion is performed by a background job and may not occur exactly at the specified time. If this field is set to null, the expiration timestamp is removed.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 2025-06-09T18:02:16Z
        /// </summary>
        /// <example>2025-06-09T18:02:16Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchUpdateRequestBranch" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="protected"></param>
        /// <param name="expiresAt">
        /// The timestamp when the branch is scheduled to expire and be automatically deleted. Must be set by the client following the [RFC 3339, section 5.6](https://tools.ietf.org/html/rfc3339#section-5.6) format with precision up to seconds (such as 2025-06-09T18:02:16Z). Deletion is performed by a background job and may not occur exactly at the specified time. If this field is set to null, the expiration timestamp is removed.<br/>
        /// Access to this feature is currently limited to participants in the Early Access Program.<br/>
        /// Example: 2025-06-09T18:02:16Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchUpdateRequestBranch(
            string? name,
            bool? @protected,
            global::System.DateTime? expiresAt)
        {
            this.Name = name;
            this.Protected = @protected;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchUpdateRequestBranch" /> class.
        /// </summary>
        public BranchUpdateRequestBranch()
        {
        }
    }
}