
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchSchemaJSONTableConstraint
    {
        /// <summary>
        /// Type of constraint. Possible values: `primary_key`, `unique`, `foreign_key`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Column names participating in this constraint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// Optional name of the constraint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// For foreign keys - the referenced table information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_table")]
        public global::Neon.BranchSchemaJSONTableConstraintReferencedTable? ReferencedTable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTableConstraint" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of constraint. Possible values: `primary_key`, `unique`, `foreign_key`
        /// </param>
        /// <param name="columns">
        /// Column names participating in this constraint
        /// </param>
        /// <param name="name">
        /// Optional name of the constraint
        /// </param>
        /// <param name="referencedTable">
        /// For foreign keys - the referenced table information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSchemaJSONTableConstraint(
            string type,
            global::System.Collections.Generic.IList<string> columns,
            string? name,
            global::Neon.BranchSchemaJSONTableConstraintReferencedTable? referencedTable)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.Name = name;
            this.ReferencedTable = referencedTable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTableConstraint" /> class.
        /// </summary>
        public BranchSchemaJSONTableConstraint()
        {
        }
    }
}