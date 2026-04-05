#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create new auth user<br/>
        /// Creates a new user in Neon Auth.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateNewUserResponse> CreateBranchNeonAuthNewUserAsync(
            string projectId,
            string branchId,

            global::Neon.CreateBranchNeonAuthNewUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new auth user<br/>
        /// Creates a new user in Neon Auth.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthCreateNewUserResponse> CreateBranchNeonAuthNewUserAsync(
            string projectId,
            string branchId,
            string email,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}