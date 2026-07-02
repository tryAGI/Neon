
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketObjectsDeletePrefixResponse
    {
        /// <summary>
        /// The number of objects soft-deleted under the prefix. 0 when no live<br/>
        /// object matched the prefix on this branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObjectsDeletePrefixResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// The number of objects soft-deleted under the prefix. 0 when no live<br/>
        /// object matched the prefix on this branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketObjectsDeletePrefixResponse(
            long deleted)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObjectsDeletePrefixResponse" /> class.
        /// </summary>
        public BucketObjectsDeletePrefixResponse()
        {
        }

    }
}