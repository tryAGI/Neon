#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove organization spending notification threshold<br/>
        /// Removes the organization's monthly spending notification threshold, which stops the spending notification emails.<br/>
        /// Idempotent: removing an already-unset threshold still succeeds.<br/>
        /// Available to organization admins on Launch and Scale plans only. Other plans return `422`.
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
        /// Remove organization spending notification threshold<br/>
        /// Removes the organization's monthly spending notification threshold, which stops the spending notification emails.<br/>
        /// Idempotent: removing an already-unset threshold still succeeds.<br/>
        /// Available to organization admins on Launch and Scale plans only. Other plans return `422`.
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