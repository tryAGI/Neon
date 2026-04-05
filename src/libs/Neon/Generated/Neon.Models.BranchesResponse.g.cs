
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Neon.Branch> Branches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchesResponse" /> class.
        /// </summary>
        /// <param name="branches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchesResponse(
            global::System.Collections.Generic.IList<global::Neon.Branch> branches)
        {
            this.Branches = branches ?? throw new global::System.ArgumentNullException(nameof(branches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchesResponse" /> class.
        /// </summary>
        public BranchesResponse()
        {
        }
    }
}