
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchStorage
    {
        /// <summary>
        /// Always `true` in 200 responses. Present for forward compatibility: a<br/>
        /// future version may add intermediate states; callers should treat `true`<br/>
        /// as "storage is usable for this branch right now."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The S3-compatible endpoint URL for this branch.<br/>
        /// Example: https://br-cool-moon-42.storage.c-2.local.neon.build
        /// </summary>
        /// <example>https://br-cool-moon-42.storage.c-2.local.neon.build</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string S3Endpoint { get; set; }

        /// <summary>
        /// The AWS region for this branch's storage. The platform normalizes<br/>
        /// the us-east-1 convention server-side: a non-empty region string is<br/>
        /// always returned in 200 responses (e.g. `"us-east-1"` for the S3<br/>
        /// default region).<br/>
        /// Example: us-east-2
        /// </summary>
        /// <example>us-east-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Whether the S3 client must use path-style addressing<br/>
        /// (bucket-in-path rather than virtual-hosted subdomain).<br/>
        /// Always true: the wildcard TLS cert covers one level of subdomain<br/>
        /// (*.storage.&lt;suffix&gt;), so the branch ID occupies that label and the<br/>
        /// bucket name must travel in the request path, not as a further<br/>
        /// subdomain. Callers must set the S3 SDK's ForcePathStyle (or<br/>
        /// equivalent) to true.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_path_style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForcePathStyle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchStorage" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Always `true` in 200 responses. Present for forward compatibility: a<br/>
        /// future version may add intermediate states; callers should treat `true`<br/>
        /// as "storage is usable for this branch right now."
        /// </param>
        /// <param name="s3Endpoint">
        /// The S3-compatible endpoint URL for this branch.<br/>
        /// Example: https://br-cool-moon-42.storage.c-2.local.neon.build
        /// </param>
        /// <param name="region">
        /// The AWS region for this branch's storage. The platform normalizes<br/>
        /// the us-east-1 convention server-side: a non-empty region string is<br/>
        /// always returned in 200 responses (e.g. `"us-east-1"` for the S3<br/>
        /// default region).<br/>
        /// Example: us-east-2
        /// </param>
        /// <param name="forcePathStyle">
        /// Whether the S3 client must use path-style addressing<br/>
        /// (bucket-in-path rather than virtual-hosted subdomain).<br/>
        /// Always true: the wildcard TLS cert covers one level of subdomain<br/>
        /// (*.storage.&lt;suffix&gt;), so the branch ID occupies that label and the<br/>
        /// bucket name must travel in the request path, not as a further<br/>
        /// subdomain. Callers must set the S3 SDK's ForcePathStyle (or<br/>
        /// equivalent) to true.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchStorage(
            bool enabled,
            string s3Endpoint,
            string region,
            bool forcePathStyle)
        {
            this.Enabled = enabled;
            this.S3Endpoint = s3Endpoint ?? throw new global::System.ArgumentNullException(nameof(s3Endpoint));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ForcePathStyle = forcePathStyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchStorage" /> class.
        /// </summary>
        public BranchStorage()
        {
        }

    }
}