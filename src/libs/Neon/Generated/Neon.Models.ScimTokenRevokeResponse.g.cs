
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScimTokenRevokeResponse
    {
        /// <summary>
        /// The revoked SCIM token's unique ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimTokenRevokeResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The revoked SCIM token's unique ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimTokenRevokeResponse(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimTokenRevokeResponse" /> class.
        /// </summary>
        public ScimTokenRevokeResponse()
        {
        }

    }
}