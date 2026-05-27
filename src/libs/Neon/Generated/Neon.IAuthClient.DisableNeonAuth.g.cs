#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Disable Neon Auth for the branch<br/>
        /// Disables the Neon Auth integration for the specified branch, removing the connection<br/>
        /// to the authentication provider.<br/>
        /// If `delete_data` is `true`, also deletes the `neon_auth` schema and all associated tables<br/>
        /// from the branch database.<br/>
        /// The integration can be re-enabled by calling `POST /projects/{project_id}/branches/{branch_id}/auth`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DisableNeonAuthAsync(
            string projectId,
            string branchId,

            global::Neon.DisableNeonAuthRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disable Neon Auth for the branch<br/>
        /// Disables the Neon Auth integration for the specified branch, removing the connection<br/>
        /// to the authentication provider.<br/>
        /// If `delete_data` is `true`, also deletes the `neon_auth` schema and all associated tables<br/>
        /// from the branch database.<br/>
        /// The integration can be re-enabled by calling `POST /projects/{project_id}/branches/{branch_id}/auth`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> DisableNeonAuthAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.DisableNeonAuthRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disable Neon Auth for the branch<br/>
        /// Disables the Neon Auth integration for the specified branch, removing the connection<br/>
        /// to the authentication provider.<br/>
        /// If `delete_data` is `true`, also deletes the `neon_auth` schema and all associated tables<br/>
        /// from the branch database.<br/>
        /// The integration can be re-enabled by calling `POST /projects/{project_id}/branches/{branch_id}/auth`.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="deleteData">
        /// If true, deletes the `neon_auth` schema from the database<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DisableNeonAuthAsync(
            string projectId,
            string branchId,
            bool? deleteData = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}