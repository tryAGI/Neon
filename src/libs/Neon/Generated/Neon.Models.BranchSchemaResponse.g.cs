
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchSchemaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sql")]
        public string? Sql { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public global::Neon.BranchSchemaJSON? Json { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaResponse" /> class.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="json"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSchemaResponse(
            string? sql,
            global::Neon.BranchSchemaJSON? json)
        {
            this.Sql = sql;
            this.Json = json;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaResponse" /> class.
        /// </summary>
        public BranchSchemaResponse()
        {
        }
    }
}