
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FinalizeRestoreBranchRequest
    {
        /// <summary>
        /// Name for the replaced branch. If omitted, a unique name is generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizeRestoreBranchRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the replaced branch. If omitted, a unique name is generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinalizeRestoreBranchRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizeRestoreBranchRequest" /> class.
        /// </summary>
        public FinalizeRestoreBranchRequest()
        {
        }

    }
}