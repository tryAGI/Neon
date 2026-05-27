#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove organization spending limit<br/>
        /// Removes the configured monthly spending limit for the specified organization.<br/>
        /// Idempotent — removing an already-unset limit still succeeds.<br/>
        /// Available to organization admins on Launch and Scale plans only.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> DeleteOrganizationSpendingLimitAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove organization spending limit<br/>
        /// Removes the configured monthly spending limit for the specified organization.<br/>
        /// Idempotent — removing an already-unset limit still succeeds.<br/>
        /// Available to organization admins on Launch and Scale plans only.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.EmptyResponse>> DeleteOrganizationSpendingLimitAsResponseAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}