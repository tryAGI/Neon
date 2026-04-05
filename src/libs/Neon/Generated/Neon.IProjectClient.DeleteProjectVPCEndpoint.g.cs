#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Delete VPC endpoint restriction<br/>
        /// Removes the specified VPC endpoint restriction from a Neon project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="vpcEndpointId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteProjectVPCEndpointAsync(
            string projectId,
            string vpcEndpointId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}