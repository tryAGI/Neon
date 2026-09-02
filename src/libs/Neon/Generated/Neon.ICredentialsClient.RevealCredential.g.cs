#nullable enable

namespace Neon
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Reveal a credential's secrets<br/>
        /// Returns the live `api_token` and `s3_secret_access_key` of an existing<br/>
        /// credential, so a credential whose issuance response was lost can be<br/>
        /// recovered without minting a new one.<br/>
        /// This is a POST with an explicit `/reveal` verb so the secrets never ride<br/>
        /// a GET, where they would land in access logs, browser history and proxy<br/>
        /// caches. Revoked and expired credentials return 404, as does a<br/>
        /// `token_id` that does not belong to this project.<br/>
        /// A credential issued before secret retrieval was supported has no<br/>
        /// recoverable secret and returns 409 — rotate it to obtain one.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CredentialSecret> RevealCredentialAsync(
            string projectId,
            string branchId,
            string tokenId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reveal a credential's secrets<br/>
        /// Returns the live `api_token` and `s3_secret_access_key` of an existing<br/>
        /// credential, so a credential whose issuance response was lost can be<br/>
        /// recovered without minting a new one.<br/>
        /// This is a POST with an explicit `/reveal` verb so the secrets never ride<br/>
        /// a GET, where they would land in access logs, browser history and proxy<br/>
        /// caches. Revoked and expired credentials return 404, as does a<br/>
        /// `token_id` that does not belong to this project.<br/>
        /// A credential issued before secret retrieval was supported has no<br/>
        /// recoverable secret and returns 409 — rotate it to obtain one.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="tokenId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.CredentialSecret>> RevealCredentialAsResponseAsync(
            string projectId,
            string branchId,
            string tokenId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}