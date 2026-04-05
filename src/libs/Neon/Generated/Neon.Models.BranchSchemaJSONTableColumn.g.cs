
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchSchemaJSONTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Whether the column allows NULL values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nullable")]
        public bool? Nullable { get; set; }

        /// <summary>
        /// Whether the column is a generated (computed) column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated")]
        public bool? Generated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTableColumn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="nullable">
        /// Whether the column allows NULL values
        /// </param>
        /// <param name="generated">
        /// Whether the column is a generated (computed) column
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSchemaJSONTableColumn(
            string name,
            string type,
            bool? nullable,
            bool? generated)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Nullable = nullable;
            this.Generated = generated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaJSONTableColumn" /> class.
        /// </summary>
        public BranchSchemaJSONTableColumn()
        {
        }
    }
}