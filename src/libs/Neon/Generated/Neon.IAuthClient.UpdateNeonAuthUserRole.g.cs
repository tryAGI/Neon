#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update auth user role<br/>
        /// Updates the role of an auth user for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="authUserId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.UpdateNeonAuthUserRoleResponse> UpdateNeonAuthUserRoleAsync(
            string projectId,
            string branchId,
            string authUserId,

            global::Neon.UpdateNeonAuthUserRoleRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update auth user role<br/>
        /// Updates the role of an auth user for the specified project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="authUserId"></param>
        /// <param name="roles">
        /// Array of roles to assign to the user<br/>
        /// Example: [admin]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.UpdateNeonAuthUserRoleResponse> UpdateNeonAuthUserRoleAsync(
            string projectId,
            string branchId,
            string authUserId,
            global::System.Collections.Generic.IList<string> roles,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}