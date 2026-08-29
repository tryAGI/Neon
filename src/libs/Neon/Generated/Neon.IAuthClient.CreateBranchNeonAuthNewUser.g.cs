#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create new auth user<br/>
        /// Creates a new user in the Neon Auth user directory for the specified branch.<br/>
        /// The user is created in the `neon_auth.users_sync` table and can immediately authenticate<br/>
        /// using the branch's configured auth providers.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateNewUserResponse> CreateBranchNeonAuthNewUserAsync(
            string projectId,
            string branchId,

            global::Neon.CreateBranchNeonAuthNewUserRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new auth user<br/>
        /// Creates a new user in the Neon Auth user directory for the specified branch.<br/>
        /// The user is created in the `neon_auth.users_sync` table and can immediately authenticate<br/>
        /// using the branch's configured auth providers.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthCreateNewUserResponse>> CreateBranchNeonAuthNewUserAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.CreateBranchNeonAuthNewUserRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new auth user<br/>
        /// Creates a new user in the Neon Auth user directory for the specified branch.<br/>
        /// The user is created in the `neon_auth.users_sync` table and can immediately authenticate<br/>
        /// using the branch's configured auth providers.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="email">
        /// Email address of the new Neon Auth user to create.
        /// </param>
        /// <param name="name">
        /// Display name for the new user. Optional. Pair with the required email field when creating a new user.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateNewUserResponse> CreateBranchNeonAuthNewUserAsync(
            string projectId,
            string branchId,
            string email,
            string? name = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}