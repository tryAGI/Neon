
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Bucket
    {
        /// <summary>
        /// The bucket name (unique within a branch).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Controls anonymous access to objects in the bucket.<br/>
        /// - `private`: all reads and writes require authenticated requests (default).<br/>
        /// - `public_read`: anonymous `GetObject`/`HeadObject` requests succeed; listing,<br/>
        ///   writes, and deletes still require authenticated requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BucketAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Neon.BucketAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// When the bucket was created. For a bucket inherited from an<br/>
        /// ancestor branch this is the ancestor's creation time (the branch<br/>
        /// fork never re-creates the bucket).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        /// <param name="name">
        /// The bucket name (unique within a branch).
        /// </param>
        /// <param name="accessLevel">
        /// Controls anonymous access to objects in the bucket.<br/>
        /// - `private`: all reads and writes require authenticated requests (default).<br/>
        /// - `public_read`: anonymous `GetObject`/`HeadObject` requests succeed; listing,<br/>
        ///   writes, and deletes still require authenticated requests.
        /// </param>
        /// <param name="createdAt">
        /// When the bucket was created. For a bucket inherited from an<br/>
        /// ancestor branch this is the ancestor's creation time (the branch<br/>
        /// fork never re-creates the bucket).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Bucket(
            string name,
            global::Neon.BucketAccessLevel accessLevel,
            global::System.DateTime createdAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AccessLevel = accessLevel;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        public Bucket()
        {
        }

    }
}