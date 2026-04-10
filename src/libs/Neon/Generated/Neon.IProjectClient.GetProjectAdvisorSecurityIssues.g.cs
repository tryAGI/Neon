#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Get advisor issues<br/>
        /// Analyzes the database for security and performance issues.<br/>
        /// Returns a list of issues categorized by severity (ERROR, WARN, INFO).<br/>
        /// Requires read access to the project and Data API enabled.
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="databaseName"></param>
        /// <param name="category">
        /// Category of an advisor issue
        /// </param>
        /// <param name="minSeverity"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.GetProjectAdvisorSecurityIssuesResponse> GetProjectAdvisorSecurityIssuesAsync(
            string projectId,
            string? branchId = default,
            string? databaseName = default,
            global::Neon.AdvisorCategory? category = default,
            global::Neon.GetProjectAdvisorSecurityIssuesMinSeverity? minSeverity = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}