#nullable enable

namespace Neon
{
    public partial interface IBranchClient
    {
        /// <summary>
        /// Compare database schema<br/>
        /// Compares the schema from the specified database with another branch's schema.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="baseBranchId"></param>
        /// <param name="dbName"></param>
        /// <param name="lsn"></param>
        /// <param name="timestamp">
        /// Example: 2022-11-30T20:09:48Z
        /// </param>
        /// <param name="baseLsn"></param>
        /// <param name="baseTimestamp">
        /// Example: 2022-11-30T20:09:48Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.BranchSchemaCompareResponse> GetProjectBranchSchemaComparisonAsync(
            string projectId,
            string branchId,
            string dbName,
            string? baseBranchId = default,
            string? lsn = default,
            global::System.DateTime? timestamp = default,
            string? baseLsn = default,
            global::System.DateTime? baseTimestamp = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}