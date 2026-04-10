#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List organization API keys<br/>
        /// Retrieves the API keys for the specified organization.<br/>
        /// The response does not include API key tokens. A token is only provided when creating an API key.<br/>
        /// API keys can also be managed in the Neon Console.<br/>
        /// For more information, see [Manage API keys](https://neon.tech/docs/manage/api-keys/).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Neon.OrgApiKeysListResponseItem>> ListOrgApiKeysAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}