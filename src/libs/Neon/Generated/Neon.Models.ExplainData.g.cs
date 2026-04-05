
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExplainData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("QUERY PLAN")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query_plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainData" /> class.
        /// </summary>
        /// <param name="query_plan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExplainData(
            string query_plan)
        {
            this.Query_plan = query_plan ?? throw new global::System.ArgumentNullException(nameof(query_plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainData" /> class.
        /// </summary>
        public ExplainData()
        {
        }
    }
}