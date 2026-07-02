
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketObjectsListResponse
    {
        /// <summary>
        /// Common prefixes (folder names) collapsed under the requested<br/>
        /// `delimiter`. Empty when no `delimiter` was supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Folders { get; set; }

        /// <summary>
        /// Objects whose keys did not collapse into a folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.BucketObject> Objects { get; set; }

        /// <summary>
        /// The prefix that was applied to this listing (echoed back).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Pagination cursor to pass as `cursor` on the next request. Empty<br/>
        /// when the listing is not truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// True when more results exist beyond this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTruncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObjectsListResponse" /> class.
        /// </summary>
        /// <param name="folders">
        /// Common prefixes (folder names) collapsed under the requested<br/>
        /// `delimiter`. Empty when no `delimiter` was supplied.
        /// </param>
        /// <param name="objects">
        /// Objects whose keys did not collapse into a folder.
        /// </param>
        /// <param name="prefix">
        /// The prefix that was applied to this listing (echoed back).
        /// </param>
        /// <param name="isTruncated">
        /// True when more results exist beyond this page.
        /// </param>
        /// <param name="nextCursor">
        /// Pagination cursor to pass as `cursor` on the next request. Empty<br/>
        /// when the listing is not truncated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BucketObjectsListResponse(
            global::System.Collections.Generic.IList<string> folders,
            global::System.Collections.Generic.IList<global::Neon.BucketObject> objects,
            string prefix,
            bool isTruncated,
            string? nextCursor)
        {
            this.Folders = folders ?? throw new global::System.ArgumentNullException(nameof(folders));
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.NextCursor = nextCursor;
            this.IsTruncated = isTruncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObjectsListResponse" /> class.
        /// </summary>
        public BucketObjectsListResponse()
        {
        }

    }
}