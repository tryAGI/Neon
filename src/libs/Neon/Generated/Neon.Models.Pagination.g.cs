
#nullable enable

namespace Neon
{
    /// <summary>
    /// Cursor based pagination is used. The user must pass the cursor as is to the backend.<br/>
    /// For more information about cursor based pagination, see<br/>
    /// https://learn.microsoft.com/en-us/ef/core/querying/pagination#keyset-pagination<br/>
    /// Example: {"cursor":"2022-12-07T00:45:05.262011Z"}
    /// </summary>
    public sealed partial class Pagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pagination(
            string cursor)
        {
            this.Cursor = cursor ?? throw new global::System.ArgumentNullException(nameof(cursor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        public Pagination()
        {
        }
    }
}