
#nullable enable

namespace Neon
{
    /// <summary>
    /// A list of IP addresses that are allowed to connect to the compute endpoint.<br/>
    /// If the list is empty or not set, all IP addresses are allowed.<br/>
    /// If protected_branches_only is true, the list will be applied only to protected branches.
    /// </summary>
    public sealed partial class AllowedIps
    {
        /// <summary>
        /// A list of IP addresses that are allowed to connect to the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ips")]
        public global::System.Collections.Generic.IList<string>? Ips { get; set; }

        /// <summary>
        /// If true, the list will be applied only to protected branches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected_branches_only")]
        public bool? ProtectedBranchesOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedIps" /> class.
        /// </summary>
        /// <param name="ips">
        /// A list of IP addresses that are allowed to connect to the endpoint.
        /// </param>
        /// <param name="protectedBranchesOnly">
        /// If true, the list will be applied only to protected branches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowedIps(
            global::System.Collections.Generic.IList<string>? ips,
            bool? protectedBranchesOnly)
        {
            this.Ips = ips;
            this.ProtectedBranchesOnly = protectedBranchesOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedIps" /> class.
        /// </summary>
        public AllowedIps()
        {
        }
    }
}