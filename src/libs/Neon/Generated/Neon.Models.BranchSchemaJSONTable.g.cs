
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchSchemaJSONTable
    {
        /// <summary>
        /// Postgres schema (namespace) that contains the table, for example `public`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schema { get; set; }

        /// <summary>
        /// Name of the table within the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Columns belonging to this table, each describing a column's name and attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableColumn> Columns { get; set; }

        /// <summary>
        /// Table constraints defined in the branch schema, such as primary key, foreign key, unique, and check constraints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constraints")]
        public global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableConstraint>? Constraints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTable" /> class.
        /// </summary>
        /// <param name="schema">
        /// Postgres schema (namespace) that contains the table, for example `public`.
        /// </param>
        /// <param name="name">
        /// Name of the table within the schema.
        /// </param>
        /// <param name="columns">
        /// Columns belonging to this table, each describing a column's name and attributes.
        /// </param>
        /// <param name="constraints">
        /// Table constraints defined in the branch schema, such as primary key, foreign key, unique, and check constraints.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSchemaJSONTable(
            string schema,
            string name,
            global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableColumn> columns,
            global::System.Collections.Generic.IList<global::Neon.BranchSchemaJSONTableConstraint>? constraints)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.Constraints = constraints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTable" /> class.
        /// </summary>
        public BranchSchemaJSONTable()
        {
        }

    }
}