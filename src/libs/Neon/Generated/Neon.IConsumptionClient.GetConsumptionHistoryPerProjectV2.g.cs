#nullable enable

namespace Neon
{
    public partial interface IConsumptionClient
    {
        /// <summary>
        /// Retrieve project consumption metrics<br/>
        /// Returns consumption metrics for up to `limit` projects per page. If `project_ids` is omitted,<br/>
        /// projects in the organization are included across pages (use `cursor`). If `project_ids` is<br/>
        /// provided, the response is limited to those projects (up to 100). Available for accounts on<br/>
        /// Launch, Scale, Agent, Business, and Enterprise plans.<br/>
        /// History starts when the account upgrades to an eligible plan.<br/>
        /// The `metrics` query parameter is required. Supported values:<br/>
        /// `compute_unit_seconds`, `root_branch_bytes_month`, `child_branch_bytes_month`,<br/>
        /// `instant_restore_bytes_month`, `public_network_transfer_bytes`, `private_network_transfer_bytes`,<br/>
        /// `extra_branches_month`, `snapshot_storage_bytes_month`,<br/>
        /// `functions_active_capacity_microseconds`, `functions_waiting_capacity_microseconds`,<br/>
        /// `functions_invocations`, `functions_egress_bytes`.<br/>
        /// Consumption metrics within each project are returned in ascending time order (oldest first).<br/>
        /// This request does not wake project computes.
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
        /// <summary>
        /// Retrieve project consumption metrics<br/>
        /// Returns consumption metrics for up to `limit` projects per page. If `project_ids` is omitted,<br/>
        /// projects in the organization are included across pages (use `cursor`). If `project_ids` is<br/>
        /// provided, the response is limited to those projects (up to 100). Available for accounts on<br/>
        /// Launch, Scale, Agent, Business, and Enterprise plans.<br/>
        /// History starts when the account upgrades to an eligible plan.<br/>
        /// The `metrics` query parameter is required. Supported values:<br/>
        /// `compute_unit_seconds`, `root_branch_bytes_month`, `child_branch_bytes_month`,<br/>
        /// `instant_restore_bytes_month`, `public_network_transfer_bytes`, `private_network_transfer_bytes`,<br/>
        /// `extra_branches_month`, `snapshot_storage_bytes_month`,<br/>
        /// `functions_active_capacity_microseconds`, `functions_waiting_capacity_microseconds`,<br/>
        /// `functions_invocations`, `functions_egress_bytes`.<br/>
        /// Consumption metrics within each project are returned in ascending time order (oldest first).<br/>
        /// This request does not wake project computes.
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
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.ConsumptionHistoryPerProjectV2Response, global::Neon.PaginationResponse>>> GetConsumptionHistoryPerProjectV2AsResponseAsync(
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