#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Set VPC endpoint restriction<br/>
        /// Sets or updates a VPC endpoint restriction for a Neon project.<br/>
        /// When a VPC endpoint restriction is set, the project only accepts connections<br/>
        /// from the specified VPC.<br/>
        /// A VPC endpoint can be set as a restriction only after it is assigned to the<br/>
        /// parent organization of the Neon project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task AssignProjectVPCEndpointAsync(
            string projectId,
            string vpcEndpointId,

            global::Neon.VPCEndpointAssignment request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set VPC endpoint restriction<br/>
        /// Sets or updates a VPC endpoint restriction for a Neon project.<br/>
        /// When a VPC endpoint restriction is set, the project only accepts connections<br/>
        /// from the specified VPC.<br/>
        /// A VPC endpoint can be set as a restriction only after it is assigned to the<br/>
        /// parent organization of the Neon project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="label"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AssignProjectVPCEndpointAsync(
            string projectId,
            string vpcEndpointId,
            string label,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}