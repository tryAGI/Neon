
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VPCEndpointWithRegionVariant2
    {
        /// <summary>
        /// The region where the VPC endpoint is located
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VPCEndpointWithRegionVariant2" /> class.
        /// </summary>
        /// <param name="regionId">
        /// The region where the VPC endpoint is located
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VPCEndpointWithRegionVariant2(
            string regionId)
        {
            this.RegionId = regionId ?? throw new global::System.ArgumentNullException(nameof(regionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VPCEndpointWithRegionVariant2" /> class.
        /// </summary>
        public VPCEndpointWithRegionVariant2()
        {
        }
    }
}