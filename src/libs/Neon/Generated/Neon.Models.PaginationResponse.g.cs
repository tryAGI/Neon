
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationResponse
    {
        /// <summary>
        /// Cursor based pagination is used. The user must pass the cursor as is to the backend.<br/>
        /// For more information about cursor based pagination, see<br/>
        /// https://learn.microsoft.com/en-us/ef/core/querying/pagination#keyset-pagination<br/>
        /// Example: {"cursor":"2022-12-07T00:45:05.262011Z"}
        /// </summary>
        /// <example>{"cursor":"2022-12-07T00:45:05.262011Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::Neon.Pagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Cursor based pagination is used. The user must pass the cursor as is to the backend.<br/>
        /// For more information about cursor based pagination, see<br/>
        /// https://learn.microsoft.com/en-us/ef/core/querying/pagination#keyset-pagination<br/>
        /// Example: {"cursor":"2022-12-07T00:45:05.262011Z"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationResponse(
            global::Neon.Pagination? pagination)
        {
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        public PaginationResponse()
        {
        }
    }
}