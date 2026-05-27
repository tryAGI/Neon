#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve request authentication details<br/>
        /// Returns authentication details for the credentials used in the request,<br/>
        /// including the credential type (API key, Bearer token, or OAuth session)<br/>
        /// and the associated identity.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AuthDetailsResponse> GetAuthDetailsAsync(
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve request authentication details<br/>
        /// Returns authentication details for the credentials used in the request,<br/>
        /// including the credential type (API key, Bearer token, or OAuth session)<br/>
        /// and the associated identity.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AuthDetailsResponse>> GetAuthDetailsAsResponseAsync(
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}