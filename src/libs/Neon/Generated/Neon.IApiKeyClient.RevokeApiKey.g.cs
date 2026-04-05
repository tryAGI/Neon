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
        /// You can obtain `key_id` values by listing the API keys for your Neon account.<br/>
        /// API keys can also be managed in the Neon Console.<br/>
        /// See [Manage API keys](https://neon.tech/docs/manage/api-keys/).
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ApiKeyRevokeResponse> RevokeApiKeyAsync(
            long keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}