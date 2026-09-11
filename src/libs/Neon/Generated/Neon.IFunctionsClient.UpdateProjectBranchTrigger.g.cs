#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Update a trigger<br/>
        /// Applies a partial update. The required `type` discriminator must identify<br/>
        /// the existing trigger kind. The supported types are `schedule` and<br/>
        /// `storage_object_created`. Editing an inherited trigger creates a<br/>
        /// child-local shadow with the same `trigger_id`; it remains disabled unless<br/>
        /// this request explicitly enables it. For a schedule trigger, updating the<br/>
        /// schedule or enabled state increments `version` and recomputes<br/>
        /// `next_run_at`.<br/>
        /// Disabling stops future scheduling but does not cancel occurrences already<br/>
        /// committed for delivery. For `storage_object_created`, the configuration<br/>
        /// selects one exact bucket. An omitted object-key prefix matches every key<br/>
        /// in that bucket; a present prefix is matched byte-for-byte and<br/>
        /// case-sensitively against the full key, without path normalization or a<br/>
        /// path-segment boundary.<br/>
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
        /// the existing trigger kind. The supported types are `schedule` and<br/>
        /// `storage_object_created`. Editing an inherited trigger creates a<br/>
        /// child-local shadow with the same `trigger_id`; it remains disabled unless<br/>
        /// this request explicitly enables it. For a schedule trigger, updating the<br/>
        /// schedule or enabled state increments `version` and recomputes<br/>
        /// `next_run_at`.<br/>
        /// Disabling stops future scheduling but does not cancel occurrences already<br/>
        /// committed for delivery. For `storage_object_created`, the configuration<br/>
        /// selects one exact bucket. An omitted object-key prefix matches every key<br/>
        /// in that bucket; a present prefix is matched byte-for-byte and<br/>
        /// case-sensitively against the full key, without path normalization or a<br/>
        /// path-segment boundary.<br/>
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