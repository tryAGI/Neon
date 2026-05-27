#nullable enable

namespace Neon
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List organizations for the current user<br/>
        /// Retrieves the organizations that the currently authenticated user belongs to.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.OrganizationsResponse> GetCurrentUserOrganizationsAsync(
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organizations for the current user<br/>
        /// Retrieves the organizations that the currently authenticated user belongs to.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.OrganizationsResponse>> GetCurrentUserOrganizationsAsResponseAsync(
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}