#nullable enable

namespace Neon
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Revoke a credential<br/>
        /// Soft-deletes the credential.  Idempotent.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeCredentialAsync(
            string projectId,
            string branchId,
            string tokenId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a credential<br/>
        /// Soft-deletes the credential.  Idempotent.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> RevokeCredentialAsResponseAsync(
            string projectId,
            string branchId,
            string tokenId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}