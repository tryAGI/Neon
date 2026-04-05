
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchSchemaCompareResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff")]
        public string? Diff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaCompareResponse" /> class.
        /// </summary>
        /// <param name="diff"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchSchemaCompareResponse(
            string? diff)
        {
            this.Diff = diff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchSchemaCompareResponse" /> class.
        /// </summary>
        public BranchSchemaCompareResponse()
        {
        }
    }
}