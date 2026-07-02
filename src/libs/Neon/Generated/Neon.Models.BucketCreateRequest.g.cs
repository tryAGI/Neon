
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketCreateRequest
    {
        /// <summary>
        /// The bucket name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Access level for the bucket. Defaults to `private`. Set to `public_read`<br/>
        /// to allow anonymous `GetObject`/`HeadObject` on objects in this bucket.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Neon.JsonConverters.BucketCreateRequestAccessLevelJsonConverter))]
        public global::Neon.BucketCreateRequestAccessLevel? AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The bucket name.
        /// </param>
        /// <param name="accessLevel">
        /// Access level for the bucket. Defaults to `private`. Set to `public_read`<br/>
        /// to allow anonymous `GetObject`/`HeadObject` on objects in this bucket.<br/>
        /// Default Value: private
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketCreateRequest(
            string name,
            global::Neon.BucketCreateRequestAccessLevel? accessLevel)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketCreateRequest" /> class.
        /// </summary>
        public BucketCreateRequest()
        {
        }

    }
}