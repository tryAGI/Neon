#nullable enable

namespace Neon
{
    public partial interface IConsumptionClient
    {
        /// <summary>
        /// Retrieve project consumption metrics (legacy plans)<br/>
        /// Retrieves consumption metrics for Scale, Business, and Enterprise plan projects. History begins at the time of upgrade.<br/>
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
        /// <param name="includeV1Metrics"></param>
        /// <param name="metrics"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectResponse, global::Neon.PaginationResponse>> GetConsumptionHistoryPerProjectAsync(
            global::System.DateTime from,
            global::System.DateTime to,
            global::Neon.ConsumptionHistoryGranularity granularity,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            string? orgId = default,
            bool? includeV1Metrics = default,
            global::System.Collections.Generic.IList<string>? metrics = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}