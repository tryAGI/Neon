
#nullable enable

namespace Neon
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionVPCEndpointServicesResponse
    {
        /// <summary>
        /// Example: aws-us-east-1
        /// </summary>
        /// <example>aws-us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegionId { get; set; }

        /// <summary>
        /// Fully-qualified AWS VPC endpoint service names. Always empty for non-AWS regions, and for AWS regions without PrivateLink.<br/>
        /// Example: [com.amazonaws.vpce.us-east-1.vpce-svc-01aeec2f4b558bc22]
        /// </summary>
        /// <example>[com.amazonaws.vpce.us-east-1.vpce-svc-01aeec2f4b558bc22]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpc_endpoint_service_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VpcEndpointServiceNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionVPCEndpointServicesResponse" /> class.
        /// </summary>
        /// <param name="regionId">
        /// Example: aws-us-east-1
        /// </param>
        /// <param name="vpcEndpointServiceNames">
        /// Fully-qualified AWS VPC endpoint service names. Always empty for non-AWS regions, and for AWS regions without PrivateLink.<br/>
        /// Example: [com.amazonaws.vpce.us-east-1.vpce-svc-01aeec2f4b558bc22]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionVPCEndpointServicesResponse(
            string regionId,
            global::System.Collections.Generic.IList<string> vpcEndpointServiceNames)
        {
            this.RegionId = regionId ?? throw new global::System.ArgumentNullException(nameof(regionId));
            this.VpcEndpointServiceNames = vpcEndpointServiceNames ?? throw new global::System.ArgumentNullException(nameof(vpcEndpointServiceNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionVPCEndpointServicesResponse" /> class.
        /// </summary>
        public RegionVPCEndpointServicesResponse()
        {
        }

    }
}