#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Retrieve an OAuth client<br/>
        /// Returns an OAuth client registered with the branch's Neon Auth OAuth provider.<br/>
        /// The client secret is never returned.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthClient> GetNeonAuthOAuthClientAsync(
            string projectId,
            string branchId,
            string clientId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve an OAuth client<br/>
        /// Returns an OAuth client registered with the branch's Neon Auth OAuth provider.<br/>
        /// The client secret is never returned.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOAuthClient>> GetNeonAuthOAuthClientAsResponseAsync(
            string projectId,
            string branchId,
            string clientId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}