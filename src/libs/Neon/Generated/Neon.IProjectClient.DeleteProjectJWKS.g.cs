#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Delete JWKS URL<br/>
        /// Removes the specified JWKS URL from the project.<br/>
        /// JWTs signed by keys from the removed URL can no longer authenticate to the project's endpoints.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="jwksId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.Jwks> DeleteProjectJWKSAsync(
            string projectId,
            string jwksId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete JWKS URL<br/>
        /// Removes the specified JWKS URL from the project.<br/>
        /// JWTs signed by keys from the removed URL can no longer authenticate to the project's endpoints.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="jwksId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.Jwks>> DeleteProjectJWKSAsResponseAsync(
            string projectId,
            string jwksId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}