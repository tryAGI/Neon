
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketObject
    {
        /// <summary>
        /// The full object key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The object size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// The time the object was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastModified { get; set; }

        /// <summary>
        /// The object's entity tag (content hash).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObject" /> class.
        /// </summary>
        /// <param name="key">
        /// The full object key.
        /// </param>
        /// <param name="size">
        /// The object size in bytes.
        /// </param>
        /// <param name="lastModified">
        /// The time the object was last modified.
        /// </param>
        /// <param name="etag">
        /// The object's entity tag (content hash).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketObject(
            string key,
            long size,
            global::System.DateTime lastModified,
            string etag)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Size = size;
            this.LastModified = lastModified;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObject" /> class.
        /// </summary>
        public BucketObject()
        {
        }

    }
}