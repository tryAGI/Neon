
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketsListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.Bucket> Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketsListResponse" /> class.
        /// </summary>
        /// <param name="buckets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketsListResponse(
            global::System.Collections.Generic.IList<global::Neon.Bucket> buckets)
        {
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketsListResponse" /> class.
        /// </summary>
        public BucketsListResponse()
        {
        }

    }
}