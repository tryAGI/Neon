#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Retrieve connection URI<br/>
        /// Retrieves a connection URI for the specified database.<br/>
        /// The URI uses the standard PostgreSQL connection string format. Set `pooled=true` to include the `-pooler` suffix for a connection pooler URI.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="endpointId"></param>
        /// <param name="databaseName"></param>
        /// <param name="roleName"></param>
        /// <param name="pooled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ConnectionURIResponse> GetConnectionURIAsync(
            string projectId,
            string databaseName,
            string roleName,
            string? branchId = default,
            string? endpointId = default,
            bool? pooled = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve connection URI<br/>
        /// Retrieves a connection URI for the specified database.<br/>
        /// The URI uses the standard PostgreSQL connection string format. Set `pooled=true` to include the `-pooler` suffix for a connection pooler URI.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="endpointId"></param>
        /// <param name="databaseName"></param>
        /// <param name="roleName"></param>
        /// <param name="pooled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ConnectionURIResponse>> GetConnectionURIAsResponseAsync(
            string projectId,
            string databaseName,
            string roleName,
            string? branchId = default,
            string? endpointId = default,
            bool? pooled = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}