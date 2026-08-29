
#nullable enable

namespace Neon
{
    /// <summary>
    /// Neon Data API created successfully
    /// </summary>
    public sealed partial class DataAPICreateResponse
    {
        /// <summary>
        /// URL of the created Data API endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPICreateResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the created Data API endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataAPICreateResponse(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAPICreateResponse" /> class.
        /// </summary>
        public DataAPICreateResponse()
        {
        }

    }
}