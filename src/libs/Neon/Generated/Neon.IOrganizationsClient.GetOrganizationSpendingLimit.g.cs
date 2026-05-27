#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve organization spending limit<br/>
        /// Returns the configured monthly spending limit for the specified organization.<br/>
        /// `spending_limit_cents: null` indicates that no limit is currently set.<br/>
        /// Available to organization members with read access on Launch and Scale plans only.
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
        /// Retrieve organization spending limit<br/>
        /// Returns the configured monthly spending limit for the specified organization.<br/>
        /// `spending_limit_cents: null` indicates that no limit is currently set.<br/>
        /// Available to organization members with read access on Launch and Scale plans only.
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