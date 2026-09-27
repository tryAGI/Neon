
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScimToken
    {
        /// <summary>
        /// The SCIM token's unique ID. Distinct from the token value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The admin-specified token name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A timestamp indicating when the SCIM token was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the token was last used to authenticate, if ever
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimToken" /> class.
        /// </summary>
        /// <param name="id">
        /// The SCIM token's unique ID. Distinct from the token value.
        /// </param>
        /// <param name="name">
        /// The admin-specified token name
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the SCIM token was created
        /// </param>
        /// <param name="lastUsedAt">
        /// A timestamp indicating when the token was last used to authenticate, if ever
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimToken(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimToken" /> class.
        /// </summary>
        public ScimToken()
        {
        }

    }
}