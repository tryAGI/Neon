#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Delete a trigger<br/>
        /// Deletes a branch-local trigger or writes a branch-local tombstone for an<br/>
        /// inherited trigger so it does not reappear. Deletion stops future<br/>
        /// scheduling or storage-event matching but does not cancel invocations<br/>
        /// already committed for delivery. The supported trigger types are<br/>
        /// `schedule` and `storage_object_created`.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="triggerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteProjectBranchTriggerAsync(
            string projectId,
            string branchId,
            string triggerId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a trigger<br/>
        /// Deletes a branch-local trigger or writes a branch-local tombstone for an<br/>
        /// inherited trigger so it does not reappear. Deletion stops future<br/>
        /// scheduling or storage-event matching but does not cancel invocations<br/>
        /// already committed for delivery. The supported trigger types are<br/>
        /// `schedule` and `storage_object_created`.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="triggerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> DeleteProjectBranchTriggerAsResponseAsync(
            string projectId,
            string branchId,
            string triggerId,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}