#nullable enable

namespace Neon
{
    public partial interface IConsumptionClient
    {
        /// <summary>
        /// Retrieve branch consumption metrics<br/>
        /// Returns consumption metrics for each branch across one or more projects listed in<br/>
        /// `project_ids` (1 to 100 projects). Available for accounts on paid usage-based Launch, Scale,<br/>
        /// Agent, and Enterprise plans.<br/>
        /// History starts when the account first ingests branch-level consumption data.<br/>
        /// The `metrics` query parameter is required. Only these six values are supported on this<br/>
        /// endpoint:<br/>
        /// `compute_unit_seconds`, `root_branch_bytes_month`, `child_branch_bytes_month`,<br/>
        /// `instant_restore_bytes_month`, `public_network_transfer_bytes`, `private_network_transfer_bytes`.<br/>
        /// This endpoint does not support `extra_branches_month` or `snapshot_storage_bytes_month`.<br/>
        /// Use `GET /consumption_history/v2/projects` for those.<br/>
        /// Consumption metrics within each branch are returned in ascending time order (oldest first).<br/>
        /// This request does not wake project computes.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="branchIds"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="granularity"></param>
        /// <param name="orgId"></param>
        /// <param name="metrics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AllOf<global::Neon.ConsumptionHistoryPerBranchV2Response, global::Neon.PaginationResponse>> GetConsumptionHistoryPerBranchV2Async(
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.DateTime from,
            global::System.DateTime to,
            global::Neon.ConsumptionHistoryGranularity granularity,
            string orgId,
            global::System.Collections.Generic.IList<string> metrics,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? branchIds = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve branch consumption metrics<br/>
        /// Returns consumption metrics for each branch across one or more projects listed in<br/>
        /// `project_ids` (1 to 100 projects). Available for accounts on paid usage-based Launch, Scale,<br/>
        /// Agent, and Enterprise plans.<br/>
        /// History starts when the account first ingests branch-level consumption data.<br/>
        /// The `metrics` query parameter is required. Only these six values are supported on this<br/>
        /// endpoint:<br/>
        /// `compute_unit_seconds`, `root_branch_bytes_month`, `child_branch_bytes_month`,<br/>
        /// `instant_restore_bytes_month`, `public_network_transfer_bytes`, `private_network_transfer_bytes`.<br/>
        /// This endpoint does not support `extra_branches_month` or `snapshot_storage_bytes_month`.<br/>
        /// Use `GET /consumption_history/v2/projects` for those.<br/>
        /// Consumption metrics within each branch are returned in ascending time order (oldest first).<br/>
        /// This request does not wake project computes.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="branchIds"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="granularity"></param>
        /// <param name="orgId"></param>
        /// <param name="metrics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.AllOf<global::Neon.ConsumptionHistoryPerBranchV2Response, global::Neon.PaginationResponse>>> GetConsumptionHistoryPerBranchV2AsResponseAsync(
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.DateTime from,
            global::System.DateTime to,
            global::Neon.ConsumptionHistoryGranularity granularity,
            string orgId,
            global::System.Collections.Generic.IList<string> metrics,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? branchIds = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}