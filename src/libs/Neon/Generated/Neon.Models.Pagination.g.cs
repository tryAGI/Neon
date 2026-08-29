
#nullable enable

namespace Neon
{
    /// <summary>
    /// Cursor-based pagination. The `cursor` value reflects the endpoint's sort field (for example, an ID or timestamp), so pass it back unchanged.<br/>
    /// Example: {"cursor":"2022-12-07T00:45:05.262011Z"}
    /// </summary>
    public sealed partial class Pagination
    {
        /// <summary>
        /// Cursor marking the last item in this response. Pass it unchanged as the `cursor` query parameter to fetch the next page.
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
        /// <param name="cursor">
        /// Cursor marking the last item in this response. Pass it unchanged as the `cursor` query parameter to fetch the next page.
        /// </param>
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