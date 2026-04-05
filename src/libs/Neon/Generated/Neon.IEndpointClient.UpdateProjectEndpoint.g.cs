#nullable enable

namespace Neon
{
    public partial interface IEndpointClient
    {
        /// <summary>
        /// Update compute endpoint<br/>
        /// Updates the specified compute endpoint.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain an `endpoint_id` and `branch_id` by listing your project's compute endpoints.<br/>
        /// An `endpoint_id` has an `ep-` prefix. A `branch_id` has a `br-` prefix.<br/>
        ///  For more information about compute endpoints, see [Manage computes](https://neon.tech/docs/manage/endpoints/).<br/>
        /// If the returned list of operations is not empty, the compute endpoint is not ready to use.<br/>
        /// The client must wait for the last operation to finish before using the compute endpoint.<br/>
        /// If the compute endpoint was idle before the update, it becomes active for a short period of time,<br/>
        /// and the control plane suspends it again after the update.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> UpdateProjectEndpointAsync(
            string projectId,
            string endpointId,

            global::Neon.EndpointUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update compute endpoint<br/>
        /// Updates the specified compute endpoint.<br/>
        /// You can obtain a `project_id` by listing the projects for your Neon account.<br/>
        /// You can obtain an `endpoint_id` and `branch_id` by listing your project's compute endpoints.<br/>
        /// An `endpoint_id` has an `ep-` prefix. A `branch_id` has a `br-` prefix.<br/>
        ///  For more information about compute endpoints, see [Manage computes](https://neon.tech/docs/manage/endpoints/).<br/>
        /// If the returned list of operations is not empty, the compute endpoint is not ready to use.<br/>
        /// The client must wait for the last operation to finish before using the compute endpoint.<br/>
        /// If the compute endpoint was idle before the update, it becomes active for a short period of time,<br/>
        /// and the control plane suspends it again after the update.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="endpointId"></param>
        /// <param name="endpoint"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EndpointOperations> UpdateProjectEndpointAsync(
            string projectId,
            string endpointId,
            global::Neon.EndpointUpdateRequestEndpoint endpoint,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}