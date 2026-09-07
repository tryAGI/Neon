#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Update a trigger<br/>
        /// Applies a partial update. The required `type` discriminator must identify<br/>
        /// the existing trigger kind; the only currently supported type is<br/>
        /// `schedule`. Editing an inherited trigger creates a child-local shadow<br/>
        /// with the same `trigger_id`; it remains disabled unless this request<br/>
        /// explicitly enables it. Updating the schedule or enabled state increments<br/>
        /// `version` and recomputes `next_run_at`.<br/>
        /// Disabling stops future scheduling but does not cancel occurrences already<br/>
        /// committed for delivery.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="triggerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.TriggerResponse> UpdateProjectBranchTriggerAsync(
            string projectId,
            string branchId,
            string triggerId,

            global::Neon.TriggerUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a trigger<br/>
        /// Applies a partial update. The required `type` discriminator must identify<br/>
        /// the existing trigger kind; the only currently supported type is<br/>
        /// `schedule`. Editing an inherited trigger creates a child-local shadow<br/>
        /// with the same `trigger_id`; it remains disabled unless this request<br/>
        /// explicitly enables it. Updating the schedule or enabled state increments<br/>
        /// `version` and recomputes `next_run_at`.<br/>
        /// Disabling stops future scheduling but does not cancel occurrences already<br/>
        /// committed for delivery.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="triggerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.TriggerResponse>> UpdateProjectBranchTriggerAsResponseAsync(
            string projectId,
            string branchId,
            string triggerId,

            global::Neon.TriggerUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}