#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Create role<br/>
        /// Creates a Postgres role in the specified branch.<br/>
        /// For related information, see [Manage roles](https://neon.com/docs/manage/roles/).<br/>
        /// Connections established to the active compute endpoint will be dropped.<br/>
        /// If the compute endpoint is idle, the endpoint becomes active for a short period of time and is suspended afterward.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RoleOperations> CreateProjectBranchRoleAsync(
            string projectId,
            string branchId,

            global::Neon.RoleCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create role<br/>
        /// Creates a Postgres role in the specified branch.<br/>
        /// For related information, see [Manage roles](https://neon.com/docs/manage/roles/).<br/>
        /// Connections established to the active compute endpoint will be dropped.<br/>
        /// If the compute endpoint is idle, the endpoint becomes active for a short period of time and is suspended afterward.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.RoleOperations>> CreateProjectBranchRoleAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.RoleCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create role<br/>
        /// Creates a Postgres role in the specified branch.<br/>
        /// For related information, see [Manage roles](https://neon.com/docs/manage/roles/).<br/>
        /// Connections established to the active compute endpoint will be dropped.<br/>
        /// If the compute endpoint is idle, the endpoint becomes active for a short period of time and is suspended afterward.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.RoleOperations> CreateProjectBranchRoleAsync(
            string projectId,
            string branchId,
            global::Neon.RoleCreateRequestRole role,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}