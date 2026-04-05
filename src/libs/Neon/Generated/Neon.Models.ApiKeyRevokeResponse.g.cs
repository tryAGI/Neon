
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyRevokeResponse
    {
        /// <summary>
        /// The API key ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The user-specified API key name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A timestamp indicating when the API key was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ID of the user who created this API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreatedBy { get; set; }

        /// <summary>
        /// A timestamp indicating when the API was last used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// The IP address from which the API key was last used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_from_addr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUsedFromAddr { get; set; }

        /// <summary>
        /// A `true` or `false` value indicating whether the API key is revoked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Revoked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyRevokeResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The API key ID
        /// </param>
        /// <param name="name">
        /// The user-specified API key name
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the API key was created
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who created this API key
        /// </param>
        /// <param name="lastUsedFromAddr">
        /// The IP address from which the API key was last used
        /// </param>
        /// <param name="revoked">
        /// A `true` or `false` value indicating whether the API key is revoked
        /// </param>
        /// <param name="lastUsedAt">
        /// A timestamp indicating when the API was last used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyRevokeResponse(
            long id,
            string name,
            global::System.DateTime createdAt,
            global::System.Guid createdBy,
            string lastUsedFromAddr,
            bool revoked,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUsedAt = lastUsedAt;
            this.LastUsedFromAddr = lastUsedFromAddr ?? throw new global::System.ArgumentNullException(nameof(lastUsedFromAddr));
            this.Revoked = revoked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyRevokeResponse" /> class.
        /// </summary>
        public ApiKeyRevokeResponse()
        {
        }
    }
}