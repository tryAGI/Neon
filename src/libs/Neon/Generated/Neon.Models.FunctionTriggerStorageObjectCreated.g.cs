
#nullable enable

namespace Neon
{
    /// <summary>
    /// Matches successful uploads to one exact bucket and, when configured, an<br/>
    /// object-key prefix. The Function receives a JSON request body with<br/>
    /// `type` set to `storage_object_created` and a `data` object containing<br/>
    /// exactly `bucket_name` and `object_key`.
    /// </summary>
    public sealed partial class FunctionTriggerStorageObjectCreated
    {
        /// <summary>
        /// The exact object-storage bucket name to watch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// Optional object-key prefix of at most 1024 UTF-8 bytes. When omitted,<br/>
        /// every key in the bucket matches. When present, the full object key<br/>
        /// must start with these exact bytes; matching is case-sensitive and<br/>
        /// does not normalize paths or require a path-segment boundary.<br/>
        /// Match-all responses omit this field rather than returning an empty<br/>
        /// string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTriggerStorageObjectCreated" /> class.
        /// </summary>
        /// <param name="bucketName">
        /// The exact object-storage bucket name to watch.
        /// </param>
        /// <param name="prefix">
        /// Optional object-key prefix of at most 1024 UTF-8 bytes. When omitted,<br/>
        /// every key in the bucket matches. When present, the full object key<br/>
        /// must start with these exact bytes; matching is case-sensitive and<br/>
        /// does not normalize paths or require a path-segment boundary.<br/>
        /// Match-all responses omit this field rather than returning an empty<br/>
        /// string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionTriggerStorageObjectCreated(
            string bucketName,
            string? prefix)
        {
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.Prefix = prefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTriggerStorageObjectCreated" /> class.
        /// </summary>
        public FunctionTriggerStorageObjectCreated()
        {
        }

    }
}