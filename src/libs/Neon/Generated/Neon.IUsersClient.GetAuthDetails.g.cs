#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get request authentication details<br/>
        /// Returns auth information about the passed credentials. It can refer to an API key, Bearer token or OAuth session.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AuthDetailsResponse> GetAuthDetailsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}