#nullable enable

namespace Neon
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Retrieve the organization's monthly spending limit<br/>
        /// Returns the configured spending limit for a V3 paid organization.<br/>
        /// `spending_limit_cents: null` indicates that no limit is currently<br/>
        /// set. Available to organization members with read access on Launch<br/>
        /// and Scale plans only.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.SpendingLimitResponse> GetOrganizationSpendingLimitAsync(
            string orgId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}