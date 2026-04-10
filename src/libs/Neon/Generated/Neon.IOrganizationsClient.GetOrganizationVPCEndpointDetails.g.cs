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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.VPCEndpointDetails> GetOrganizationVPCEndpointDetailsAsync(
            string orgId,
            string regionId,
            string vpcEndpointId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}