#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Set the organization's monthly spending limit<br/>
        /// Sets the spending limit for a V3 paid organization. To remove a<br/>
        /// previously configured limit, send a DELETE request to this endpoint.<br/>
        /// When a limit is configured, email notifications are sent at 80% and<br/>
        /// 100% of the limit. Computes are not suspended by this feature.<br/>
        /// Available to organization admins on Launch and Scale plans only.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SpendingLimitResponse> SetOrganizationSpendingLimitAsync(
            string orgId,

            global::Neon.SpendingLimitUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the organization's monthly spending limit<br/>
        /// Sets the spending limit for a V3 paid organization. To remove a<br/>
        /// previously configured limit, send a DELETE request to this endpoint.<br/>
        /// When a limit is configured, email notifications are sent at 80% and<br/>
        /// 100% of the limit. Computes are not suspended by this feature.<br/>
        /// Available to organization admins on Launch and Scale plans only.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="spendingLimitCents">
        /// Monthly spending cap in cents. Must be positive. To remove a<br/>
        /// previously configured limit, send a DELETE request to the<br/>
        /// spending_limit endpoint — `0` and `null` are rejected here.<br/>
        /// The cap is alert-only: notifications fire at 80% and 100%, but<br/>
        /// computes are not suspended. Setting a cap below the period's<br/>
        /// already-accrued spend is permitted and will trigger the<br/>
        /// over-limit notification on the next worker run.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SpendingLimitResponse> SetOrganizationSpendingLimitAsync(
            string orgId,
            long spendingLimitCents,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}