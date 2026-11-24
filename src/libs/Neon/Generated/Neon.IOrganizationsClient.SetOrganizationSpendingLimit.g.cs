#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Set organization spending notification threshold<br/>
        /// Sets a monthly spending notification threshold for the organization, in cents.<br/>
        /// Neon emails organization admins when monthly charges reach 80% and 100% of the threshold.<br/>
        /// The threshold is an alert only: computes keep running when it's reached.<br/>
        /// To remove the threshold, send a DELETE request to this endpoint.<br/>
        /// Available to organization admins on Launch and Scale plans only. Other plans return `422`.<br/>
        /// See [Spending notifications](https://neon.com/docs/introduction/spending-notifications).
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
        /// Set organization spending notification threshold<br/>
        /// Sets a monthly spending notification threshold for the organization, in cents.<br/>
        /// Neon emails organization admins when monthly charges reach 80% and 100% of the threshold.<br/>
        /// The threshold is an alert only: computes keep running when it's reached.<br/>
        /// To remove the threshold, send a DELETE request to this endpoint.<br/>
        /// Available to organization admins on Launch and Scale plans only. Other plans return `422`.<br/>
        /// See [Spending notifications](https://neon.com/docs/introduction/spending-notifications).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.SpendingLimitResponse>> SetOrganizationSpendingLimitAsResponseAsync(
            string orgId,

            global::Neon.SpendingLimitUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set organization spending notification threshold<br/>
        /// Sets a monthly spending notification threshold for the organization, in cents.<br/>
        /// Neon emails organization admins when monthly charges reach 80% and 100% of the threshold.<br/>
        /// The threshold is an alert only: computes keep running when it's reached.<br/>
        /// To remove the threshold, send a DELETE request to this endpoint.<br/>
        /// Available to organization admins on Launch and Scale plans only. Other plans return `422`.<br/>
        /// See [Spending notifications](https://neon.com/docs/introduction/spending-notifications).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="spendingLimitCents">
        /// Monthly spending notification threshold in cents. Must be positive.<br/>
        /// To remove a previously configured threshold, send a DELETE request<br/>
        /// to the spending_limit endpoint — `0` and `null` are rejected here.<br/>
        /// The threshold is alert-only: notifications are sent at 80% and 100%,<br/>
        /// but computes are not suspended. Setting a threshold below the<br/>
        /// period's already-accrued spend is permitted and triggers the<br/>
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