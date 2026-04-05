
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatementData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementData" /> class.
        /// </summary>
        /// <param name="truncated"></param>
        /// <param name="fields"></param>
        /// <param name="rows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatementData(
            bool truncated,
            global::System.Collections.Generic.IList<string>? fields,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? rows)
        {
            this.Fields = fields;
            this.Rows = rows;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementData" /> class.
        /// </summary>
        public StatementData()
        {
        }
    }
}