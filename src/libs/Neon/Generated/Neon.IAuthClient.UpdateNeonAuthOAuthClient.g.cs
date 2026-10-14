#nullable enable

namespace Neon
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Update an OAuth client<br/>
        /// Updates an OAuth client. Only the fields provided in the request body are updated.<br/>
        /// A provided `resources` list replaces the client's stored list. The client `type` cannot be changed.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthClient> UpdateNeonAuthOAuthClientAsync(
            string projectId,
            string branchId,
            string clientId,

            global::Neon.NeonAuthOAuthClientUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an OAuth client<br/>
        /// Updates an OAuth client. Only the fields provided in the request body are updated.<br/>
        /// A provided `resources` list replaces the client's stored list. The client `type` cannot be changed.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.NeonAuthOAuthClient>> UpdateNeonAuthOAuthClientAsResponseAsync(
            string projectId,
            string branchId,
            string clientId,

            global::Neon.NeonAuthOAuthClientUpdateRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an OAuth client<br/>
        /// Updates an OAuth client. Only the fields provided in the request body are updated.<br/>
        /// A provided `resources` list replaces the client's stored list. The client `type` cannot be changed.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="clientId"></param>
        /// <param name="name">
        /// Display name of the client.
        /// </param>
        /// <param name="redirectUris">
        /// Redirect URIs the client may use. When provided, replaces the stored list.
        /// </param>
        /// <param name="skipConsent">
        /// Whether to skip the consent prompt for this client.
        /// </param>
        /// <param name="disabled">
        /// Whether the client is disabled.
        /// </param>
        /// <param name="resources">
        /// Identifiers of the protected resources to link the client to. When provided, replaces the stored list.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.NeonAuthOAuthClient> UpdateNeonAuthOAuthClientAsync(
            string projectId,
            string branchId,
            string clientId,
            string? name = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            bool? skipConsent = default,
            bool? disabled = default,
            global::System.Collections.Generic.IList<string>? resources = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}