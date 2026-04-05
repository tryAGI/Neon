#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve VPC endpoint details<br/>
        /// Retrieves the current state and configuration details of a specified VPC endpoint.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="regionId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.VPCEndpointDetails> GetOrganizationVPCEndpointDetailsAsync(
            string orgId,
            string regionId,
            string vpcEndpointId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}