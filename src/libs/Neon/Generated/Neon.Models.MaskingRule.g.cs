
#nullable enable

namespace Neon
{
    /// <summary>
    /// Example: {"database_name":"neondb","schema_name":"public","table_name":"users","column_name":"email","masking_function":"anon.fake_email()"}
    /// </summary>
    public sealed partial class MaskingRule
    {
        /// <summary>
        /// The name of the database containing the table to be masked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatabaseName { get; set; }

        /// <summary>
        /// The name of the schema containing the table to be masked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaName { get; set; }

        /// <summary>
        /// The name of the table containing the column to be masked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// The name of the column to be masked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnName { get; set; }

        /// <summary>
        /// The PostgreSQL Anonymizer masking function to apply.<br/>
        /// Can be a predefined function (e.g., 'anon.random_string(10)', 'anon.fake_email()')<br/>
        /// or a custom function definition (e.g., 'anon.hash(column_name)')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masking_function")]
        public string? MaskingFunction { get; set; }

        /// <summary>
        /// A literal value to set on the column when masking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masking_value")]
        public string? MaskingValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRule" /> class.
        /// </summary>
        /// <param name="databaseName">
        /// The name of the database containing the table to be masked
        /// </param>
        /// <param name="schemaName">
        /// The name of the schema containing the table to be masked
        /// </param>
        /// <param name="tableName">
        /// The name of the table containing the column to be masked
        /// </param>
        /// <param name="columnName">
        /// The name of the column to be masked
        /// </param>
        /// <param name="maskingFunction">
        /// The PostgreSQL Anonymizer masking function to apply.<br/>
        /// Can be a predefined function (e.g., 'anon.random_string(10)', 'anon.fake_email()')<br/>
        /// or a custom function definition (e.g., 'anon.hash(column_name)')
        /// </param>
        /// <param name="maskingValue">
        /// A literal value to set on the column when masking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaskingRule(
            string databaseName,
            string schemaName,
            string tableName,
            string columnName,
            string? maskingFunction,
            string? maskingValue)
        {
            this.DatabaseName = databaseName ?? throw new global::System.ArgumentNullException(nameof(databaseName));
            this.SchemaName = schemaName ?? throw new global::System.ArgumentNullException(nameof(schemaName));
            this.TableName = tableName ?? throw new global::System.ArgumentNullException(nameof(tableName));
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.MaskingFunction = maskingFunction;
            this.MaskingValue = maskingValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRule" /> class.
        /// </summary>
        public MaskingRule()
        {
        }
    }
}