#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Delete VPC endpoint<br/>
        /// Deletes the VPC endpoint from the specified Neon organization.<br/>
        /// If you delete a VPC endpoint from a Neon organization, that VPC endpoint cannot<br/>
        /// be added back to the Neon organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="regionId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOrganizationVPCEndpointAsync(
            string orgId,
            string regionId,
            string vpcEndpointId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}