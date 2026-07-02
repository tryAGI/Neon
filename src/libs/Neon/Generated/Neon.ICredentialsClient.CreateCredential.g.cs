#nullable enable

namespace Neon
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Issue a scoped credential on the branch<br/>
        /// Issues a new scoped service credential anchored to the specified<br/>
        /// branch. The response carries `api_token` and `s3_secret_access_key`<br/>
        /// exactly once — they are not stored server-side.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CreateCredentialResponse> CreateCredentialAsync(
            string projectId,
            string branchId,

            global::Neon.CreateCredentialRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue a scoped credential on the branch<br/>
        /// Issues a new scoped service credential anchored to the specified<br/>
        /// branch. The response carries `api_token` and `s3_secret_access_key`<br/>
        /// exactly once — they are not stored server-side.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neon.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.AutoSDKHttpResponse<global::Neon.CreateCredentialResponse>> CreateCredentialAsResponseAsync(
            string projectId,
            string branchId,

            global::Neon.CreateCredentialRequest request,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue a scoped credential on the branch<br/>
        /// Issues a new scoped service credential anchored to the specified<br/>
        /// branch. The response carries `api_token` and `s3_secret_access_key`<br/>
        /// exactly once — they are not stored server-side.<br/>
        /// **Note**: This endpoint is currently in Private Beta.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="branchId"></param>
        /// <param name="name">
        /// Free-form customer label for the credential.
        /// </param>
        /// <param name="scopes"></param>
        /// <param name="principalType">
        /// Principal type for the credential. Only `user` is customer-managed<br/>
        /// and accepted here. `function` and `system` credentials are<br/>
        /// platform-internal (e.g. function-serve auto-mint, presign signer)<br/>
        /// and are never issued through the customer-facing API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neon.CreateCredentialResponse> CreateCredentialAsync(
            string projectId,
            string branchId,
            global::System.Collections.Generic.IList<global::Neon.CredentialScope> scopes,
            string? name = default,
            global::Neon.CreateCredentialRequestPrincipalType principalType = default,
            global::Neon.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}