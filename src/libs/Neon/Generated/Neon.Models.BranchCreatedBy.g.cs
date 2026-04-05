
#nullable enable

namespace Neon
{
    /// <summary>
    /// The resolved user model that contains details of the user/org/integration/api_key used for branch creation. This field is filled only in listing/get/create/get/update/delete methods, if it is empty when calling other handlers, it does not mean that it is empty in the system.
    /// </summary>
    public sealed partial class BranchCreatedBy
    {
        /// <summary>
        /// The name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL to the user's avatar image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreatedBy" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the user.
        /// </param>
        /// <param name="image">
        /// The URL to the user's avatar image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchCreatedBy(
            string? name,
            string? image)
        {
            this.Name = name;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreatedBy" /> class.
        /// </summary>
        public BranchCreatedBy()
        {
        }
    }
}