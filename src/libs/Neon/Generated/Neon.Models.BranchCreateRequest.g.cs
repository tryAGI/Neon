
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::System.Collections.Generic.IList<global::Neon.BranchCreateRequestEndpointOptions>? Endpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public global::Neon.BranchCreateRequestBranch? Branch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreateRequest" /> class.
        /// </summary>
        /// <param name="endpoints"></param>
        /// <param name="branch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchCreateRequest(
            global::System.Collections.Generic.IList<global::Neon.BranchCreateRequestEndpointOptions>? endpoints,
            global::Neon.BranchCreateRequestBranch? branch)
        {
            this.Endpoints = endpoints;
            this.Branch = branch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchCreateRequest" /> class.
        /// </summary>
        public BranchCreateRequest()
        {
        }
    }
}