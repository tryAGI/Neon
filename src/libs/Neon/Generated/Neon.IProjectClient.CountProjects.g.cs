#nullable enable

namespace Neon
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Retrieve projects count<br/>
        /// Retrieves the number of active projects you can access in the specified organization, without paging through the list of projects.<br/>
        /// Projects that are being created or deleted are not counted.<br/>
        /// If using a personal API key, include the `org_id` parameter to specify which organization to work with.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.ProjectsCountResponse> CountProjectsAsync(
            string? orgId = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve projects count<br/>
        /// Retrieves the number of active projects you can access in the specified organization, without paging through the list of projects.<br/>
        /// Projects that are being created or deleted are not counted.<br/>
        /// If using a personal API key, include the `org_id` parameter to specify which organization to work with.<br/>
        /// If using an org API key, `org_id` is automatically inferred from the key.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.ProjectsCountResponse>> CountProjectsAsResponseAsync(
            string? orgId = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}