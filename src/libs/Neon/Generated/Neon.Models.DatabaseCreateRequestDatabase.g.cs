
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatabaseCreateRequestDatabase
    {
        /// <summary>
        /// The name of the database
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The name of the role that owns the database
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseCreateRequestDatabase" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the database
        /// </param>
        /// <param name="ownerName">
        /// The name of the role that owns the database
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatabaseCreateRequestDatabase(
            string name,
            string ownerName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerName = ownerName ?? throw new global::System.ArgumentNullException(nameof(ownerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseCreateRequestDatabase" /> class.
        /// </summary>
        public DatabaseCreateRequestDatabase()
        {
        }
    }
}