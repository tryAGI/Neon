#nullable enable

namespace Neon
{
    public partial interface IConsumptionClient
    {
        /// <summary>
        /// Retrieve project consumption metrics<br/>
        /// Retrieves consumption metrics for Launch, Scale, Agent, and Enterprise plan projects. History begins at the time of upgrade.<br/>
        /// Results are ordered by time in ascending order (oldest to newest).<br/>
        /// Issuing a call to this API does not wake a project's compute endpoint.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="granularity"></param>
        /// <param name="orgId"></param>
        /// <param name="metrics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>> GetConsumptionHistoryPerProjectV2Async(
            global::System.DateTime from,
            global::System.DateTime to,
            global::Neon.ConsumptionHistoryGranularity granularity,
            string orgId,
            global::System.Collections.Generic.IList<string> metrics,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}