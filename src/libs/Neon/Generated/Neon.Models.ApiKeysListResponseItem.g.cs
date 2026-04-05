
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeysListResponseItem
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
        /// The user data of the user that created this API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.ApiKeyCreatorData CreatedBy { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysListResponseItem" /> class.
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
        /// The user data of the user that created this API key.
        /// </param>
        /// <param name="lastUsedFromAddr">
        /// The IP address from which the API key was last used
        /// </param>
        /// <param name="lastUsedAt">
        /// A timestamp indicating when the API was last used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeysListResponseItem(
            long id,
            string name,
            global::System.DateTime createdAt,
            global::Neon.ApiKeyCreatorData createdBy,
            string lastUsedFromAddr,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.LastUsedAt = lastUsedAt;
            this.LastUsedFromAddr = lastUsedFromAddr ?? throw new global::System.ArgumentNullException(nameof(lastUsedFromAddr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysListResponseItem" /> class.
        /// </summary>
        public ApiKeysListResponseItem()
        {
        }
    }
}