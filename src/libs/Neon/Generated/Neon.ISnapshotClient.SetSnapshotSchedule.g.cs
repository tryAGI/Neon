#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// Update backup schedule<br/>
        /// Updates the backup schedule for the specified branch.<br/>
        /// The schedule defines how often automatic snapshots are created (for example, `daily` or `weekly`). Requires a paid plan.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> SetSnapshotScheduleAsync(
            string projectId,
            string branchId,

            global::Neon.BackupSchedule request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update backup schedule<br/>
        /// Updates the backup schedule for the specified branch.<br/>
        /// The schedule defines how often automatic snapshots are created (for example, `daily` or `weekly`). Requires a paid plan.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.EmptyResponse>> SetSnapshotScheduleAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.BackupSchedule request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update backup schedule<br/>
        /// Updates the backup schedule for the specified branch.<br/>
        /// The schedule defines how often automatic snapshots are created (for example, `daily` or `weekly`). Requires a paid plan.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="schedule">
        /// List of schedule entries defining the backup frequency. At least one entry is required.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.EmptyResponse> SetSnapshotScheduleAsync(
            string projectId,
            string branchId,
            global::System.Collections.Generic.IList<global::Neon.BackupScheduleItem> schedule,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}