#nullable enable

namespace Neon
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Delete a custom domain from a branch<br/>
        /// Removes a custom domain registered on the branch and stops routing it.<br/>
        /// For organizations on the per-project role model, deleting a custom domain<br/>
        /// requires the project Admin role. Other callers receive `403` with code<br/>
        /// `CUSTOM_DOMAIN_ADMIN_REQUIRED`. Organization API keys keep write-level<br/>
        /// access.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteProjectBranchCustomDomainAsync(
            string projectId,
            string branchId,
            string domain,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a custom domain from a branch<br/>
        /// Removes a custom domain registered on the branch and stops routing it.<br/>
        /// For organizations on the per-project role model, deleting a custom domain<br/>
        /// requires the project Admin role. Other callers receive `403` with code<br/>
        /// `CUSTOM_DOMAIN_ADMIN_REQUIRED`. Organization API keys keep write-level<br/>
        /// access.<br/>
        /// **Note**: This endpoint is currently in Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse> DeleteProjectBranchCustomDomainAsResponseAsync(
            string projectId,
            string branchId,
            string domain,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}