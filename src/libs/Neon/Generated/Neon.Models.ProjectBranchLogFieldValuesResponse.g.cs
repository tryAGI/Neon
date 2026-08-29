
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectBranchLogFieldValuesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// True when more distinct values exist than were returned, because<br/>
        /// either the requested `limit` or the server's own scan cap was<br/>
        /// reached. A caller that filters on a partial list is choosing from an<br/>
        /// arbitrary subset, so narrow `since` or `source` and ask again when<br/>
        /// this is `true`.
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
        /// Initializes a new instance of the <see cref="ProjectBranchLogFieldValuesResponse" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="isTruncated">
        /// True when more distinct values exist than were returned, because<br/>
        /// either the requested `limit` or the server's own scan cap was<br/>
        /// reached. A caller that filters on a partial list is choosing from an<br/>
        /// arbitrary subset, so narrow `since` or `source` and ask again when<br/>
        /// this is `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectBranchLogFieldValuesResponse(
            global::System.Collections.Generic.IList<string> values,
            bool isTruncated)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.IsTruncated = isTruncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBranchLogFieldValuesResponse" /> class.
        /// </summary>
        public ProjectBranchLogFieldValuesResponse()
        {
        }

    }
}