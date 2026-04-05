
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CursorPaginationResponse
    {
        /// <summary>
        /// To paginate the response, issue an initial request with `limit` value. Then, add the value returned in the response `.pagination.next` attribute into the request under the `cursor` query parameter to the subsequent request to retrieve next page in pagination. The contents on cursor `next` are opaque, clients are not expected to make any assumptions on the format of the data inside the cursor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::Neon.CursorPagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPaginationResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// To paginate the response, issue an initial request with `limit` value. Then, add the value returned in the response `.pagination.next` attribute into the request under the `cursor` query parameter to the subsequent request to retrieve next page in pagination. The contents on cursor `next` are opaque, clients are not expected to make any assumptions on the format of the data inside the cursor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CursorPaginationResponse(
            global::Neon.CursorPagination? pagination)
        {
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorPaginationResponse" /> class.
        /// </summary>
        public CursorPaginationResponse()
        {
        }
    }
}