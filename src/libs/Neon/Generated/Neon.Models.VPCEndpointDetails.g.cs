
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VPCEndpointDetails
    {
        /// <summary>
        /// The VPC endpoint ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpc_endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VpcEndpointId { get; set; }

        /// <summary>
        /// A descriptive label for the VPC endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The current state of the VPC endpoint. Possible values are<br/>
        /// `new` (just configured, pending acceptance) or `accepted`<br/>
        /// (VPC connection was accepted by Neon).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// The number of projects that are restricted to use this VPC endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_restricted_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumRestrictedProjects { get; set; }

        /// <summary>
        /// A list of example projects that are restricted to use this VPC endpoint.<br/>
        /// There are at most 3 projects in the list, even if more projects are restricted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_restricted_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExampleRestrictedProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VPCEndpointDetails" /> class.
        /// </summary>
        /// <param name="vpcEndpointId">
        /// The VPC endpoint ID
        /// </param>
        /// <param name="label">
        /// A descriptive label for the VPC endpoint
        /// </param>
        /// <param name="state">
        /// The current state of the VPC endpoint. Possible values are<br/>
        /// `new` (just configured, pending acceptance) or `accepted`<br/>
        /// (VPC connection was accepted by Neon).
        /// </param>
        /// <param name="numRestrictedProjects">
        /// The number of projects that are restricted to use this VPC endpoint.
        /// </param>
        /// <param name="exampleRestrictedProjects">
        /// A list of example projects that are restricted to use this VPC endpoint.<br/>
        /// There are at most 3 projects in the list, even if more projects are restricted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VPCEndpointDetails(
            string vpcEndpointId,
            string label,
            string state,
            int numRestrictedProjects,
            global::System.Collections.Generic.IList<string> exampleRestrictedProjects)
        {
            this.VpcEndpointId = vpcEndpointId ?? throw new global::System.ArgumentNullException(nameof(vpcEndpointId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.NumRestrictedProjects = numRestrictedProjects;
            this.ExampleRestrictedProjects = exampleRestrictedProjects ?? throw new global::System.ArgumentNullException(nameof(exampleRestrictedProjects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VPCEndpointDetails" /> class.
        /// </summary>
        public VPCEndpointDetails()
        {
        }
    }
}