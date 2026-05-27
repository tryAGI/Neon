#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove organization member<br/>
        /// Removes the specified member from the organization.<br/>
        /// Only organization admins can perform this action.<br/>
        /// The last admin in an organization cannot be removed.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> RemoveOrganizationMemberAsync(
            string orgId,
            string memberId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove organization member<br/>
        /// Removes the specified member from the organization.<br/>
        /// Only organization admins can perform this action.<br/>
        /// The last admin in an organization cannot be removed.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.EmptyResponse>> RemoveOrganizationMemberAsResponseAsync(
            string orgId,
            string memberId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}