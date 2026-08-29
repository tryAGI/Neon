
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BranchCreateRequest
    {
        /// <summary>
        /// Compute endpoints to create together with the branch. If omitted, the branch is created without any compute endpoint. Endpoints can be added to the branch separately after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::System.Collections.Generic.IList<global::Neon.BranchCreateRequestEndpointOptions>? Endpoints { get; set; }

        /// <summary>
        /// Optional configuration for the new branch, for example `name`, `parent_id` (fork from a branch), `parent_lsn` or `parent_timestamp` (point-in-time branching), and `protected`.
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
        /// <param name="endpoints">
        /// Compute endpoints to create together with the branch. If omitted, the branch is created without any compute endpoint. Endpoints can be added to the branch separately after creation.
        /// </param>
        /// <param name="branch">
        /// Optional configuration for the new branch, for example `name`, `parent_id` (fork from a branch), `parent_lsn` or `parent_timestamp` (point-in-time branching), and `protected`.
        /// </param>
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