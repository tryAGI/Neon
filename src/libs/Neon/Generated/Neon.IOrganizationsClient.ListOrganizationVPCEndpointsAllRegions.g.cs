#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List VPC endpoints across all regions<br/>
        /// Retrieves the list of VPC endpoints for the specified Neon organization across all regions.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.VPCEndpointsWithRegionResponse> ListOrganizationVPCEndpointsAllRegionsAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}