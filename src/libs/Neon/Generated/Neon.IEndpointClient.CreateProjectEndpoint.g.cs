#nullable enable

namespace Neon
{
    public partial interface IEndpointClient
    {
        /// <summary>
        /// Create compute endpoint<br/>
        /// Creates a compute endpoint for the specified branch.<br/>
        /// An endpoint is a Neon compute instance.<br/>
        /// There is a maximum of one read-write compute endpoint per branch.<br/>
        /// If the specified branch already has a read-write compute endpoint, the operation fails.<br/>
        /// A branch can have multiple read-only compute endpoints.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain `branch_id` by listing the project's branches.<br/>
        /// A `branch_id` has a `br-` prefix.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.tech/docs/introduction/regions/).<br/>
        /// For more information about compute endpoints, see [Manage computes](https://neon.tech/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> CreateProjectEndpointAsync(
            string projectId,

            global::Neon.EndpointCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create compute endpoint<br/>
        /// Creates a compute endpoint for the specified branch.<br/>
        /// An endpoint is a Neon compute instance.<br/>
        /// There is a maximum of one read-write compute endpoint per branch.<br/>
        /// If the specified branch already has a read-write compute endpoint, the operation fails.<br/>
        /// A branch can have multiple read-only compute endpoints.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain `branch_id` by listing the project's branches.<br/>
        /// A `branch_id` has a `br-` prefix.<br/>
        /// For supported regions and `region_id` values, see [Regions](https://neon.tech/docs/introduction/regions/).<br/>
        /// For more information about compute endpoints, see [Manage computes](https://neon.tech/docs/manage/endpoints/).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="endpoint"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> CreateProjectEndpointAsync(
            string projectId,
            global::Neon.EndpointCreateRequestEndpoint endpoint,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}