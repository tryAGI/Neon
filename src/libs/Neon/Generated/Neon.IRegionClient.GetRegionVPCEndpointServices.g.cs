#nullable enable

namespace Neon
{
    public partial interface IRegionClient
    {
        /// <summary>
        /// List VPC endpoint service names for a region<br/>
        /// Lists the AWS VPC endpoint service names Neon currently offers in the<br/>
        /// given region, for PrivateLink / Neon Private Networking. Add every name<br/>
        /// returned for your region when configuring your VPC endpoint.<br/>
        /// The list is always empty for non-AWS regions, and for AWS regions without PrivateLink.<br/>
        /// **Note:** Not all regions are available to all organizations. Pass the `org_id`<br/>
        /// parameter to check region availability for your organization. Unknown regions,<br/>
        /// and regions not available to the caller, return 404.
        /// </summary>
        /// <param name="regionId"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RegionVPCEndpointServicesResponse> GetRegionVPCEndpointServicesAsync(
            string regionId,
            string? orgId = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List VPC endpoint service names for a region<br/>
        /// Lists the AWS VPC endpoint service names Neon currently offers in the<br/>
        /// given region, for PrivateLink / Neon Private Networking. Add every name<br/>
        /// returned for your region when configuring your VPC endpoint.<br/>
        /// The list is always empty for non-AWS regions, and for AWS regions without PrivateLink.<br/>
        /// **Note:** Not all regions are available to all organizations. Pass the `org_id`<br/>
        /// parameter to check region availability for your organization. Unknown regions,<br/>
        /// and regions not available to the caller, return 404.
        /// </summary>
        /// <param name="regionId"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.RegionVPCEndpointServicesResponse>> GetRegionVPCEndpointServicesAsResponseAsync(
            string regionId,
            string? orgId = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}