#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List VPC endpoints<br/>
        /// Retrieves the list of VPC endpoints for the specified Neon organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="regionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.VPCEndpointsResponse> ListOrganizationVPCEndpointsAsync(
            string orgId,
            string regionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}