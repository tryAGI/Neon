#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve current user details<br/>
        /// Retrieves information about the current Neon user account.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CurrentUserInfoResponse> GetCurrentUserInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}