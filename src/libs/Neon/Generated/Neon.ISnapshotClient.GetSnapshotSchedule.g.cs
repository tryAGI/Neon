#nullable enable

namespace Neon
{
    public partial interface ISnapshotClient
    {
        /// <summary>
        /// View backup schedule<br/>
        /// View the backup schedule for the specified branch.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BackupSchedule> GetSnapshotScheduleAsync(
            string projectId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}