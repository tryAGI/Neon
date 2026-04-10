#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Retrieve database schema<br/>
        /// Retrieves the schema from the specified database. The `lsn` and `timestamp` values cannot be specified at the same time. If both are omitted, the database schema is retrieved from database's head.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="dbName"></param>
        /// <param name="lsn"></param>
        /// <param name="timestamp">
        /// Example: 2022-11-30T20:09:48Z
        /// </param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchSchemaResponse> GetProjectBranchSchemaAsync(
            string projectId,
            string branchId,
            string dbName,
            string? lsn = default,
            global::System.DateTime? timestamp = default,
            string? format = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}