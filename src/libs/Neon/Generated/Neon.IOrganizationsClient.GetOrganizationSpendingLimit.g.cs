#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve organization spending notification threshold<br/>
        /// Returns the organization's monthly spending notification threshold, in cents.<br/>
        /// Neon emails organization admins when monthly charges reach 80% and 100% of the threshold.<br/>
        /// The threshold is an alert only: it doesn't cap spending or suspend computes.<br/>
        /// `spending_limit_cents: null` indicates that no threshold is set.<br/>
        /// Available to organization members with read access on Launch and Scale plans only. Other plans return `422`.<br/>
        /// See [Spending notifications](https://neon.com/docs/introduction/spending-notifications).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SpendingLimitResponse> GetOrganizationSpendingLimitAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve organization spending notification threshold<br/>
        /// Returns the organization's monthly spending notification threshold, in cents.<br/>
        /// Neon emails organization admins when monthly charges reach 80% and 100% of the threshold.<br/>
        /// The threshold is an alert only: it doesn't cap spending or suspend computes.<br/>
        /// `spending_limit_cents: null` indicates that no threshold is set.<br/>
        /// Available to organization members with read access on Launch and Scale plans only. Other plans return `422`.<br/>
        /// See [Spending notifications](https://neon.com/docs/introduction/spending-notifications).
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.SpendingLimitResponse>> GetOrganizationSpendingLimitAsResponseAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}