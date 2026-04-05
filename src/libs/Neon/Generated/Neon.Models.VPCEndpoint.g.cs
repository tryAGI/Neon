
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VPCEndpoint
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VPCEndpoint" /> class.
        /// </summary>
        /// <param name="vpcEndpointId">
        /// The VPC endpoint ID
        /// </param>
        /// <param name="label">
        /// A descriptive label for the VPC endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VPCEndpoint(
            string vpcEndpointId,
            string label)
        {
            this.VpcEndpointId = vpcEndpointId ?? throw new global::System.ArgumentNullException(nameof(vpcEndpointId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VPCEndpoint" /> class.
        /// </summary>
        public VPCEndpoint()
        {
        }
    }
}