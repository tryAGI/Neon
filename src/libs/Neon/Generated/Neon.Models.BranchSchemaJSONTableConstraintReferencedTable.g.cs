
#nullable enable

namespace Neon
{
    /// <summary>
    /// For foreign keys - the referenced table information
    /// </summary>
    public sealed partial class BranchSchemaJSONTableConstraintReferencedTable
    {
        /// <summary>
        /// Schema of the referenced table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schema { get; set; }

        /// <summary>
        /// Name of the referenced table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Table { get; set; }

        /// <summary>
        /// Names of the referenced columns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTableConstraintReferencedTable" /> class.
        /// </summary>
        /// <param name="schema">
        /// Schema of the referenced table
        /// </param>
        /// <param name="table">
        /// Name of the referenced table
        /// </param>
        /// <param name="columns">
        /// Names of the referenced columns
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSchemaJSONTableConstraintReferencedTable(
            string schema,
            string table,
            global::System.Collections.Generic.IList<string> columns)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTableConstraintReferencedTable" /> class.
        /// </summary>
        public BranchSchemaJSONTableConstraintReferencedTable()
        {
        }
    }
}