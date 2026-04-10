#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get request authentication details<br/>
        /// Returns auth information about the passed credentials. It can refer to an API key, Bearer token or OAuth session.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AuthDetailsResponse> GetAuthDetailsAsync(
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}