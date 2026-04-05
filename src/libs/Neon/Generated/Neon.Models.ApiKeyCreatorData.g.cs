
#nullable enable

namespace Neon
{
    /// <summary>
    /// The user data of the user that created this API key.
    /// </summary>
    public sealed partial class ApiKeyCreatorData
    {
        /// <summary>
        /// ID of the user who created this API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The URL to the user's avatar image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreatorData" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the user who created this API key
        /// </param>
        /// <param name="name">
        /// The name of the user.
        /// </param>
        /// <param name="image">
        /// The URL to the user's avatar image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyCreatorData(
            global::System.Guid id,
            string name,
            string image)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreatorData" /> class.
        /// </summary>
        public ApiKeyCreatorData()
        {
        }
    }
}