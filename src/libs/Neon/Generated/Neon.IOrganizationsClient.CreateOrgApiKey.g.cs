#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create organization API key<br/>
        /// Creates an API key for the specified organization.<br/>
        /// The `key_name` is a user-specified name for the key.<br/>
        /// This method returns an `id` and `key`. The `key` is a randomly generated, 64-bit token required to access the Neon API.<br/>
        /// API keys can also be managed in the Neon Console.<br/>
        /// See [Manage API keys](https://neon.tech/docs/manage/api-keys/).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OrgApiKeyCreateResponse> CreateOrgApiKeyAsync(
            string orgId,

            global::Neon.OrgApiKeyCreateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create organization API key<br/>
        /// Creates an API key for the specified organization.<br/>
        /// The `key_name` is a user-specified name for the key.<br/>
        /// This method returns an `id` and `key`. The `key` is a randomly generated, 64-bit token required to access the Neon API.<br/>
        /// API keys can also be managed in the Neon Console.<br/>
        /// See [Manage API keys](https://neon.tech/docs/manage/api-keys/).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OrgApiKeyCreateResponse> CreateOrgApiKeyAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}