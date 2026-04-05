#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Assign or update VPC endpoint<br/>
        /// Assigns a VPC endpoint to a Neon organization or updates its existing assignment.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="regionId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task AssignOrganizationVPCEndpointAsync(
            string orgId,
            string regionId,
            string vpcEndpointId,

            global::Neon.VPCEndpointAssignment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign or update VPC endpoint<br/>
        /// Assigns a VPC endpoint to a Neon organization or updates its existing assignment.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="regionId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="label"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AssignOrganizationVPCEndpointAsync(
            string orgId,
            string regionId,
            string vpcEndpointId,
            string label,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}