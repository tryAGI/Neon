#nullable enable

namespace Neon
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Revoke API key<br/>
        /// Revokes the specified API key.<br/>
        /// An API key that is no longer needed can be revoked.<br/>
        /// This action cannot be reversed.<br/>
        /// API keys can also be managed in the Neon Console.<br/>
        /// See [Manage API keys](https://neon.com/docs/manage/api-keys/).
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ApiKeyRevokeResponse> RevokeApiKeyAsync(
            long keyId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke API key<br/>
        /// Revokes the specified API key.<br/>
        /// An API key that is no longer needed can be revoked.<br/>
        /// This action cannot be reversed.<br/>
        /// API keys can also be managed in the Neon Console.<br/>
        /// See [Manage API keys](https://neon.com/docs/manage/api-keys/).
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ApiKeyRevokeResponse>> RevokeApiKeyAsResponseAsync(
            long keyId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}