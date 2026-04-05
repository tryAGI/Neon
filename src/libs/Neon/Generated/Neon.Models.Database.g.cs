
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"id":834686,"branch_id":"br-wispy-meadow-118737","name":"neondb","owner_name":"casey","created_at":"2022-11-30T18:25:15Z","updated_at":"2022-11-30T18:25:15Z"}
    /// </summary>
    public sealed partial class Database
    {
        /// <summary>
        /// The database ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The ID of the branch to which the database belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BranchId { get; set; }

        /// <summary>
        /// The database name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The name of role that owns the database
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerName { get; set; }

        /// <summary>
        /// A timestamp indicating when the database was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp indicating when the database was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Database" /> class.
        /// </summary>
        /// <param name="id">
        /// The database ID
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to which the database belongs
        /// </param>
        /// <param name="name">
        /// The database name
        /// </param>
        /// <param name="ownerName">
        /// The name of role that owns the database
        /// </param>
        /// <param name="createdAt">
        /// A timestamp indicating when the database was created
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp indicating when the database was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Database(
            long id,
            string branchId,
            string name,
            string ownerName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id;
            this.BranchId = branchId ?? throw new global::System.ArgumentNullException(nameof(branchId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerName = ownerName ?? throw new global::System.ArgumentNullException(nameof(ownerName));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Database" /> class.
        /// </summary>
        public Database()
        {
        }
    }
}